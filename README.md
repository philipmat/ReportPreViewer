# Report(Pre)Viewer
Report(Pre)Viewer allows you to quickly and easily preview Microsoft .rdlc reports.

## Why?
Sure, you have the [ReportViewer Control](https://msdn.microsoft.com/en-us/library/ms251671.aspx), and I think it's great (after all this app is built on it), but you need to:
1. create a Visual Studio project, 
2. put the control on a form, 
3. point it to a report, 
4. set up your data sources, 
5. set up data bindings, 
6. define data sets, 
7. and then run the app. 

Need a new report? Back to square 3. Need to tweak the data? Back to square 6. Need to change the report? Well, you get the idea.

**Report(Pre)Viewer** helps you avoid all these step.

## How?

Load the app, point it to an `.rdlc` file, tell it where and how to get the data for the report and you're done.

Need to tweak the data? A click away. Need to select a different report? A click away. Made changes to the report and need to see the results? Click one button.

*[image here]*

## Installation

You will need to install the [Microsoft Report Viewer Runtime](https://www.microsoft.com/en-us/download/details.aspx?id=35747); currently, the latest version is 2012 or v11.

You will need some sort of driver for your database. If you use Microsoft SQL Server, the driver is already on your system. For other databases:

* [SQLite]()
* [PostgreSQL]()
* [MySQL]()
* [Oracle]()

You can either clone this report and build this project in Visual Studio 2013, or [download the binaries]().

## How to use the app

### Report Path
Path to .rdlc file. If your rdlc has subreports, the main report will attempt to load them, if it can find them: that typically means they should be in the same location as the main report file.

### Connection String
A valid connection string for your database.

* **SQL Server**: https://www.connectionstrings.com/sql-server/

### Data Sources
Your report(s) has one or more datasources it uses to render itself. In this section provide the name of each data source and a query string that can be used to load its data.
