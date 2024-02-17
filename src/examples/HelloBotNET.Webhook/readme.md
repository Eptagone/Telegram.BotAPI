# HelloBotNET

This is a Hello World telegram bot made with NET 6 using a webhook.

## How to Run

If you want to run this bot you need to specify your **bot token**, the **application url** and a **secret token** in the `HelloBotNET.Webhook` project. Optionally, you can specify the **certificate** path to use with your webhook.

Your `secrets.json` or `appsettings.json` should look like the following code:

```JSON
{
  //"Certificate": "/etc/ssl/certs/custom_cert.pem",
  "Telegram": {
    "BotToken": "123456:ABC-DEF1234ghIkl-zyx57W2v1u123ew11",
    "WebhookUrl": "https://www.example.com",
    "WebhookToken": "SUPERSECRETPATH"
  }
}
```

You can also use enviroment variables instead:

| Env                               | Description                                                      |
| :-------------------------------- | :--------------------------------------------------------------- |
| Certificate                       | Optional. Certificate Path.                                      |
| Telegram__BotToken                | Your bot token provided by [@BotFather](https://t.me/BotFather). |
| Telegram__WebhookUrl              | Your application url. Ex: <https://example.com>                  |
| Telegram__WebhookToken            | Your secret token. It must be specified by yourself.             |

Finally, run `HelloBotNET.Webhook` and see the magic.
