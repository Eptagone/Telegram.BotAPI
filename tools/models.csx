#nullable enable

using System.Text.Json.Serialization;

#region Bot API Models

/// <summary>
/// Defines base properties for all Bot API Models and Methods.
/// </summary>
/// <param name="Name">The name of this model, group or method.</param>
/// <param name="Description">The description of this model, group or method.</param>
/// <param name="SectionName">The name of the section where this model, group or method is defined.</param>
record TelegramReferenceBase(string Name, IEnumerable<string> Description, string SectionName);

/// <summary>
/// Represents a Type in the Telegram Bot API.
/// </summary>
/// <param name="Name">The name of this type.</param>
/// <param name="SectionName">The name of the section where this type is defined.</param>
/// <param name="Description">The description of this type.</param>
/// <param name="Properties">The properties of this type.</param>
record TelegramType(
    string SectionName,
    string Name,
    IEnumerable<string> Description,
    IEnumerable<TelegramTypeProperty> Properties
) : TelegramReferenceBase(Name, Description, SectionName);

/// <summary>
/// Represents a Model property in the Telegram Bot API.
/// </summary>
/// <param name="Name">The name of this property.</param>
/// <param name="Description">The description of this property.</param>
/// <param name="IsRequired">Whether this property is required.</param>
/// <param name="Types">The types that this property can be.</param>
/// <param name="ArrayLevels">The number of array levels that this property can have.</param>
record TelegramTypeProperty(
    string Name,
    IEnumerable<string> Description,
    bool IsRequired,
    IEnumerable<string> Types,
    ushort ArrayLevels
);

/// <summary>
/// Represents a group of related/derived types in the Telegram Bot API.
/// </summary>
/// <param name="SectionName">The name of the section where this group is defined.</param>
/// <param name="Name">The name of this group.</param>
/// <param name="Description">The description of this group.</param>
/// <param name="Types">The names of the types in this group.</param>
record TelegramTypeGroup(
    string SectionName,
    string Name,
    IEnumerable<string> Description,
    IEnumerable<string> Types
) : TelegramReferenceBase(Name, Description, SectionName);

/// <summary>
/// Represents a Method in the Telegram Bot API.
/// </summary>
/// <param name="Name">The name of this method.</param>
/// <param name="SectionName">The name of the section where this method is defined.</param>
/// <param name="Description">The description of this method.</param>
/// <param name="Parameters">The parameters of this method.</param>
/// <param name="ReturnTypes">The possible return types of this method and their conditions.</param>
record TelegramMethod(
    string SectionName,
    string Name,
    IEnumerable<string> Description,
    IEnumerable<TelegramMethodParameter> Parameters,
    IEnumerable<TelegramReturnType> ReturnTypes
) : TelegramReferenceBase(Name, Description, SectionName);

/// <summary>
/// Represents a Method Parameter in the Telegram Bot API.
/// </summary>
/// <param name="Name">The name of this parameter.</param>
/// <param name="Description">The description of this parameter.</param>
/// <param name="IsRequired">Whether this parameter is required.</param>
/// <param name="Types">The types that this parameter can be.</param>
/// <param name="ArrayLevels">The number of array levels that this parameter can have.</param>
/// <param name="IsExclusiveWith">The names of the parameters that this parameter is exclusive with.</param>
record TelegramMethodParameter(
    string Name,
    IEnumerable<string> Description,
    bool IsRequired,
    IEnumerable<string> Types,
    ushort ArrayLevels,
    IEnumerable<string> IsExclusiveWith
);

/// <summary>
/// Represents a Return Type of a Method in the Telegram Bot API.
/// </summary>
/// <param name="Type">The return type.</param>
/// <param name="ArrayLevels">The number of array levels that this return type can have.</param>
/// <param name="DependentParameters">The parameters that determine when this return type is used.</param>
record TelegramReturnType(string Type, ushort ArrayLevels, IEnumerable<string> DependentParameters);

