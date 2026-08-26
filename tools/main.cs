#!/usr/bin/env dotnet
#:include constants.cs
#:include scrapper.cs
#:include mapper.cs
#:include generator.cs

var ourpurPath = args.FirstOrDefault() ?? ScriptConstants.DEFAULT_OUTPUT_PATH;

Console.WriteLine("Scraping Telegram Bot API Definitions...");
var definitions = await Scrapper.ScrapBotApiDefinitions();
Console.WriteLine();

Console.WriteLine("Mapping models...");
var modelClasses = definitions.MapTypesIntoClasses().ToList();
Console.WriteLine("Mapping extension methods...");

try
{
    var methodClasses = definitions.MapMethodsIntoClasses().ToList();
    Console.WriteLine("Mapping constants...");
    var constants = definitions.MapConstantsIntoClasses().ToList();
    Console.WriteLine();
    var classFiles = modelClasses.Concat(methodClasses).Concat(constants);
    Console.WriteLine("Generating classes...");
    Generator.GenerateClasses(classFiles, ourpurPath);
    Console.WriteLine("Done!");
}
catch (Exception exp)
{
    Console.WriteLine(exp.Message);
    throw;
}
