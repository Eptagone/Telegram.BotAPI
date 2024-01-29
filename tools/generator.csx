#nullable enable
#r "nuget: Humanizer.Core, 2.14.1"
#load "models.csx"
#load "constants.csx"

using Humanizer;

static void GenerateClasses(IEnumerable<ClassDefinition> classes, string outputPath)
{
    foreach (var @class in classes)
    {
        var builder = new StringBuilder();
        builder.AppendLine("// Copyright (c) 2024 Quetzal Rivera.");
        builder.AppendLine(
            "// Licensed under the MIT License, See LICENCE in the project root for license information."
        );
        builder.AppendLine("//* This file is auto-generated. Don't edit it manually!");
        builder.AppendLine();
        var usings = @class.Usings.Where(u => u != @class.Namespace);
        if (@class.ClassType == ClassModelType.BaseModel && @class.Properties.Any())
        {
            builder.AppendLine($"using {ScriptConstants.PROJECT_NAME}.Converters;");
            if (!usings.Any())
            {
                builder.AppendLine();
            }
        }
        if (usings.Any())
        {
            foreach (var @using in usings)
            {
                builder.AppendLine($"using {@using};");
            }
            builder.AppendLine();
        }
        builder.AppendLine($"namespace {@class.Namespace};");
        builder.AppendLine();
        builder.AppendLine("/// <summary>");
        foreach (var docLine in @class.Description)
        {
            builder.AppendLine($"/// {docLine}");
        }
        builder.AppendLine("/// </summary>");
        // Open the class according to its type
        switch (@class.ClassType)
        {
            case ClassModelType.ExtensionMethods:
            case ClassModelType.Constants:
                builder.AppendLine($"public static partial class {@class.Name}");
                break;
            case ClassModelType.BaseModel:
                // If the class has properties, set a JSON converter
                if (@class.Properties.Any())
                {
                    builder.AppendLine($"[JsonConverter(typeof({@class.Name}Converter))]");
                }
                builder.AppendLine($"public abstract class {@class.Name}");
                break;
            default:
                builder.Append($"public class {@class.Name}");
                var baseClassName =
                    @class.ClassType == ClassModelType.MethodArgumentsWithAttachments
                        ? "AttachedFilesArgsBase"
                        : @class.BaseClass?.Name;
                if (!string.IsNullOrEmpty(baseClassName))
                {
                    builder.AppendLine($" : {baseClassName}");
                }
                else
                {
                    builder.AppendLine();
                }
                break;
        }
        builder.AppendLine("{");

        // Render extension methods
        foreach (var method in @class.Methods)
        {
            foreach (var isAsync in new[] { false, true })
            {
                var returnType = isAsync ? $"Task<{method.ReturnType}>" : method.ReturnType;
                var classMethodName = isAsync ? $"{method.Name}Async" : method.Name;
                builder.AppendLine("\t/// <summary>");
                foreach (var docLine in method.Description)
                {
                    builder.AppendLine($"\t/// {docLine}");
                }
                builder.AppendLine("\t/// </summary>");
                builder.AppendLine(
                    "\t/// <param name=\"client\">The <see cref=\"ITelegramBotClient\"/> instance.</param>"
                );
                foreach (var param in method.Parameters)
                {
                    builder.AppendLine(
                        $"\t/// <param name=\"{param.Name}\">{string.Join(' ', param.Description)}</param>"
                    );
                }
                if (isAsync)
                {
                    builder.AppendLine(
                        "\t/// <param name=\"cancellationToken\">The cancellation token to cancel operation.</param>"
                    );
                }
                builder.AppendLine(
                    "\t/// <exception cref=\"ArgumentNullException\">Thrown if <paramref name=\"client\"/> is <c>null</c>.</exception>"
                );
                builder.AppendLine(
                    "\t/// <exception cref=\"BotRequestException\">Thrown if the request to the Telegram Bot API fails.</exception>"
                );
                // TODO: Generate a proper returns tag
                builder.AppendLine($"\t/// <returns></returns>");
                var returnTemplate = method.ReturnType == "TResult" ? "<TResult>" : string.Empty;
                builder.AppendLine(
                    $"\tpublic static {returnType} {classMethodName}{returnTemplate}(this ITelegramBotClient client{string.Join(string.Empty, method.Parameters.Select(p => $", {p.WriteParam()}"))}{(isAsync ? ", CancellationToken cancellationToken = default" : string.Empty)})"
                );

                if (isAsync)
                {
                    builder.AppendLine("\t{");
                    builder.AppendLine($"\t\tif (client is null)");
                    builder.AppendLine($"\t\t{{");
                    builder.AppendLine($"\t\t\tthrow new ArgumentNullException(nameof(client));");
                    builder.AppendLine($"\t\t}}");
                    builder.AppendLine();

                    if (method.Parameters.Any())
                    {
                        if (method.Parameters.First().Name != "args")
                        {
                            var argsClass = classes.FirstOrDefault(c =>
                                c.Name == $"{classMethodName}Args"
                            );
                            if (argsClass == null)
                            {
                                builder.AppendLine(
                                    $"\t\tvar args = new Dictionary<string, object>()"
                                );
                                builder.AppendLine("\t\t{");
                                var rParamList = new List<string>();
                                foreach (var param in method.Parameters.Where(p => p.IsRequired))
                                {
                                    var paramName = param.Name.Pascalize();
                                    if (param.IsRequired)
                                    {
                                        var propDef = $"{{ PropertyNames.{paramName}, {param.Name}";
                                        if (CanBeNull(param.Type))
                                        {
                                            propDef +=
                                                $" ?? throw new ArgumentNullException(nameof({param.Name}))";
                                        }
                                        propDef += " }";
                                        rParamList.Add(propDef);
                                    }
                                }
                                if (rParamList.Any())
                                {
                                    builder.AppendLine(
                                        $"\t\t\t{string.Join(",\n\t\t\t", rParamList)}"
                                    );
                                }
                                builder.AppendLine("\t\t};");
                                foreach (var param in method.Parameters.Where(p => !p.IsRequired))
                                {
                                    var paramName = param.Name.Pascalize();
                                    builder.AppendLine($"\t\tif ({param.Name} is not null)");
                                    builder.AppendLine($"\t\t{{");
                                    if (param.Name == "files")
                                    {
                                        builder.AppendLine("\t\t\tforeach (var file in files)");
                                        builder.AppendLine("\t\t\t{");
                                        builder.AppendLine(
                                            "\t\t\t\targs.Add(file.Key, file.Value);"
                                        );
                                        builder.AppendLine("\t\t\t}");
                                    }
                                    else
                                    {
                                        builder.AppendLine(
                                            $"\t\t\targs.Add(PropertyNames.{paramName}, {param.Name});"
                                        );
                                    }
                                    builder.AppendLine($"\t\t}}");
                                }
                            }

                            builder.AppendLine();
                        }

                        builder.AppendLine(
                            $"\t\treturn client.CallMethodAsync<{method.ReturnType}>(MethodNames.{method.Name}, args, cancellationToken);"
                        );
                    }
                    else
                    {
                        builder.AppendLine(
                            $"\t\treturn client.CallMethodAsync<{method.ReturnType}>(MethodNames.{method.Name}, cancellationToken: cancellationToken);"
                        );
                    }
                    builder.AppendLine("\t}");
                }
                else
                {
                    builder.AppendLine(
                        $"\t\t=> client.{classMethodName}Async{returnTemplate}({string.Join(", ", method.Parameters.Select(p => p.Name))}).GetAwaiter().GetResult();"
                    );
                }

                builder.AppendLine();
            }
        }

        // Render a constructor if the class requires it
        switch (@class.ClassType)
        {
            case ClassModelType.MethodArguments:
            case ClassModelType.MethodArgumentsWithAttachments:
            case ClassModelType.ModelWithConstructor:
                // Get required properties
                var requiredProperties = @class.Properties.Where(p =>
                    p.IsRequired && string.IsNullOrEmpty(p.Value)
                );
                if (requiredProperties.Any())
                {
                    // Create parameters for the constructor
                    var parametersCombinations = requiredProperties
                        .Select(p =>
                            p.Types.Select(t => new ClassMethodParameterDefinition(
                                p.Name.Camelize(),
                                p.Description,
                                t,
                                true
                            ))
                        )
                        .Aggregate(
                            (IEnumerable<IEnumerable<ClassMethodParameterDefinition>>)
                                new[] { Enumerable.Empty<ClassMethodParameterDefinition>() },
                            (acc, cur) => from a in acc from b in cur select a.Concat(new[] { b })
                        );

                    // Render the constructor
                    foreach (var parameters in parametersCombinations)
                    {
                        builder.AppendLine("\t/// <summary>");
                        builder.AppendLine(
                            $"\t/// Initializes a new instance of the <see cref=\"{@class.Name}\"/> class."
                        );
                        builder.AppendLine("\t/// </summary>");
                        foreach (var param in parameters)
                        {
                            builder.AppendLine(
                                $"\t/// <param name=\"{param.Name}\">{string.Join(' ', param.Description)}</param>"
                            );
                        }
                        builder.AppendLine(
                            $"\tpublic {@class.Name}({string.Join(", ", parameters.Select(p => p.WriteParam()))})"
                        );
                        builder.AppendLine("\t{");
                        foreach (var param in parameters)
                        {
                            builder.Append($"\t\tthis.{param.Name.Pascalize()} = {param.Name}");
                            if (CanBeNull(param.Type))
                            {
                                builder.Append(
                                    $" ?? throw new ArgumentNullException(nameof({param.Name}))"
                                );
                            }
                            builder.AppendLine(";");
                        }
                        builder.AppendLine("\t}");
                        builder.AppendLine();
                    }
                }
                break;
        }

        // Render constants
        if (@class.ClassType == ClassModelType.Constants)
        {
            builder.AppendLine("#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member");
            // Render constants
            foreach (var item in @class.Properties)
            {
                builder.AppendLine($"\tpublic const string {item.Name} = \"{item.Value}\";");
            }
            builder.AppendLine("#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member");
        }
        // or properties
        else
        {
            foreach (var prop in @class.Properties)
            {
                var baseProp = @class.BaseClass?.Properties.FirstOrDefault(p =>
                    p.Name == prop.Name
                );
                if (baseProp?.IsAbstract == false)
                {
                    continue;
                }
                var typeName = prop.Types.Count() == 1 ? prop.Types.First() : "object";
                if (!prop.IsRequired)
                {
                    typeName += "?";
                }
                builder.AppendLine($"\t/// <summary>");
                foreach (var docLine in prop.Description)
                {
                    builder.AppendLine($"\t/// {docLine}");
                }
                builder.AppendLine($"\t/// </summary>");
                builder.AppendLine($"\t[JsonPropertyName(PropertyNames.{prop.Name})]");
                if (prop.IsAbstract)
                {
                    builder.Append($"\tpublic abstract {typeName} {prop.Name} {{ get; ");
                    if (prop.IsReadOnly)
                    {
                        builder.AppendLine($"}}");
                    }
                    else
                    {
                        builder.AppendLine($"set; }}");
                    }
                }
                else
                {
                    if (baseProp != null)
                    {
                        builder.Append($"\tpublic override {typeName} {prop.Name}");
                    }
                    else
                    {
                        builder.Append($"\tpublic {typeName} {WritePropName(prop.Name, @class)}");
                    }
                    if (string.IsNullOrEmpty(prop.Value))
                    {
                        builder.Append(@" { get; set; }");
                        if (
                            (@class.ClassType == ClassModelType.Model || @class.ClassType == ClassModelType.BaseModel)
                            && prop.IsRequired
                            && CanBeNull(typeName)
                        )
                        {
                            builder.Append(" = null!;");
                        }
                        builder.AppendLine();
                    }
                    else
                    {
                        builder.AppendLine($" => {WriteValue(prop.Value)};");
                    }
                }

                builder.AppendLine();
            }
        }

        // Close the class
        builder.AppendLine("}");
        // Build the final string
        var finalString = builder
            .ToString()
            // Remove empty lines at the end of the class
            .Replace($"{Environment.NewLine}{Environment.NewLine}}}", $"{Environment.NewLine}}}")
            // Replace tabs with 4 spaces
            .Replace("\t", "    ");

        // Write the file
        var filePath = Path.Combine(outputPath, @class.FileName);
        var directoryPath = Path.GetDirectoryName(filePath);
        if (!string.IsNullOrEmpty(directoryPath))
        {
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }
        }

        Write("Writing file {0}...", filePath);
        File.WriteAllText(filePath, finalString);
        WriteLine("Done!");
    }
}

