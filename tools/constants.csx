#nullable enable

public static class ScriptConstants
{
    public const string PROJECT_NAME = "Telegram.BotAPI";
    public const string TELEGRAM_CORE_WEBSITE_URL = "https://core.telegram.org";
    public const string TELEGRAM_BOT_API_DOCS_URL = "https://core.telegram.org/bots/api";
    public const string INPUT_FILE_TYPE_NAME = "InputFile";
    public const string TEMPLATE_RESULT_TYPE_NAME = "TResult";
    public static string DEFAULT_OUTPUT_PATH = Path.Combine(
        Directory.GetCurrentDirectory(),
        "publish"
    );
}
