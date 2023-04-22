# Telegram.BotAPI

[![Compatible with Bot API v6.7](https://img.shields.io/badge/Bot%20API%20version-v6.7-blue?style=flat-square)](https://core.telegram.org/bots/api#april-21-2023)

**Telegram.BotAPI** is one of the most complete libraries available to interact with the Telegram Bot API in your .NET projects. Free and open source.

It contains all the methods and types available in the Bot API 6.7 released on April 21, 2023.

---

## Features

- Contains pre-defined methods for all Bot API 6.7 methods.
- Contains classes for each object type used in the Bot API 6.7.
- Sync and async methods.
- Support [System.Text.Json](https://www.nuget.org/packages/System.Text.Json/) and [Newtonsoft.Json](https://www.nuget.org/packages/Newtonsoft.Json/).

---

## How to use

First, get your **bot token** from [BotFather](https://t.me/BotFather) and use it to create a new instance of `Telegram.BotAPI.BotClient` as follows.

```CSharp
using Telegram.BotAPI;

var botToken = "bot123456:ABC-DEF1234ghIkl-zyx57W2v1u123ew11";
// You need a BotClient instance if you want access to the Bot API methods.
var api = new BotClient(botToken);
```

The methods and types are organized in namespaces according to their corresponding section on the [Official Bot API website](https://core.telegram.org/bots/api). So if you want to use a method or type, you must first include the corresponding namespace.

Currently the following namespaces are available:

| Name                             | Description                                      |
| :------------------------------- | :----------------------------------------------- |
| Telegram.BotAPI                  | Contains the BotClient and other utilities       |
| Telegram.BotAPI.GettingUpdates   | Contains methods and types for getting updates   |
| Telegram.BotAPI.AvailableTypes   | Contains available types                         |
| Telegram.BotAPI.AvailableMethods | Contains available methods                       |
| Telegram.BotAPI.UpdatingMessages | Contains methods and types for updating messages |
| Telegram.BotAPI.Stickers         | Contains methods and types for stickers          |
| Telegram.BotAPI.InlineMode       | Contains methods and types for inline mode       |
| Telegram.BotAPI.Payments         | Contains methods and types for payments          |
| Telegram.BotAPI.TelegramPassport | Contains methods and types for Telegram Passport |
| Telegram.BotAPI.Games            | Contains methods and types for games             |

Once the namespaces are included, you are ready to start managing your bot. For example, you can use the [getMe](https://core.telegram.org/bots/api#sendmessage) method to get basic information about your bot.

```CSharp
using Telegram.BotAPI.AvailableMethods;

var me = api.GetMe();
Console.WriteLine("My name is {0}.", me.FirstName);
```

## Getting updates

Every time a user interacts with a bot, bot will receive a new update. Updates contain information about user events, such as a new message or when a button is clicked. If you want your bot to reply to a message, then your bot must be able to get updates first.

Currently, there are two ways to get updates: [Long Polling](###Long-Polling) and [webhooks](###Webhooks).

### Long Polling

To get updates using **Long Polling**, you must create a perpetual loop and check for updates using the getUpdates method. After all updates have been processed, you must mark them as read by setting the offset parameter to a value greater than the id of the last update. See the follow example:

```CSharp
using System.Linq;
using Telegram.BotAPI.GettingUpdates;

var updates = api.GetUpdates();
while (true)
{
    if (updates.Any())
    {
        foreach (var update in updates)
        {
            // Process update
        }
        var offset = updates.Last().UpdateId + 1;
        updates = api.GetUpdates(offset);
    }
    else
    {
        updates = api.GetUpdates();
    }
}
```

### Webhooks

To receive updates through webhook, you must create a web application. In your ASP NET application, create a new api controller for your bot and define a function to receive the update as shown below.

```CSharp
using Telegram.BotAPI.GettingUpdates;

[HttpPost]
public IActionResult Post([FromBody] Update update)
{
    if (update == null)
    {
        return BadRequest();
    }
    // Process your update
    return Ok();
}
```

At the beginning of your application, you need to register your webhook using the API. In this way, Telegram will send new updates to your API controller. See the example below:

```CSharp
api.DeleteWebhook(true); // Delete old webhook
api.SetWebhook("https://example.com/<controller path>"); // Set new webhook
```

> It's high recommended to use a secret path to access the api controller.

> Using webhook will disable the `getUpdates` method. Use `deleteWebhook` to enable it again.

## Sending messages

Sending messages is the simplest and most important task of a bot. See the following example for sending text messages.

```CSharp
using Telegram.BotAPI.AvailableMethods;

long chatId = update.Message.Chat.Id; // Target chat Id
api.SendMessage(chatId, "Hello World!"); // Send a message
```

Your bot can also send multimedia messages like photos, gifs, videos, and others. See [Available methods](https://core.telegram.org/bots/api#available-methods) for learn more.

## Uploading files

You can send attached files using InputFile objects. You have two ways to do it.

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
var files = new AttachedFile[]
{
    new AttachedFile("file56", file)
}
// Upload document
api.SendDocument(chatId, "attach://file56", attachedFiles: files);
```

---

## Examples

You can see more examples [here](https://github.com/Eptagone/Telegram.BotAPI/tree/main/src/Telegram.BotAPI.Examples).

## License

[MIT](https://github.com/Eptagone/Telegram.BotAPI/blob/main/LICENSE)

## Release notes

[See release notes](https://github.com/Eptagone/Telegram.BotAPI/releases)
