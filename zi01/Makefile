INC=/usr/include/postgresql 
LIB=/usr/lib
CFLAGS=-I$(INC) -I.
LDLIBS=-L$(LIB) -lpq
CC=gcc

ALL=program dbManager structureManager dataManager
# ponizej przyklady regul i zaleznosci kompilacji wybranych plikow
program: program.o structureManager.o dataManager.o dbManager.o
	$(CC) -g $(CFLAGS) -o program program.o structureManager.o dataManager.o dbManager.o $(LDLIBS)
program.o: program.c
	$(CC) -c $(CFLAGS) -o program.o program.c $(LDLIBS)
structureManager.o: structureManager.c
	$(CC) -c $(CFLAGS) -o structureManager.o structureManager.c $(LDLIBS)
dataManager.o: dataManager.c
	$(CC) -c $(CFLAGS) -o dataManager.o dataManager.c $(LDLIBS)
dbManager.o: dbManager.c
	$(CC) -c $(CFLAGS) -o dbManager.o dbManager.c $(LDLIBS)
clean:
	@rm -f *.o *~ $(ALL)
all: clean program dbManager structureManager dataManager
