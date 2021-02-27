using System;
using Telegram.BotAPI.AvailableMethods;
using Telegram.BotAPI.AvailableTypes;

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
}
