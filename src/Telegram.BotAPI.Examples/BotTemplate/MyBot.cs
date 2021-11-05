using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Telegram.BotAPI;
using Telegram.BotAPI.AvailableMethods;
using Telegram.BotAPI.AvailableTypes;
using Telegram.BotAPI.GettingUpdates;
using Telegram.BotAPI.InlineMode;
using Telegram.BotAPI.Payments;

namespace BotTemplateSample
{
    public sealed class MyBot : TelegramBot
    {
        public static BotClient Bot = new BotClient("<your bot token>");
        public static User Me = Bot.GetMe();
        public static void StartPolling()
        {
            Bot.DeleteWebhook();
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

        protected override void OnMessage(Message message)
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

        protected override void OnBotException(BotRequestException exp)
        {
            Console.WriteLine("New BotException: {0}", exp.Message);
            Console.WriteLine("Error Code: {0}", exp.ErrorCode);
            Console.WriteLine();
        }

        protected override void OnException(Exception exp)
        {
            Console.WriteLine("New Exception: {0}", exp.Message);
            Console.WriteLine();
        }

        protected override void OnCallbackQuery(CallbackQuery callbackQuery)
        {

        }

        protected override void OnChannelPost(Message message)
        {

        }

        protected override void OnChosenInlineResult(ChosenInlineResult chosenInlineResult)
        {

        }

        protected override void OnEditedChannelPost(Message message)
        {

        }

        protected override void OnEditedMessage(Message message)
        {

        }

        protected override void OnInlineQuery(InlineQuery inlineQuery)
        {

        }

        protected override void OnPoll(Poll poll)
        {

        }

        protected override void OnPollAnswer(PollAnswer pollAnswer)
        {

        }

        protected override void OnPreCheckoutQuery(PreCheckoutQuery preCheckoutQuery)
        {

        }

        protected override void OnShippingQuery(ShippingQuery shippingQuery)
        {

        }

        protected override void OnMyChatMember(ChatMemberUpdated myChatMemberUpdated)
        {

        }

        protected override void OnChatMember(ChatMemberUpdated chatMemberUpdated)
        {

        }
    }
}
