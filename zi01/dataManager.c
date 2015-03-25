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
	doSQL("SELECT * FROM kurs;");
}

void showDataAsHtml(){
	
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
