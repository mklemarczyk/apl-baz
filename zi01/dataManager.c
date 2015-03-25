#include "dataManager.h"

void insertRow(){
	doSQL("INSERT INTO kurs(name) VALUES('2');");
}

void modifyRow(){
	
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
	doSQL"SELECT * FROM kurs;";
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

/*int main(){
  PGresult *result;
  PGconn   *conn;

  conn = PQconnectdb("host=localhost port=5432 dbname=nazwa user=login password=haslo");
  if(PQstatus(conn) == CONNECTION_OK) {
    printf("connection made\n");

    doSQL(conn, "DROP TABLE number");
    doSQL(conn, "CREATE TABLE number(value INTEGER PRIMARY KEY, name VARCHAR)");
    doSQL(conn, "INSERT INTO number values(42, 'The Answer')");
    doSQL(conn, "INSERT INTO number values(29, 'My Age')");
    doSQL(conn, "INSERT INTO number values(30, 'Anniversary')");
    doSQL(conn, "INSERT INTO number values(66, 'Clickety-Click')");
    doSQL(conn, "SELECT * FROM number");
    doSQL(conn, "UPDATE number SET name = 'Zaphod' WHERE value = 42");
    doSQL(conn, "DELETE FROM number WHERE value = 29");
    doSQL(conn, "SELECT * FROM number");
  }
  else
    printf("connection failed: %s\n", PQerrorMessage(conn));

  PQfinish(conn);
  return EXIT_SUCCESS;
}*/
