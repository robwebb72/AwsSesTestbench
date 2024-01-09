# Aws Ses Testbench

This is a prototype/test-bench to provide a number of endpoints for working with Aws's Simple Email Service.

## Packages Used

- EntityFramework Core
- Automapper
- ASP.NET
- AWS SDK
- Swashbuckle

## appsettings.json

The `appsettings.json` file will need to be populated with:

- AWS access and secret access keys
- connection strings for databases (with options for local and/or remote databases)

The `appsettings.development.json` has been added to `.gitignore`.  It has the same format as `appsettings.json`
