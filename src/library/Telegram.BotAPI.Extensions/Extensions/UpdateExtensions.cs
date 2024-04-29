// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Reflection;
using System.Text.Json.Serialization;
using Telegram.BotAPI.GettingUpdates;

namespace Telegram.BotAPI.Extensions;

/// <summary>
/// Extensions for <see cref="Update"/> class.
/// </summary>
public static class UpdateExtensions
{
    /// <summary>
    /// Retrieves the type of the update by examining the properties of the <see cref="Update"/> object.
    /// </summary>
    /// <param name="update">The instance of <see cref="Update"/> whose type is to be determined.</param>
    /// <returns>The JSON property name of the first non-null property in the <see cref="Update"/> instance, excluding the UpdateId property. This is used to determine the type of the update.</returns>
    /// <exception cref="ArgumentNullException">Thrown when the provided <see cref="Update"/> instance is null.</exception>
    /// <exception cref="InvalidOperationException">Thrown when the <see cref="Update"/> instance does not have any valid properties.</exception>

    public static string GetUpdateType(this Update update)
    {
        if (update is null)
        {
            throw new ArgumentNullException(nameof(update));
        }

        // Get all properties of the Update class where the value is not null.
        var properties = typeof(Update).GetProperties(BindingFlags.Public | BindingFlags.Instance).Where(p => p.GetValue(update) != null);
        // Get the json name of the first property ignoring UpdateId.
        var property = properties.FirstOrDefault(p => p.Name != nameof(Update.UpdateId)) ?? throw new InvalidOperationException("The update is not valid.");

        return property.GetCustomAttribute<JsonPropertyNameAttribute>()!.Name;
    }
}