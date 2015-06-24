# Microsoft.AnalysisServices.AdomdClient.Abstractions
Set of abstraction classes for AdomdClient to support substitution.

Currently only two wrappers are available : 

 - AdomdConnectionWrapper: Wraps an AdomdConnection in a IAdomdConnection
 - AdomdCommandWrapper: Wraps an AdomdCommand in a IAdomdCommand
 
Interfaces documentation has been synched with MSDN documentation

Very simple to use:

    IAdomdConnection connection = new AdomdConnectionWrapper(new AdomdConnection());
    IAdomdCommand command = connection.CreateCommand();
    IAdomdCommand newCommand = new AdomdCommandWrapper(new AdomdCommand());