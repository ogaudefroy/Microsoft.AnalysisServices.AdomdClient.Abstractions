# Microsoft.AnalysisServices.AdomdClient.Abstractions
Set of abstraction classes for Microsoft.AnalysisServices.AdomdClient to support substitution.

Available interfaces:
 - IAdomdConnection: extracted from AdomdConnection, can be retrieved from a regular AdomdConnection with AdomdConnectionWrapper
 - IAdomdCommand: extracted from AdomdCommand, can be retrieved from a regular AdomdCommand with AdomdCommandWrapper or with CreateCommand on a IAdomdConnection
 
Code documentation has been synched with MSDN documentation.

AdomdClient version supported is 12.0

Usage:

    IAdomdConnection connection = new AdomdConnectionWrapper(new AdomdConnection());
    IAdomdCommand command = connection.CreateCommand();
    IAdomdCommand newCommand = new AdomdCommandWrapper(new AdomdCommand());

NuGet Package available here: https://www.nuget.org/packages/Microsoft.AnalysisServices.AdomdClient.Abstractions/

[![Build status](https://ci.appveyor.com/api/projects/status/cvc5bjubnj73j1jv?svg=true)](https://ci.appveyor.com/project/ogaudefroy/microsoft-analysisservices-adomdclient-abstraction)	
