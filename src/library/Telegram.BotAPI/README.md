# Telegram.BotAPI

[![Compatible with Bot API v7.9](https://img.shields.io/badge/Bot%20API%20version-v7.9-blue?style=flat-square)](https://core.telegram.org/bots/api#august-14-2024)

**Telegram.BotAPI** is one of the most complete libraries available to interact with the Telegram Bot API in your .NET projects. Free and open source.

It contains all the methods and types available in the Bot API 7.9 released on August 14, 2024.

---

## Features

- Contains pre-defined methods for all Bot API 7.9 methods.
- Contains classes for each object type used in the Bot API 7.9.
- Sync and async methods.
- Uses [System.Text.Json](https://www.nuget.org/packages/System.Text.Json/).

---

## How to use

First, get your **bot token** from [BotFather](https://t.me/BotFather) and use it to create a new instance of `Telegram.BotAPI.TelegramBotClient` as follows.

```CSharp
using Telegram.BotAPI;

var botToken = "bot123456:ABC-DEF1234ghIkl-zyx57W2v1u123ew11";
// You need a TelegramBotClient instance if you want access to the Bot API methods.
var client = new TelegramBotClient(botToken);
```

The methods and types are organized in namespaces according to their corresponding section on the [Official Bot API website](https://core.telegram.org/bots/api). So if you want to use a method or type, you must first include the corresponding namespace.

Currently the following namespaces are available:

| Name                             | Description                                      |
| :------------------------------- | :----------------------------------------------- |
| Telegram.BotAPI                  | Contains the TelegramBotClient and other utilities       |
| Telegram.BotAPI.GettingUpdates   | Contains methods and types for getting updates   |
| Telegram.BotAPI.AvailableTypes   | Contains available types                         |
| Telegram.BotAPI.AvailableMethods | Contains available methods                       |
| Telegram.BotAPI.UpdatingMessages | Contains methods and types for updating messages |
| Telegram.BotAPI.Stickers         | Contains methods and types for stickers          |
| Telegram.BotAPI.InlineMode       | Contains methods and types for inline mode       |
| Telegram.BotAPI.Payments         | Contains methods and types for payments          |
| Telegram.BotAPI.TelegramPassport | Contains methods and types for Telegram Passport |
| Telegram.BotAPI.Games            | Contains methods and types for games             |

Once the namespaces are included, you are ready to start managing your bot. For example, you can use the [getMe](https://core.telegram.org/bots/api#getme) method to get basic information about your bot.

```CSharp
using Telegram.BotAPI.AvailableMethods;

var me = client.GetMe();
Console.WriteLine("My name is {0}.", me.FirstName);
```

## Getting updates

Every time a user interacts with a bot, bot will receive a new update. Updates contain information about user events, such as a new message or when a button is clicked. If you want your bot to reply to a message, then your bot must be able to get updates first.

Currently, there are two ways to get updates: [Long Polling](#long-polling) and [webhooks](#webhooks).

### Long Polling

To get updates using **Long Polling**, you must create a perpetual loop and check for updates using the getUpdates method. After all updates have been processed, you must mark them as read by setting the offset parameter to a value greater than the id of the last update. See the follow example:

```CSharp
using System.Linq;
using Telegram.BotAPI.GettingUpdates;

var updates = client.GetUpdates();
while (true)
{
    if (updates.Any())
    {
        foreach (var update in updates)
        {
            // Process update
        }
        var offset = updates.Last().UpdateId + 1;
        updates = client.GetUpdates(offset);
    }
    else
    {
        updates = client.GetUpdates();
    }
}
```

### Webhooks

To receive updates through webhook, you must create a web application. In your ASP NET application, create a new api controller for your bot and define a function to receive the update as shown below.

```CSharp
using Telegram.BotAPI.GettingUpdates;

[HttpPost]
public IActionResult Post(
    // The secret token is optional, but it's highly recommended to use it.
    [FromHeader(Name = "X-Telegram-Bot-Api-Secret-Token")] string secretToken,
    [FromBody] Update update)
{
    if (update is null)
    {
        return BadRequest();
    }
    // Check if the secret token is valid
    // Process your update
    return Ok();
}
```

At the beginning of your application, you need to register your webhook using the API. In this way, Telegram will send new updates to your API controller. See the example below:

```CSharp
api.DeleteWebhook(true); // Delete old webhook
api.SetWebhook("https://example.com/<controller path>"); // Set new webhook
```

> It's high recommended to configurate a secret token to access the api controller through the setWebhook method. This will prevent third parties from accessing your api controller.
> Using a webhook will disable the `getUpdates` method. Use `deleteWebhook` to enable it again.

## Sending messages

Sending messages is the simplest and most important task of a bot. See the following example for sending text messages.

```CSharp
using Telegram.BotAPI.AvailableMethods;

long chatId = update.Message.Chat.Id; // Target chat Id
api.SendMessage(chatId, "Hello World!"); // Send a message
```

Your bot can also send multimedia messages like photos, gifs, videos, and others. See [Available methods](https://core.telegram.org/bots/api#available-methods) for learn more.

## Uploading files

You can also send attached files using InputFile objects. You have two ways to do it: By using an InputFile object directly or by using a dictionary of InputFile objects.

### Option 1

```CSharp
using Telegram.BotAPI;
using Telegram.BotAPI.AvailableTypes;
using Telegram.BotAPI.AvailableMethods;

var file = new InputFile(filebytes, "file.zip");
// Upload document
api.SendDocument(chatId, file);
```

### Option 2

```CSharp
using Telegram.BotAPI;
using Telegram.BotAPI.AvailableTypes;
using Telegram.BotAPI.AvailableMethods;

var file = new InputFile(filebytes, "file.zip");
var files = new Dictionary<string, InputFile>() {
    { "file56", file }
};
// Upload document
api.SendDocument(chatId, "attach://file56", files: files);
```

## Making custom requests

The library already includes all types and methods available in the Bot API. However, if you want to use your own types or if you want to be the first one to use new features when they are released, you can use the `CallMethod` and/or `CallMethodDirect` methods defined in the ITelegramBotClient instance.

```CSharp
var args = new Dictionary<string, object>() {
    { "chat_id", 123456789 },
    { "text", "Hello World!" }
};
// Message is the type you want to use to deserialize the response result. It can be an in-built type or a custom type created by you.
var message = client.CallMethod<Message>("sendMessage", args);
```

The previous method is used by all extension methods defined in the library. You can also create your own extension methods to make custom requests if you want.

```CSharp
public static class TelegramBotClientExtensions
{
    public static Message SendHelloWorld(this ITelegramBotClient client, long chatId)
    {
        var args = new Dictionary<string, object>() {
            { "chat_id", chatId },
            { "text", "Hello World!" }
        };
        return client.CallMethod<Message>("sendMessage", args);
    }
}
```

The library also includes the classes `MethodNames` and `PropertyNames` that contain the names of all methods and properties.

The `CallMethod` will trigger an exception if the response status code is not OK. If you don't like this behavior, you can use the `CallMethodDirect` method instead.

```CSharp
var args = new Dictionary<string, object>() {
    { "chat_id", 123456789 },
    { "text", "Hello World!" }
};
// BotResponse<Message>
var response = client.CallMethodDirect<Message>("sendMessage", args);
```

You'll get a `BotResponse<T>` object as a response. This object contains the status code, the deserialized result or null (if error), the error description and also some error parameters if available.

---

## Examples

You can see more examples [here](https://github.com/Eptagone/Telegram.BotAPI/tree/main/src/Telegram.BotAPI.Examples).

## License

[MIT](https://github.com/Eptagone/Telegram.BotAPI/blob/main/LICENSE)

## Release notes

[See release notes](https://github.com/Eptagone/Telegram.BotAPI/releases)