/// <summary>
/// Represents the Bot API Definition.
/// </summary>
/// <param name="Types">The models in the Bot API.</param>
/// <param name="Methods">The methods in the Bot API.</param>
/// <param name="TypeGroups">The model groups in the Bot API.</param>
/// <param name="PropertyNames">The names of the properties in the Bot API.</param>
record BotApiDefinitions(
    IEnumerable<TelegramType> Types,
    IEnumerable<TelegramMethod> Methods,
    IEnumerable<TelegramTypeGroup> TypeGroups
)
{
    private IEnumerable<string>? propertyNames;

    /// <summary>
    /// Lists all the property names in the Bot API.
    /// </summary>
    /// <remarks>
    /// This includes the names of the properties of the models and the names of the parameters of the methods.
    /// </remarks>
    public IEnumerable<string> PropertyNames =>
        this.propertyNames ??= this
            .Types.SelectMany(m => m.Properties)
            .Select(p => p.Name)
            .Union(this.Methods.SelectMany(m => m.Parameters).Select(p => p.Name))
            .Distinct();

    /// <summary>
    /// Lists all the model names in the Bot API.
    /// </summary>
    public IEnumerable<string> MethodNames => this.Methods.Select(m => m.Name);
};

#endregion

#region Class Generation

/// <summary>
/// Represents the type of class that will be generated.
/// <list type="bullet">
/// <item><term>Model</term> <description>A model representing a type in the Bot API.</description></item>
/// <item><term>ModelWithConstructor</term> <description>A model representing a type in the Bot API with a constructor.</description></item>
/// <item><term>BaseModel</term> <description>A base model, usually for a group of related types.</description></item>
/// <item><term>BaseModelWithConstructor</term> <description>A base model, usually for a group of related types, with a constructor.</description></item>
/// <item><term>MethodArguments</term> <description>A class containing the arguments for a method.</description></item>
/// <item><term>MethodArgumentsWithAttachments</term> <description>A class containing the arguments for a method with attachments.</description></item>
/// <item><term>ExtensionMethods</term> <description>A class containing the extension methods for a method.</description></item>
/// <item><term>Constants</term> <description>A class containing constants.</description></item>
/// </list>
/// </summary>
public enum ClassModelType
{
    Model,
    ModelWithConstructor,
    BaseModel,
    BaseModelWithConstructor,
    MethodArguments,
    MethodArgumentsWithAttachments,
    ExtensionMethods,
    Constants
}

/// <summary>
/// Represents a Class Definition.
/// </summary>
/// <param name="Namespace">The namespace where this class is defined.</param>
/// <param name="Name">The name of this class.</param>
/// <param name="Description">The description of this class.</param>
/// <param name="Properties">The properties of this class.</param>
/// <param name="Methods">The methods of this class.</param>
/// <param name="ClassType">The type of class that will be generated.</param>
/// <param name="Usings">The usings that this class will have.</param>
/// <param name="BaseClass">The base class of this class.</param>
record ClassDefinition(
    string Name,
    IEnumerable<string> Description,
    string Namespace,
    string FileName,
    IEnumerable<ClassPropertyDefinition> Properties,
    IEnumerable<ClassMethodDefinition> Methods,
    ClassModelType ClassType,
    IEnumerable<string> Usings,
    ClassDefinition? BaseClass = null
);

/// <summary>
/// Represents a Class Property Definition.
/// </summary>
/// <param name="Name">The name of this property.</param>
/// <param name="Description">The description of this property.</param>
/// <param name="Types">The types that this property can be.</param>
/// <param name="IsRequired">Whether this property is required.</param>
/// <param name="IsAbstract">Whether this property is abstract.</param>
/// <param name="Value">Optional. The value of this property.</param>
record ClassPropertyDefinition(
    string Name,
    IEnumerable<string> Description,
    IEnumerable<string> Types,
    bool IsRequired,
    bool IsAbstract = false,
    bool IsReadOnly = false,
    string? Value = null
);

/// <summary>
/// Represents a Class Method Definition.
/// </summary>
/// <param name="Name">The name of this method.</param>
/// <param name="Description">The description of this method.</param>
/// <param name="Parameters">The parameters of this method.</param>
/// <param name="ReturnType">The return type of this method.</param>
record ClassMethodDefinition(
    string Name,
    IEnumerable<string> Description,
    IEnumerable<ClassMethodParameterDefinition> Parameters,
    string ReturnType
);

/// <summary>
/// Represents a Class Method Parameter Definition.
/// </summary>
/// <param name="Name">The name of this parameter.</param>
/// <param name="Description">The description of this parameter.</param>
/// <param name="Type">The type of this parameter.</param>
/// <param name="IsRequired">Whether this parameter is required.</param>
record ClassMethodParameterDefinition(
    string Name,
    IEnumerable<string> Description,
    string Type,
    bool IsRequired
);

#endregion
