# Initializing the database
- dotnet tool install --global dotnet-ef

- dotnet ef migrations add initial -p Infrastructure -s UI
- dotnet ef database update -p Infrastructure -s UI