# Telegram.BotAPI NET Documentation

[![NuGet version (Telegram.BotAPI)](https://img.shields.io/nuget/v/Telegram.BotAPI.svg?style=flat-square)](https://www.nuget.org/packages/Telegram.BotAPI/)
[![Compatible with Bot API v5.2](https://img.shields.io/badge/Bot%20API%20version-v5.2-blue?style=flat-square)](https://core.telegram.org/bots/api#april-26-2021)

## Getting started

To get started you just need to start a new BotClient as follows.

```CSharp
var MyBot = new BotClient(YourAccessTokenString);
```

By adding the respective namespaces you will be able to use the extension methods for the instance you just created. For example, if you want to use the "GetChat" method you should include the namespace "Telegram.BotAPI.AvailableMethods" to use method as follows.

```CSharp
using Telegram.BotAPI.AvailableMethods; //Contains methods
```

```CSharp
var result = MyBot.GetChat(chatId); //returns a Chat object available in "Telegram.BotAPI.AvailableTypes"
```

In the event of any error in any request, a BotRequestException will be thrown, which will include an object with the error information.

## Namespaces

All methods and object types used in the Telegram Bot API are separated into namespaces, with the same names of the sections in which they are organized on the official Telegram Bot API website. The available namespaces are shown below.

| Name                             | Description                                      |
| :------------------------------- | :----------------------------------------------- |
| Telegram.BotAPI                  | Contains the BotClient and other base utilities  |
| Telegram.BotAPI.GettingUpdates   | Contains methods and types for getting updates   |
| Telegram.BotAPI.AvailableTypes   | Contains available types                         |
| Telegram.BotAPI.AvailableMethods | Contains available methods                       |
| Telegram.BotAPI.UpdatingMessages | Contains methods and types for updating messages |
| Telegram.BotAPI.Stickers         | Contains methods and types for stickers          |
| Telegram.BotAPI.InlineMode       | Contains methods and types for inline mode       |
| Telegram.BotAPI.Payments         | Contains methods and types for payments          |
| Telegram.BotAPI.TelegramPassport | Contains methods and types for Telegram Passport  |
| Telegram.BotAPI.Games            | Contains methods and types for games             |

For more detail of what each method does and the properties of each type, it is recommended to consult on the official website of the [Telegram Bot API](https://core.telegram.org/bots/api) while using the library.

## Examples

- [Send Messages](###Send-Messages)
- [Upload files](###Upload-files)
- [Asynchronous methods](###Asynchronous-methods)

### Send Messages

Sending messages examples

#### Send message text

```CSharp
using Telegram.BotAPI;
using Telegram.BotAPI.AvailableMethods

var bot = new BotClient(token);
bot.SendMessage(chatId, "Message Text");
```

#### Send message photo

```CSharp
using Telegram.BotAPI.AvailableMethods

var bot = new BotClient(token);
bot.SendPhoto(new SendPhotoArgs
    {
        ChatId = chatId,
        Photo = photoid
    });
```

### Upload files

Depending on the method used. You can send attach files in two ways.

The first way is to pass an inputfile object in the respective field. The second way is to add AttachFile objects in the AttachFiles field and pass "attach://\<attachfilename\>" in all the file fields you require.

#### Option 1

```CSharp
using Telegram.BotAPI;
using Telegram.BotAPI.AvailableTypes;
using Telegram.BotAPI.AvailableMethods

var bot = new BotClient(token);
bot.SendDocument(
    new SendDocumentArgs
    {
        ChatId = chatId,
        Document = new InputFile(filebytes, "file.zip")
    }); //upload document
```

#### Option 2

```CSharp
using Telegram.BotAPI;
using Telegram.BotAPI.AvailableTypes;
using Telegram.BotAPI.AvailableMethods

var bot = new BotClient(token);
bot.SendDocument(
    new SendDocumentArgs
    {
        ChatId = chatId,
        Document = "attach://file56",
        AttachFiles = new AttachFile[]
        {
            new AttachFile("file56",
                new InputFile(filebytes, "file.zip"))
        }
    }); //upload document
```

### Asynchronous methods

All available methods have an alternative asynchronous method. These methods have the same name but with Async termination. The way you pass parameters is exactly the same as normal methods.

For example, sending a text message asynchronously would be something like this:

```CSharp
using Telegram.BotAPI;
using Telegram.BotAPI.AvailableMethods

var bot = new BotClient(token);
await bot.SendMessageAsync(chatId, "Message Text").ConfigureAwait(false);
```

## Samples

[See samples](../src/Telegram.BotAPI.Examples/readme.md)
