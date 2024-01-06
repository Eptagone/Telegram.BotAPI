# Bot Templace - Sample

## Description
.NET Core console app

The bot sends "Hello World!" when it receives a message using TelegramBot base class.

## Preview
![hello world gif](/docs/media/samples/BotTemplate.gif)

## Source Code
```CSharp
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using Telegram.BotAPI;
using Telegram.BotAPI.GettingUpdates;
using Telegram.BotAPI.AvailableMethods;
using Telegram.BotAPI.AvailableTypes;
using Telegram.BotAPI.InlineMode;
using Telegram.BotAPI.Payments;

namespace BotTemplateSample
{
    class Program
    {

        static void Main()
        {
            Console.WriteLine("Start!");
            MyBot.Bot.SetMyCommands(new BotCommand("hello", "Hello World!!"));
            MyBot.StartPolling();
            Console.Read();
        }
    }
    public sealed class MyBot : TelegramBot
    {
        public static TelegramBotClient Bot = new TelegramBotClient("<your bot token>");
        public static User Me = Bot.GetMe();
        public static void StartPolling()
        {
            var updates = Bot.GetUpdates<IEnumerable<Update>>();
            while (true)
            {
                if (updates.Any())
                {
                    foreach (var update in updates)
                    {
                        var botInstance = new MyBot();
                        botInstance.OnUpdate(update);
                    }
                    var offset = updates.Last().UpdateId + 1;
                    updates = Bot.GetUpdates<IEnumerable<Update>>(offset);
                }
                else
                {
                    updates = Bot.GetUpdates<IEnumerable<Update>>();
                }
            }
        }

        //
        private Message message;
        private bool hasText;
        private User appUser;

        public override void OnMessage(Message message)
        {
            // Ignore user 777000 (Telegram)
            if (message.From.Id == 777000)
            {
                return;
            }
            Console.WriteLine("New message from chat id: {0}", message.Chat.Id);

            appUser = message.From; // Save current user;
            this.message = message; // Save current message;
            hasText = !string.IsNullOrEmpty(message.Text); // True if message has text;

            Console.WriteLine("Message Text: {0}", hasText ? message.Text : "|:O");

            if (message.Chat.Type == ChatType.Private) // Private Chats
            {
            }
            else // Group chats
            {

            }
            if (hasText)
            {
                if (message.Text.StartsWith('/')) // New commands
                {
                    var splitText = message.Text.Split(' ');
                    var command = splitText.First();
                    var parameters = splitText.Skip(1).ToArray();
                    // If the command includes a mention, you should verify that it is for your bot, otherwise you will need to ignore the command.
                    var pattern = string.Format(@"^\/(?<cmd>\w*)(?:$|@{0}$)", Me.Username);
                    var match = Regex.Match(command, pattern, RegexOptions.IgnoreCase);
                    if (match.Success)
                    {
                        command = match.Groups.Values.Last().Value; // Get command name
                        Console.WriteLine("New command: {0}", command);
                        OnCommand(command, parameters);
                    }
                }
            }
        }

        private void OnCommand(string cmd, string[] args)
        {
            Console.WriteLine("Params: {0}", args.Length);
            switch (cmd)
            {
                case "hello":
                    var hello = string.Format("Hello World, {0}!", appUser.FirstName);
                    Bot.SendMessage(message.Chat.Id, hello);
                    break;
            }
        }

        public override void OnBotException(BotRequestException exp)
        {
            Console.WriteLine("New BotException: {0}", exp.Message);
            Console.WriteLine("Error Code: {0}", exp.ErrorCode);
            Console.WriteLine();
        }

        public override void OnException(Exception exp)
        {
            Console.WriteLine("New Exception: {0}", exp.Message);
            Console.WriteLine();
        }
    }
}
```
