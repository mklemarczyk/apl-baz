set _PATH=%~dp0
set CLASS="%1;%_PATH%..\..\libs\activejdbc_instrumentation-1_4_6\activejdbc-instrumentation.jar;%_PATH%..\..\libs\javassist-3_19_0-GA\javassist.jar;%_PATH%..\..\libs\activejdbc-1_4_6\activejdbc.jar"

java -cp %CLASS% -DoutputDirectory=bin org.javalite.instrumentation.Main
