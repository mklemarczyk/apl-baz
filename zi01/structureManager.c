#include "structureManager.h"

void createTable(){
	//w tym łańcuch znaków, data, liczba, waluta
	doSQL("CREATE TABLE kurs(id SERIAL PRIMARY KEY, name VARCHAR(50) NOT NULL, lastchange DATE NULL, value MONEY, changes INT NOT NULL);");
}

void dropTable(){
	doSQL("DROP TABLE kurs;");
}

void addColumn(){ // select column_name, data_type from information_schema.columns
	char columnname[255];
	char typename[255];

	system("clear");

	printf("Column name: ");
	scanf("%s", columnname);

	printf("Type: ");
	scanf("%s", typename);

	char sql[255];
	sprintf(sql, "ALTER TABLE kurs ADD %s %s;", columnname, typename);
	doSQL(sql);
}

void createTrigger(){
	double from;
	double to;

	do{
		printf("Value from: ");
		scanf("%lf", &from);

		printf("Value to: ");
		scanf("%lf", &to);
		
		if(from > to){
			printf("Wartosc poczatkowanie moze byc wieksza od koncowej!\n");
		}
	}while(from > to);

	char sql[400];
	sprintf(sql, "CREATE OR REPLACE FUNCTION valid_waluta() RETURNS TRIGGER AS $$ BEGIN IF NEW.value < CAST(%lf AS MONEY) OR NEW.value > CAST(%lf AS MONEY) THEN RAISE EXCEPTION \'Wartosc poza granicami.\'; END IF; RETURN NEW; END; $$ LANGUAGE 'plpgsql';", from, to);
	doSQL(sql);

	doSQL("DROP TRIGGER IF EXISTS kurs_insert ON kurs");
    doSQL("CREATE TRIGGER kurs_insert BEFORE INSERT OR UPDATE ON kurs FOR EACH ROW EXECUTE PROCEDURE valid_waluta();");
}

void dropTrigger(){
	doSQL("DROP TRIGGER IF EXISTS kurs_insert ON kurs");
}
