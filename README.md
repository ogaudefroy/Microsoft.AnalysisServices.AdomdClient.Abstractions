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

[![NuGet version](https://badge.fury.io/nu/Microsoft.AnalysisServices.AdomdClient.Abstractions.svg)](https://badge.fury.io/nu/Microsoft.AnalysisServices.AdomdClient.Abstractions)
[![License](https://img.shields.io/badge/license-MIT-blue.svg)](https://raw.githubusercontent.com/ogaudefroy/Microsoft.AnalysisServices.AdomdClient.Abstractions/master/LICENSE)
