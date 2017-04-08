[<img src="https://cdn.anychart.com/images/logo-transparent-segoe.png?2" width="234px" alt="AnyChart - Robust JavaScript/HTML5 Chart library for any project">](https://anychart.com)
# ASP.NET Core MVC C# basic dashboard template

This example shows how to use Anychart library with the C# programming language using ASP.NET Core MVC and MySQL database.

## Running
This example uses .NET Core 1.0.1 and MySQL 5.6.
If you miss some installations, please, visit:<br />
[MySQL download page](https://dev.mysql.com/downloads/installer/) and [installation instructions](http://dev.mysql.com/doc/refman/5.7/en/installing.html) to setup MySQL;<br />
[ASP.NET Core page](https://www.asp.net/core) to install ASP.NET Core.<br />

To start this example run commands listed below.

Clone the repository from github.com to your working directory:
```
$ git clone git@github.com:anychart-integrations/asp-net-core-mvc-mysql-dashboard.git
```

Open cmd console in `asp-net-core-mvc-mysql-dashboard` folder and set up MySQL database, use `-u -p` flags to provide username and password:
```
$  "[YOUR_PATH_TO_MYSQL]\bin\mysql.exe" -u[USER_NAME] -p < database_backup.sql
e.g:  
$  "C:\Program Files\MySQL\MySQL Server 5.6\bin\mysql.exe" -uroot -p < database_backup.sql
```

Open project in Visual Studio or Visual Studio Code.

Run application using Run button.

Or you can use next commands, be sure you're in `asp-net-core-mvc-mysql-dashboard` folder:
```
$  dotnet restore
$  dotnet run
```

## Workspace
Your workspace should look like:
```
asp-net-core-mvc-mysql-dashboard/
	Controllers/
		ChartController.cs		# main controller
	Models/
		Sale.cs				# Sale class
		SalesDBContext.cs		# DB data provider
	Views/
		Chart/
			Index.cshtml		# html template with main dashboard JS code
	wwwroot/
		css/
			style.css			# css style
	appsettings.Development.json
	appsettings.json
	asp-net-core-mvc-mysql-dashboard.csproj 	# project config
	bower.json
	bundleconfig.json
	database_backup.sql			# sql code and data
	LISENCE
	Program.cs
	README.md
	Startup.cs
```

## Technologies
Language - [C#](https://msdn.microsoft.com/en-us/library/ms228593.aspx)<br />
Web framework - [ASP.NET Core](https://www.asp.net/core)<br />
HTML Tepmlate - [Razor](https://www.asp.net/web-pages/overview/getting-started/introducing-razor-syntax-c)<br />
Database - [MySQL](https://www.mysql.com/)<br />

## Further Learning
* [Documentation](https://docs.anychart.com)
* [JavaScript API Reference](https://api.anychart.com)
* [Code Playground](https://playground.anychart.com)
* [Technical Support](https://anychart.com/support)

## License
[© AnyChart.com - JavaScript charts](http://www.anychart.com). Released under the [Apache 2.0 License](https://github.com/anychart-integrations/asp-net-core-mvc-mysql-dashboard/blob/master/LICENSE).