/// <summary>
/// Formats a property name.
/// </summary>
/// <param name="propName">The property name to format.</param>
/// <param name="class">The class that contains the property.</param>
static string WritePropName(string propName, ClassDefinition @class)
{
    if (@class.Name == propName)
    {
        return @class.Name switch
        {
            "ForceReply" => "ForceReplyFlag",
            "MessageId" => "Id",
            _ => throw new Exception($"Invalid property name: {propName}")
        };
    }
    return propName;
}

/// <summary>
/// Formats a parameter for a method.
/// </summary>
/// <param name="param">The parameter to format.</param>
static string WriteParam(this ClassMethodParameterDefinition param)
{
    var builder = new StringBuilder();
    var isFiles = param.Name == "files";
    builder.Append(param.Type);
    if (!isFiles && !param.IsRequired && param.Name != "cancellationToken")
    {
        builder.Append("?");
    }
    builder.Append(' ');
    builder.Append(param.Name);
    if (!param.IsRequired)
    {
        builder.Append(" = null");
    }

    return builder.ToString();
}

/// <summary>
/// Formats a value for a property.
/// </summary>
/// <param name="value">The value to format.</param>
static string WriteValue(string value)
{
    if (value == "true")
    {
        return value;
    }
    else
    {
        return $"\"{value}\"";
    }
}

/// <summary>
/// Checks if a type can be null.
/// </summary>
static bool CanBeNull(string typeName)
{
    return typeName == "string" || typeName == "object"  || char.IsUpper(typeName[0]);
}
