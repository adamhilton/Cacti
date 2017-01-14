# Cacti - an ASP.NET Core CMS and Blog Engine

[![Build status](https://img.shields.io/appveyor/ci/felsig/cacti/master.svg?style=flat-square)](https://ci.appveyor.com/project/Felsig/cacti/branch/master)
[![License](https://img.shields.io/badge/license-MIT-blue.svg?style=flat-square)](LICENSE)

## quick start

1. navigate to src/Cacti.Web
2. run 'dotnet user-secrets set CACTI_ADMINUSER {admin-user-name} && dotnet user-secrets set CACTI_ADMINPASS {admin-user-password}'
3. run 'dotnet run --Environment=Development' in Cacti.Web project
4. site should be running on localhost:5000


## supported databases

- in memory 
- postgreSql


## supported environment variables

**CACTI_ADMINUSER** (Required) - used to set initial admin username

**CACTI_ADMINPASS** (Required) - used to set initial admin password

**CACTI_DBTYPE** (Required) - used to select which database to use

**CACTI_DBHOST** (Required if database is  not in memory) - used as part of db connection string if a non in-memory database is chosen

**CACTI_DBNAME** (Required if database is  not in memory) - used as part of db connection string if a non in-memory database is chosen

**CACTI_DBOWNER** (Required if database is  not in memory) - used as part of db connection string if a non in-memory database is chosen

**CACTI_DBPASSWORD** (Required if database is  not in memory) - used as part of db connection string if a non in-memory database is chosen

**CACTI_DBPORT** (Required if database is  not in memory) - used as part of db connection string if a non in-memory database is chosen

**CACTI_DBPOOLING** (Required if database is  not in memory) - used as part of db connection string if a non in-memory database is chosen

## license

[MIT License](LICENSE)
 
