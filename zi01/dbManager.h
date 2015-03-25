#include <stdlib.h>
#include <string.h>
#include <libpq-fe.h>
#include "../stdafx.h"

void openConnection();

void closeConnection();

void doSQL(char *command);
