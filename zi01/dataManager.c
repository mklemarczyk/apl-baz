#include "dataManager.h"

void insertRow(){
	PGconn * conn = getConnection();
	PGresult *result;

	char * command = "SELECT column_name, udt_name FROM information_schema.columns WHERE table_name = 'kurs'";
	char sql[1500] = "INSERT INTO kurs VALUES(";
	char* msg;

	result = PQexec(conn, command);
	msg = PQresultErrorMessage(result);
	if(strlen(msg) > 0){
		printf("Error: %s\n", msg);
		return;
	}

	if(PQresultStatus(result) == PGRES_TUPLES_OK) {
		int m;
		int nrows   = PQntuples(result);
		if(nrows == 0){
			printf("Nie znaleziono kolumn w tabeli kurs.\n");
			return;
		}
		for(m = 0; m < nrows; m++) {
			char* name = PQgetvalue(result, m, 0);
			char* type = PQgetvalue(result, m, 1);
			if(strcmp(name, "id") == 0){
				strcat(sql, "DEFAULT, ");
				continue;
			}else{
				char p[255];
				printf("%s: ", name);
				scanf("%s", p);
				strcat(sql, "'");
				strcat(sql, p);
				strcat(sql, "'");
				if(m < nrows -1){
					strcat(sql, ", ");
				}
			}
		}
	}

	PQclear(result);

	strcat(sql, ");");

	doSQL(sql);
}

void modifyRow(){
	int id;

	system("clear");

	printf("Row id: ");
	scanf("%d", &id);

	char command[255];
	sprintf(command, "SELECT * FROM kurs WHERE id = %d;", id);

	PGconn * conn = getConnection();
	PGresult *result;

	char* msg;
	result = PQexec(conn, command);
	msg = PQresultErrorMessage(result);
	if(strlen(msg) > 0){
		printf("Error: %s\n", msg);
		return;
	}

	char sql[1500] = "UPDATE kurs SET ";

	if(PQresultStatus(result) == PGRES_TUPLES_OK) {
		int n;
		int m;
		int nrows   = PQntuples(result);
		int nfields = PQnfields(result);
		if(nrows == 0){
			printf("Nie znaleziono kolumn w tabeli kurs.\n");
			return;
		}
		
		int inseted = 0;
		for(m = 0; m < nrows; m++) {
			for(n = 0; n < nfields; n++) {
				char* name = PQfname(result, n);
				int type = PQftype(result, n);
				if(strcmp(name, "id") == 0){
					continue;
				}else{
					char p[255];
					printf("%s: ", name);
					scanf("%s", p);
					if(strcmp(p, "$") != 0){
						if(inseted > 0){
							strcat(sql, ", ");
						}
						strcat(sql, name);
						strcat(sql, " = '");
						strcat(sql, p);
						strcat(sql, "'");
						inseted++;
					}
				}
			}
		}
	}
	PQclear(result);

	sprintf(sql, "%s WHERE id = %d;", sql, id);

	doSQL(sql);
}

void removeRow(){
	int id;

	system("clear");

	printf("Row id: ");
	scanf("%d", &id);

	char sql[255];
	sprintf(sql, "DELETE FROM kurs WHERE id = %d;", id);
	doSQL(sql);
}

void showData(){
	doSQL("SELECT * FROM kurs;");
}

void showDataAsHtml(){
	FILE *fp;

	fp = fopen("out.html", "w");
	fprintf(fp, "<!DOCTYPE html>\n<html>\n<head>\n<meta charset=\"utf-8\">\n<title>Dane</title>\n</head>\n<body>\n");

	char * command = "SELECT * FROM kurs;";
	PGconn * conn = getConnection();
	PGresult *result;
	char* msg;

	result = PQexec(conn, command);
	msg = PQresultErrorMessage(result);
	if(strlen(msg) > 0)
		fprintf(fp, "<div>Error: %s</div>\n", msg);

	if(PQresultStatus(result) == PGRES_TUPLES_OK) {
		int n;
		int m;
		int nrows   = PQntuples(result);
		int nfields = PQnfields(result);
		fprintf(fp, "<table>\n");
		fprintf(fp, "<tr>\n");
		for(n = 0; n < nfields; n++){
			fprintf(fp, "<th>%s</th>", PQfname(result, n));
		}
		fprintf(fp, "</tr>\n");
		printf("\n");
		for(m = 0; m < nrows; m++) {
			fprintf(fp, "<tr>\n");
			for(n = 0; n < nfields; n++)
				fprintf(fp, "<td>%s</td>\n", PQgetvalue(result,m,n));
			fprintf(fp, "</tr>\n");
		}
		fprintf(fp, "</table>\n");
	}
	PQclear(result);

	fprintf(fp, "</body>\n</html>\n");
	fclose(fp);
}

void importData(){
	
}
