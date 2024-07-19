# Getting Started
To build and run this sample as-is, you'll need Visual Studio Comunity Version with .net Framework SDK 4.7.2.

In most cases you can run the application by following these steps:

* Download and extract the .zip file.
* Open the solution file in Visual Studio.
* Build the solution, which automatically installs the missing NuGet packages.
* Open the Package Manager Console, and run the update-database command to create the database.
* Run the application.

If you have any problems with those instructions, follow these longer instructions.

* Download the .zip file.
* In File Explorer, right-click the .zip file and click Properties, then in the Properties window click Unblock.
* Unzip the file.
* Double-click the .sln file to launch Visual Studio.
* From the Tools menu, click Library Package Manager, then Package Manager Console.
* In the Package Manager Console (PMC), click Restore.
* Exit Visual Studio.
* Restart Visual Studio, opening the solution file you closed in the previous step.
* In the Package Manager Console (PMC), enter the Update-Database command. (If you get the following error:
 "The term 'Update-Database' is not recognized as the name of a cmdlet, function, script file, or operable program", exit and restart Visual Studio.)
* Each migration will run, then the seed method will run. You can now run the application.

# Running the Sample
To run the sample, hit F5 or choose the Debug | Start Debugging menu command. You will see the home page which includes a menu bar. (In a narrow browser window you'll have to click the symbol at the top right of the page in order to see the menu.)

From this page you can select any of the tabs to perform various actions such as display a list of students, add new students, display a list of instructors, and so forth.

# Source Code Overview
The ContosoUniversity folder includes the following folders and files

* App_Data folder - Holds the SQL Server Compact database file.
* Content - Holds CSS files.
* Controllers - Holds controller classes.
* DAL folder - The data access layer.  Holds the context, initializer, repository, and unit of work classes.
* Logging folder - Holds code that does logging.
* Migrations folder - Holds EF Code First migrations code, including the Seed method.
* Models folder - Holds model classes.
* Properties or MyProject folder - Project properties.
* Scripts folder - Script files.
* ViewModels folder - Holds view model classes. 
* Views folder - Holds view classes.
* Visual Studio project file (.csproj or .vbproj).
* packages.config - Specifies NuGet packages included in the project.
* Global.asax file - Includes database initializer code.
* Web.config file - Includes the connection string to the database.
