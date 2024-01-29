#!/usr/bin/env dotnet-script
#nullable enable
#load "constants.csx"
#load "scrapper.csx"
#load "mapper.csx"
#load "generator.csx"

using System.Net.Http;

var ourpurPath = Args.FirstOrDefault() ?? ScriptConstants.DEFAULT_OUTPUT_PATH;

WriteLine("Scraping Telegram Bot API Definitions...");
var definitions = await ScrapBotApiDefinitions();
WriteLine();

WriteLine("Mapping models...");
var modelClasses = definitions.MapTypesIntoClasses();
WriteLine("Mapping extension methods...");
var methodClasses = definitions.MapMethodsIntoClasses();
WriteLine("Mapping constants...");
var constants = definitions.MapConstantsIntoClasses();
WriteLine();
var classFiles = modelClasses
    .Concat(methodClasses)
    .Concat(constants);
WriteLine("Generating classes...");
GenerateClasses(classFiles, ourpurPath);
WriteLine("Done!");