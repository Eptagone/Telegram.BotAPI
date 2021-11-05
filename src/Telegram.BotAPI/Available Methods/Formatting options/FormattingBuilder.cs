// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.AvailableMethods.FormattingOptions
{
    /// <summary>This class contains a set of useful methods for formatting the text of messages.</summary>
    public class FormattingBuilder
    {
        /// <summary>StyleFixer</summary>
        protected StyleFixer StyleFixer => _styleFixer;
        private readonly StyleFixer _styleFixer;
        /// <summary>Initialize a new instance of StyleParser.</summary>
        public FormattingBuilder()
        {
            _styleFixer = StyleFixer.Default;
        }
        /// <summary>Initialize a new instance of StyleParser.</summary>
        /// <param name="styleFixer">Custom StyleFixer.</param>
        public FormattingBuilder(StyleFixer styleFixer)
        {
            _styleFixer = styleFixer ?? StyleFixer.Default;
        }
        /// <summary>Create new stylized text from message entities.</summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="input">Input text.</param>
        /// <param name="parseMode">Style to be applied to the new text.</param>
        /// <param name="entities">Message entities.</param>
        /// <param name="useFixer">True, if you want to use the StyleFixer.</param>
        /// <returns>Stylized <see cref="string"/></returns>
        public virtual string FromEntities<T>(string input, ParseModeKind parseMode, T entities, bool useFixer = true)
            where T : IEnumerable<MessageEntity>
        {
            if (string.IsNullOrEmpty(input))
            {
                throw new ArgumentNullException(nameof(input));
            }
            if (entities == null)
            {
                throw new ArgumentNullException(nameof(input));
            }
            if (entities.Any())
            {
                var buffer = new StringBuilder();
                var offset = 0;
                string nFsubText;
                string subText;
                foreach (var e in entities)
                {
                    if (offset < e.Offset)
                    {
                        nFsubText = input.Substring(offset, e.Offset - offset);
                        subText = useFixer ? _styleFixer.FixTo(nFsubText, parseMode) : nFsubText;
                        buffer.Append(subText);
                        offset = e.Offset;
                    }
                    subText = input.Substring(offset, e.Length);
                    switch (e.GetEntityType())
                    {
                        case MessageEntityType.Bold:
                            buffer.Append(Bold(subText, parseMode, true));
                            break;
                        case MessageEntityType.Italic:
                            buffer.Append(Italic(subText, parseMode, true));
                            break;
                        case MessageEntityType.Underline:
                            buffer.Append(Underline(subText, parseMode, true));
                            break;
                        case MessageEntityType.Strikethrough:
                            buffer.Append(Strikethrough(subText, parseMode, true));
                            break;
                        case MessageEntityType.Code:
                            buffer.Append(Code(subText, parseMode, true));
                            break;
                        case MessageEntityType.Pre:
                            buffer.Append(Pre(subText, parseMode));
                            break;
                        case MessageEntityType.TextLink:
                            buffer.Append(TextLink(subText, e.Url, parseMode, true));
                            break;
                        case MessageEntityType.TextMention:
                            buffer.Append(TextMention(subText, e.User.Id, parseMode, true));
                            break;
                        default:
                            if (useFixer)
                            {
                                subText = _styleFixer.FixTo(subText, parseMode);
                            }
                            buffer.Append(subText);
                            break;
                    }
                    offset += e.Length;
                }
                if (offset < input.Length)
                {
                    nFsubText = input.Substring(offset, input.Length - offset);
                    subText = useFixer ? _styleFixer.FixTo(nFsubText, parseMode) : nFsubText;
                    buffer.Append(subText);
                }
                return buffer.ToString();
            }
            else
            {
                return useFixer ? _styleFixer.FixTo(input, parseMode) : input;
            }
        }
        /// <summary> Format text. Bold. </summary>
        /// <param name="input">Input text.</param>
        /// <param name="parseMode">Style to be applied to the new text.</param>
        /// <param name="useFixer">True, if you want to use the StyleFixer.</param>
        /// <returns>Stylized <see cref="string"/></returns>
        public virtual string Bold(string input, ParseModeKind parseMode = ParseModeKind.Markdown, bool useFixer = true)
        {
            if (string.IsNullOrEmpty(input))
            {
                throw new ArgumentNullException(nameof(input));
            }
            string text = useFixer ? _styleFixer.FixTo(input, parseMode) : input;
            return parseMode switch
            {
                ParseModeKind.Markdown => $"*{text}*",
                ParseModeKind.MarkdownV2 => $"*{text}*",
                ParseModeKind.HTML => $"<b>{text}</b>",
                _ => text,
            };
        }
        /// <summary> Format text. Italic. </summary>
        /// <param name="input">Input text.</param>
        /// <param name="parseMode">Style to be applied to the new text.</param>
        /// <param name="useFixer">True, if you want to use the StyleFixer.</param>
        /// <returns>Stylized <see cref="string"/></returns>
        public virtual string Italic(string input, ParseModeKind parseMode = ParseModeKind.Markdown, bool useFixer = true)
        {
            if (string.IsNullOrEmpty(input))
            {
                throw new ArgumentNullException(nameof(input));
            }
            string text = useFixer ? _styleFixer.FixTo(input, parseMode) : input;
            return parseMode switch
            {
                ParseModeKind.Markdown => $"_{text}_",
                ParseModeKind.MarkdownV2 => $"_{text}_",
                ParseModeKind.HTML => $"<i>{text}</i>",
                _ => text,
            };
        }
        /// <summary> Format text. Underline. </summary>
        /// <param name="input">Input text.</param>
        /// <param name="parseMode">Style to be applied to the new text.</param>
        /// <param name="useFixer">True, if you want to use the StyleFixer.</param>
        /// <returns>Stylized <see cref="string"/></returns>
        public virtual string Underline(string input, ParseModeKind parseMode = ParseModeKind.Markdown, bool useFixer = true)
        {
            if (string.IsNullOrEmpty(input))
            {
                throw new ArgumentNullException(nameof(input));
            }
            string text = useFixer ? _styleFixer.FixTo(input, parseMode) : input;
            return parseMode switch
            {
                ParseModeKind.Markdown => $"__{text}__",
                ParseModeKind.MarkdownV2 => $"__{text}__",
                ParseModeKind.HTML => $"<u>{text}</u>",
                _ => text,
            };
        }
        /// <summary> Format text. Strikethrough. </summary>
        /// <param name="input">Input text.</param>
        /// <param name="parseMode">Style to be applied to the new text.</param>
        /// <param name="useFixer">True, if you want to use the StyleFixer.</param>
        /// <returns>Stylized <see cref="string"/></returns>
        public virtual string Strikethrough(string input, ParseModeKind parseMode = ParseModeKind.Markdown, bool useFixer = true)
        {
            if (string.IsNullOrEmpty(input))
            {
                throw new ArgumentNullException(nameof(input));
            }
            string text = useFixer ? _styleFixer.FixTo(input, parseMode) : input;
            return parseMode switch
            {
                ParseModeKind.MarkdownV2 => $"~{text}~",
                ParseModeKind.HTML => $"<s>{text}</s>",
                _ => text,
            };
        }
        /// <summary> Format text. Code. </summary>
        /// <param name="input">Input text.</param>
        /// <param name="parseMode">Style to be applied to the new text.</param>
        /// <param name="useFixer">True, if you want to use the StyleFixer.</param>
        /// <returns>Stylized <see cref="string"/></returns>
        public virtual string Code(string input, ParseModeKind parseMode = ParseModeKind.Markdown, bool useFixer = true)
        {
            if (string.IsNullOrEmpty(input))
            {
                throw new ArgumentNullException(nameof(input));
            }
            string text = useFixer ? _styleFixer.FixTo(input, parseMode) : input;
            return parseMode switch
            {
                ParseModeKind.Markdown => $"`{text}`",
                ParseModeKind.MarkdownV2 => $"`{text}`",
                ParseModeKind.HTML => $"<code>{text}</code>",
                _ => input,
            };
        }
        /// <summary> Format text. Pre. </summary>
        /// <param name="input">Input text.</param>
        /// <param name="parseMode">Style to be applied to the new text.</param>
        /// <returns>Stylized <see cref="string"/></returns>
        public virtual string Pre(string input, ParseModeKind parseMode = ParseModeKind.Markdown)
        {
            if (string.IsNullOrEmpty(input))
            {
                throw new ArgumentNullException(nameof(input));
            }
            return parseMode switch
            {
                ParseModeKind.Markdown => $"```\n{input}\n```",
                ParseModeKind.MarkdownV2 => $"```\n{input}\n```",
                ParseModeKind.HTML => $"<pre>{input}</pre>",
                _ => input,
            };
        }
        /// <summary> Format text. Pre. </summary>
        /// <param name="input">Input text.</param>
        /// <param name="language">Programming language. Ex: python</param>
        /// <param name="parseMode">Style to be applied to the new text.</param>
        /// <returns>Stylized <see cref="string"/></returns>
        public virtual string Pre(string input, string language, ParseModeKind parseMode = ParseModeKind.Markdown)
        {
            if (string.IsNullOrEmpty(input))
            {
                throw new ArgumentNullException(nameof(input));
            }
            if (string.IsNullOrEmpty(language))
            {
                throw new ArgumentNullException(nameof(language));
            }
            return parseMode switch
            {
                ParseModeKind.Markdown => $"```\n```{language}\n{input}\n```",
                ParseModeKind.MarkdownV2 => $"```\n```{language}\n{input}\n```",
                ParseModeKind.HTML => $"<pre><code class=\"language-{language}\">{input}</code></pre>",
                _ => input,
            };
        }
        /// <summary> Format text. Text link. </summary>
        /// <param name="input">Input text.</param>
        /// <param name="url">Url.</param>
        /// <param name="parseMode">Style to be applied to the new text.</param>
        /// <param name="useFixer">True, if you want to use the StyleFixer.</param>
        /// <returns>Stylized <see cref="string"/></returns>
        public virtual string TextLink(string input, string url, ParseModeKind parseMode = ParseModeKind.Markdown, bool useFixer = true)
        {
            if (string.IsNullOrEmpty(input))
            {
                throw new ArgumentNullException(nameof(input));
            }
            if (string.IsNullOrEmpty(url))
            {
                throw new ArgumentNullException(nameof(url));
            }
            string text = useFixer ? _styleFixer.FixTo(input, parseMode) : input;
            return parseMode switch
            {
                ParseModeKind.Markdown or ParseModeKind.MarkdownV2 => $"[{text}]({url})",
                ParseModeKind.HTML => $"<a href=\"{url}\">{text}</a>",
                _ => text,
            };
        }
        /// <summary> Format text. Text Mention. </summary>
        /// <param name="input">Input text.</param>
        /// <param name="userId">Unique identifier for this user or bot.</param>
        /// <param name="parseMode">Style to be applied to the new text.</param>
        /// <param name="useFixer">True, if you want to use the StyleFixer.</param>
        /// <returns>Stylized <see cref="string"/></returns>
        public virtual string TextMention(string input, long userId, ParseModeKind parseMode = ParseModeKind.Markdown, bool useFixer = true)
        {
            if (string.IsNullOrEmpty(input))
            {
                throw new ArgumentNullException(nameof(input));
            }
            string text = useFixer ? _styleFixer.FixTo(input, parseMode) : input;
            return parseMode switch
            {
                ParseModeKind.Markdown or ParseModeKind.MarkdownV2 => $"[{text}](tg://user?id={userId})",
                ParseModeKind.HTML => $"<a href=\"tg://user?id={userId}\">{text}</a>",
                _ => text,
            };
        }
    }

    /// <summary>This class contains a set of useful methods for formatting the text of messages.</summary>
    [Obsolete("This class has been replaced by FormattingBuilder and will be removed in future releases.")]
    public class StyleParser
    {
        private FormattingBuilder _builder;
        /// <summary>Default StyleParser.</summary>
        public static readonly StyleParser Default = new StyleParser();
        /// <summary>Initialize a new instance of StyleParser.</summary>
        public StyleParser()
        {
            _builder = new FormattingBuilder();
        }
        /// <summary>Initialize a new instance of StyleParser.</summary>
        /// <param name="styleFixer">Custom StyleFixer.</param>
        public StyleParser(StyleFixer styleFixer)
        {
            _builder = new FormattingBuilder(styleFixer);
        }
        /// <summary>Create new stylized text from message entities.</summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="input">Input text.</param>
        /// <param name="parseMode">Style to be applied to the new text.</param>
        /// <param name="entities">Message entities.</param>
        /// <param name="useFixer">True, if you want to use the StyleFixer.</param>
        /// <returns>Stylized <see cref="string"/></returns>
        public virtual string FromEntities<T>(string input, ParseModeKind parseMode, T entities, bool useFixer = true) where T : IEnumerable<MessageEntity> => _builder.FromEntities<T>(input, parseMode, entities, useFixer);
        /// <summary> Format text. Bold. </summary>
        /// <param name="input">Input text.</param>
        /// <param name="parseMode">Style to be applied to the new text.</param>
        /// <param name="useFixer">True, if you want to use the StyleFixer.</param>
        /// <returns>Stylized <see cref="string"/></returns>
        public virtual string Bold(string input, ParseModeKind parseMode = ParseModeKind.Markdown, bool useFixer = true) => _builder.Bold(input, parseMode, useFixer);
        /// <summary> Format text. Italic. </summary>
        /// <param name="input">Input text.</param>
        /// <param name="parseMode">Style to be applied to the new text.</param>
        /// <param name="useFixer">True, if you want to use the StyleFixer.</param>
        /// <returns>Stylized <see cref="string"/></returns>
        public virtual string Italic(string input, ParseModeKind parseMode = ParseModeKind.Markdown, bool useFixer = true) => _builder.Italic(input, parseMode, useFixer);
        /// <summary> Format text. Underline. </summary>
        /// <param name="input">Input text.</param>
        /// <param name="parseMode">Style to be applied to the new text.</param>
        /// <param name="useFixer">True, if you want to use the StyleFixer.</param>
        /// <returns>Stylized <see cref="string"/></returns>
        public virtual string Underline(string input, ParseModeKind parseMode = ParseModeKind.Markdown, bool useFixer = true) => _builder.Underline(input, parseMode, useFixer);
        /// <summary> Format text. Strikethrough. </summary>
        /// <param name="input">Input text.</param>
        /// <param name="parseMode">Style to be applied to the new text.</param>
        /// <param name="useFixer">True, if you want to use the StyleFixer.</param>
        /// <returns>Stylized <see cref="string"/></returns>
        public virtual string Strikethrough(string input, ParseModeKind parseMode = ParseModeKind.Markdown, bool useFixer = true) => _builder.Strikethrough(input, parseMode, useFixer);
        /// <summary> Format text. Code. </summary>
        /// <param name="input">Input text.</param>
        /// <param name="parseMode">Style to be applied to the new text.</param>
        /// <param name="useFixer">True, if you want to use the StyleFixer.</param>
        /// <returns>Stylized <see cref="string"/></returns>
        public virtual string Code(string input, ParseModeKind parseMode = ParseModeKind.Markdown, bool useFixer = true) => _builder.Code(input, parseMode, useFixer);
        /// <summary> Format text. Pre. </summary>
        /// <param name="input">Input text.</param>
        /// <param name="parseMode">Style to be applied to the new text.</param>
        /// <returns>Stylized <see cref="string"/></returns>
        public virtual string Pre(string input, ParseModeKind parseMode = ParseModeKind.Markdown) => _builder.Pre(input, parseMode);
        /// <summary> Format text. Pre. </summary>
        /// <param name="input">Input text.</param>
        /// <param name="language">Programming language. Ex: python</param>
        /// <param name="parseMode">Style to be applied to the new text.</param>
        /// <returns>Stylized <see cref="string"/></returns>
        public virtual string Pre(string input, string language, ParseModeKind parseMode = ParseModeKind.Markdown) => _builder.Pre(input, language, parseMode);
        /// <summary> Format text. Text link. </summary>
        /// <param name="input">Input text.</param>
        /// <param name="url">Url.</param>
        /// <param name="parseMode">Style to be applied to the new text.</param>
        /// <param name="useFixer">True, if you want to use the StyleFixer.</param>
        /// <returns>Stylized <see cref="string"/></returns>
        public virtual string TextLink(string input, string url, ParseModeKind parseMode = ParseModeKind.Markdown, bool useFixer = true) => _builder.TextLink(input, url, parseMode, useFixer);
        /// <summary> Format text. Text Mention. </summary>
        /// <param name="input">Input text.</param>
        /// <param name="userId">Unique identifier for this user or bot.</param>
        /// <param name="parseMode">Style to be applied to the new text.</param>
        /// <param name="useFixer">True, if you want to use the StyleFixer.</param>
        /// <returns>Stylized <see cref="string"/></returns>
        public virtual string TextMention(string input, long userId, ParseModeKind parseMode = ParseModeKind.Markdown, bool useFixer = true) => _builder.TextMention(input, userId, parseMode, useFixer);
    }
}
