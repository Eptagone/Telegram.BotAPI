# HelloBotNET

This is a Hello World telegram bot made with NET 6 using Long Polling.

## How to Run

You just need to specify your **bot token** in the `HelloBotNET.AppService` project.

Your `secrets.json` or `appsettings.json` should look like the following code:

```JSON
{
"Telegram": {
    "BotToken": "123456:ABC-DEF1234ghIkl-zyx57W2v1u123ew11"
  }
}
```

You can also use enviroment variables instead:

| Env                               | Description                                                      |
| :-------------------------------- | :--------------------------------------------------------------- |
| Telegram__BotToken                | Your bot token provided by [@BotFather](https://t.me/BotFather). |

Finally, run `HelloBotNET.AppService` and see the magic.
