#include "dbManager.h"

PGconn *conn;

void openConnection(){
	char* dns = "host=localhost port=5432 dbname=mklemarczyk user=mklemarczyk password=" password;
	conn = PQconnectdb(dns);
	if(PQstatus(conn) == CONNECTION_OK)
		printf("[INFO]: Connection made\n");
	else
		printf("[ERROR]: Connection failed: %s\n", PQerrorMessage(conn));
}

PGconn * getConnection(){
	return conn;
}

void closeConnection(){
	PQfinish(conn);
}

void doSQL(char *command){
	PGresult *result;
	char* msg;

	printf("[INFO]: %s\n", command);

	result = PQexec(conn, command);

	msg = PQresStatus(PQresultStatus(result));
	if(strlen(msg) > 0)
		printf("[INFO]: status is     : %s\n", msg);

	msg = PQcmdTuples(result);
	if(strlen(msg) > 0)
		printf("[INFO]: #rows affected: %s\n", msg);

	msg = PQresultErrorMessage(result);
	if(strlen(msg) > 0)
		printf("[INFO]: message: %s\n", msg);

	switch(PQresultStatus(result)) {
		case PGRES_TUPLES_OK:{
			int n = 0;
			int m = 0;
			int nrows   = PQntuples(result);
			int nfields = PQnfields(result);
			printf("[INFO]: number of rows returned   = %d\n", nrows);
			printf("[INFO]: number of fields returned = %d\n", nfields);
			for(m = 0; m < nrows; m++) {
				for(n = 0; n < nfields; n++)
					printf("%s = %s, ", PQfname(result, n),PQgetvalue(result,m,n));
					printf("\n");
			}
		}
	}
	PQclear(result);
}
