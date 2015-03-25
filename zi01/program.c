#include "dbManager.h"
#include "structureManager.h"
#include "dataManager.h"

#include <stdio.h>

void printMenu(){
	printf("1. Create table\n");
	printf("2. Drop table\n");
	printf("3. New record\n");
	printf("4. Modify record\n");
	printf("5. Delete record\n");
	printf("6. Show table\n");
	printf("7. Import data from file\n");
	printf("8. Create trigger (range validation)\n");
	printf("9. Drop trigger\n");
	printf("A. Add column\n");
	printf("S. Show table as HTML\n");
	printf("Q. Quit\n");
}

char readOption(){
	char d;
	scanf("%c", &d);
	if(d >= 'A' && d <= 'Z')
		d += 'a' - 'A';
	return d;
}

void doMenu(char option){
	switch(option){
		case '1': createTable();
			break;
		case '2': dropTable();
			break;
		case '3': insertRow();
			break;
		case '4': modifyRow();
			break;
		case '5': removeRow();
			break;
		case '6': showData();
			break;
		case '7': importData();
			break;
		case '8': createTrigger();
			break;
		case '9': dropTrigger();
			break;
		case 'a': addColumn();
			break;
		case 's': showDataAsHtml();
			break;
	}
}

int main(){
	openConnection();
	char o = ' ';
	while(o != 'q'){
		if(o != ' '){ getchar(); getchar(); }
		system("clear");
		printMenu();
		o = readOption();
		system("clear");
		doMenu(o);
	}
	closeConnection();
	return 0;
}
