SET DOCKER_MACHINE=192.168.99.100
SET DATABASE_PORT=4916

docker pull wnameless/oracle-xe-11g
docker run --name chinook_database -d -p 49160:22 -p %DATABASE_PORT%:1521 wnameless/oracle-xe-11g

git clone https://git01.codeplex.com/chinookdatabase

cd chinookdatabase\ChinookDatabase\DataSources

SET LOCAL=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=%DOCKER_MACHINE%)(PORT=%DATABASE_PORT%)))(CONNECT_DATA=(SID=XE)))

sqlplus system/oracle @Chinook_Oracle.sql > Chinook_Oracle.log