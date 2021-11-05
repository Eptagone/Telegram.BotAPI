// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

namespace Telegram.BotAPI.AvailableMethods.FormattingOptions
{
    /// <summary><b>Formatting options</b><br/>
    /// <para>The Bot API supports basic formatting for messages. You can use bold, italic, underlined and strikethrough text, as well as inline links and pre-formatted code in your bots' messages. Telegram clients will render them accordingly. You can use either markdown-style or HTML-style formatting.</para>
    /// <para>Note that Telegram clients will display an alert to the user before opening an inline link (‘Open this link?’ together with the full URL).</para>
    /// <para>Message entities can be nested, providing following restrictions are met: <br/>
    /// - If two entities has common characters then one of them is fully contained inside another.<br/>
    /// - bold, italic, underline and strikethrough entities can contain and to be contained in any other entities, except pre and code.<br/>
    /// - All other entities can't contain each other.</para>
    /// <para>
    /// Links tg://user?id=&lt;user_id&gt; can be used to mention a user by their ID without using a username. Please note:<br/>
    /// • These links will work <b>only</b> if they are used inside an inline link. For example, they will not work, when used in an inline keyboard button or in a message text.<br/>
    /// • These mentions are only guaranteed to work if the user has contacted the bot in the past, has sent a callback query to the bot via inline button or is a member in the group where he was mentioned.
    /// </para></summary>
    public static class ParseMode
    {
        /// <summary>To use this mode, pass Markdown in the parse_mode field. Use the following syntax in your message:
        /// <para>*bold text*<br/>
        /// _italic text_<br/>
        /// [inline URL](http://www.example.com/)<br/>
        /// [inline mention of a user] (tg://user?id=123456789)<br/>
        /// `inline fixed-width code`<br/>
        /// ```<br/>
        /// pre - formatted fixed-width code block<br/>
        /// ```<br/>
        /// ```python<br/>
        /// pre - formatted fixed-width code block written in the Python programming language<br/>
        /// ```</para>
        /// <para>Please note.</para>
        /// <para>
        /// • Entities must not be nested, use parse mode MarkdownV2 instead.<br/>
        /// • There is no way to specify underline and strikethrough entities, use parse mode MarkdownV2 instead.<br/>
        /// • To escape characters '_‘, ’*‘, ’`‘, ’[‘ outside of an entity, prepend the characters ’\' before them.<br/>
        /// • Escaping inside entities is not allowed, so entity must be closed first and reopened again: use <i>_snake_\__case_</i> for italic <i>snake_case</i> and <i>*2*\**2=4*</i> for bold <i>2*2=4</i>.</para>
        /// </summary>
        public const string Markdown = "Markdown";
        /// <summary>To use this mode, pass MarkdownV2 in the parse_mode field. Use the following syntax in your message:
        /// <para>*bold \*text*<br/>
        /// _italic \*text_<br/>
        /// __underline__<br/>
        /// ~strikethrough~<br/>
        /// *bold _italic bold ~italic bold strikethrough~__underline italic bold___ bold*<br/>
        /// [inline URL] (http://www.example.com/)<br/>
        /// [inline mention of a user] (tg://user?id=123456789)<br/>
        /// `inline fixed-width code`<br/>
        /// ```<br/>
        /// pre - formatted fixed-width code block<br/>
        /// ```<br/>
        /// ```python<br/>
        /// pre - formatted fixed-width code block written in the Python programming language<br/>
        /// </para>
        /// <para>Please note:</para>
        /// <para>• Any character between 1 and 126 inclusively can be escaped anywhere with a preceding '\' character, in which case it is treated as an ordinary character and not a part of the markup.<br/>
        /// • Inside pre and code entities, all '`‘ and ’\‘ characters must be escaped with a preceding ’\' character.<br/>
        /// • Inside(...) part of inline link definition, all ')‘ and ’\‘ must be escaped with a preceding ’\' character.<br/>
        /// • In all other places characters '_‘, ’*‘, ’[‘, ’]‘, ’(‘, ’)‘, ’~‘, ’`‘, ’>‘, ’#‘, ’+‘, ’-‘, ’=‘, ’|‘, ’{‘, ’}‘, ’.‘, ’!‘ must be escaped with the preceding character ’\'.<br/>
        /// • In case of ambiguity between italic and underline entities ‘__’ is always greadily treated from left to right as beginning or end of underline entity, so instead of ___italic underline___ use ___italic underline_\r__, where \r is a character with code 13, which will be ignored.</para>
        /// </summary>
        public const string MarkdownV2 = "MarkdownV2";
        /// <summary>To use this mode, pass HTML in the parse_mode field. The following tags are currently supported:
        /// <para>&lt;b&gt;bold&lt;/b&gt;, &lt;strong&gt;bold&lt;/strong&gt;<br/>
        /// &lt;i&gt;italic&lt;/i&gt;, &lt;em&gt;italic&lt;/em&gt;<br/>
        /// &lt;u&gt;underline&lt;/u&gt;, &lt;ins&gt;underline&lt;/ins&gt;<br/>
        /// &lt;s&gt;strikethrough&lt;/s&gt;, &lt;strike&gt;strikethrough&lt;/strike&gt;, &lt;del&gt;strikethrough&lt;/del&gt;<br/>
        /// &lt;b&gt;bold&lt;i&gt; italic bold&lt;s&gt; italic bold strikethrough&lt;/s&gt; &lt;u&gt;underline italic bold&lt;/u&gt;&lt;/i&gt; bold&lt;/b&gt;<br/>
        /// &lt;a href = "http://www.example.com/" &gt; inline URL&lt;/a&gt;<br/>
        /// &lt;a href = "tg://user?id=123456789" &gt; inline mention of a user&lt;/a&gt;<br/>
        /// &lt;code&gt;inline fixed-width code &lt;/ code &gt;<br/>
        /// &lt; pre &gt; pre - formatted fixed-width code block &lt;/pre &gt;<br/>
        /// &lt; pre &gt;&lt; code class="language-python"&gt;pre-formatted fixed-width code block written in the Python programming language &lt;/code &gt;&lt;/pre &gt;
        /// </para>
        /// <para>Please note:</para>
        /// <para>Only the tags mentioned above are currently supported. <br/>
        /// • All&lt;,&gt; and &amp; symbols that are not a part of a tag or an HTML entity must be replaced with the corresponding HTML entities (&lt; with &amp;lt;, &gt; with &amp;gt; and &amp; with &amp;amp;). <br/>
        /// • All numerical HTML entities are supported. <br/>
        /// • The API currently supports only the following named HTML entities: &amp;lt;, &amp;gt;, &amp;amp; and &amp;quot;.<br/>
        /// • Use nested <i>pre</i> and <i>code</i> tags, to define programming language for <i>pre</i> entity. <br/>
        /// • Programming language can't be specified for standalone <i>code</i> tags.</para></summary>
        public const string HTML = "HTML";
    }
}
