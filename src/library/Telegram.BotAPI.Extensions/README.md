# Telegram.BotAPI.Extensions

This library provides a set of extensions and utilities for the [Telegram.BotAPI](https://github.com/Eptagone/Telegram.BotAPI) library.

## Features

- Base classes to create telegram bots
  - SimpleUpdateHandlerBase: An abstract class prepared to handle updates and dispatch it to the right method. It defines virtual methods for each type of update, including commands and errors.
  - TelegramBotCommandAttribute: An attribute to mark methods as bot commands.
  - BotCommandExtractor: A class to extract commands from a message text using regular expressions.
  - HtmlTextFormatter: A class to format text using HTML tags.
  - InlineKeyboardBuilder: A class to build inline keyboards.
  - ReplyKeyboardBuilder: A class to build reply keyboards.
- Extensions
  - UpdateExtensions: A set of extension methods for Update objects.
    - BuildFileDownloadLink: An extension method to build a download link for a file.

## Installation

### Install from the command line

```PowerShell
dotnet add PROJECT package Telegram.BotAPI.Extensions
```

[Get package from Nuget Web Site](https://www.nuget.org/packages/Telegram.BotAPI.Extensions/)
