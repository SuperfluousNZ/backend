# Capstone Back-End

## Setup Instructions:

### Opening Project
- Clone project and open in Rider or VSCode.
- Navigate to the CapstoneBackend folder `\backend\DigraphyApi`.
- Download the dotnet SDK from https://aka.ms/dotnet-download (Make sure to download .Net 8.0 and download the installer for your device).

### Downloading entity Framework
- Run `dotnet tool install --global dotnet-ef`, you may need to check your path variables in case the dotnet tools has not been added.
- (You may need to close and reopen your IDE to get this step to work).

### Checking Path Variables
- Right-click on the start button and go to system.
- Click advanced system settings.
- Click environment variables.
- go down to system variables and scroll down to Path.
- Click edit.
- If you do not see `.dotnet/tools` in there then you must add it.

### Updating Path Variabls
- Click new and add the file path to `.dotnet/tools` (the file is most likely found at `C:\Users\[Username]\.dotnet\tools`).
-  Close each of the tabs you opened by pressing OK.

### Migrate the entities to the database
- Close the IDE and reopen it.
- Run `dotnet ef migrations add InititalMigration`.
- Run `dotnet ef database update`.

### Run the application
- Run `dotnet run`, (this should automatically launch a tab in your browser).