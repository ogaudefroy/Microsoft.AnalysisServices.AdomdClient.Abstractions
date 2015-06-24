# Microsoft.AnalysisServices.AdomdClient.Abstractions
Set of abstraction classes for Microsoft.AnalysisServices.AdomdClient to support substitution.

Available interfaces:
 - IAdomdConnection: extracted from AdomdConnection, can be retrieved from a regular AdomdConnection with AdomdConnectionWrapper
 - IAdomdCommand: extracted from AdomdCommand, can be retrieved from a regular AdomdCommand with AdomdCommandWrapper or with CreateCommand on a IAdomdConnection
 
Code documentation has been synched with MSDN documentation.
AdomdClient version supported is 12.0

Code sample:

    IAdomdConnection connection = new AdomdConnectionWrapper(new AdomdConnection());
    IAdomdCommand command = connection.CreateCommand();
    IAdomdCommand newCommand = new AdomdCommandWrapper(new AdomdCommand());
	
[![Build status](https://ci.appveyor.com/api/projects/status/0spql768wtea7i0j/branch/master?svg=true)](https://ci.appveyor.com/project/ogaudefroy/microsoft-analysisservices-adomdclient-abstraction/branch/master)