﻿// Copyright (c) 2022 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.AvailableMethods.FormattingOptions
{
    /// <summary>This class contains a set of useful methods for formatting the text of messages.</summary>
    public class FormattingHelper : FormattingHelper<StyleParser>
    {
        /// <summary>Initialize a new instance of StyleParser.</summary>
        /// <param name="styleParser">Custom StyleFixer.</param>
        public FormattingHelper([Optional] StyleParser styleParser) : base(styleParser ?? StyleParser.Default)
        {
        }
    }

    /// <summary>This class contains a set of useful methods for formatting the text of messages.</summary>
    public class FormattingHelper<TStyleParser>
        where TStyleParser : IStyleParser
    {
        /// <summary>StyleFixer</summary>
        protected readonly IStyleParser Parser;

        /// <summary>Initialize a new instance of StyleParser.</summary>
        /// <param name="styleParser">Custom StyleFixer.</param>
        public FormattingHelper(TStyleParser styleParser)
        {
            Parser = styleParser ?? throw new ArgumentNullException(nameof(styleParser));
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
                        subText = useFixer ? Parser.To(nFsubText, parseMode) : nFsubText;
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
                        case MessageEntityType.Spoiler:
                            buffer.Append(Spoiler(subText, parseMode, true));
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
                                subText = Parser.To(subText, parseMode);
                            }
                            buffer.Append(subText);
                            break;
                    }
                    offset += e.Length;
                }
                if (offset < input.Length)
                {
                    nFsubText = input.Substring(offset, input.Length - offset);
                    subText = useFixer ? Parser.To(nFsubText, parseMode) : nFsubText;
                    buffer.Append(subText);
                }
                return buffer.ToString();
            }
            else
            {
                return useFixer ? Parser.To(input, parseMode) : input;
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
            string text = useFixer ? Parser.To(input, parseMode) : input;
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
            string text = useFixer ? Parser.To(input, parseMode) : input;
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
            string text = useFixer ? Parser.To(input, parseMode) : input;
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
            string text = useFixer ? Parser.To(input, parseMode) : input;
            return parseMode switch
            {
                ParseModeKind.MarkdownV2 => $"~{text}~",
                ParseModeKind.HTML => $"<s>{text}</s>",
                _ => text,
            };
        }
        /// <summary> Format text. Spoiler. </summary>
        /// <param name="input">Input text.</param>
        /// <param name="parseMode">Style to be applied to the new text.</param>
        /// <param name="useFixer">True, if you want to use the StyleFixer.</param>
        /// <returns>Stylized <see cref="string"/></returns>
        public virtual string Spoiler(string input, ParseModeKind parseMode = ParseModeKind.Markdown, bool useFixer = true)
        {
            if (string.IsNullOrEmpty(input))
            {
                throw new ArgumentNullException(nameof(input));
            }
            string text = useFixer ? Parser.To(input, parseMode) : input;
            return parseMode switch
            {
                ParseModeKind.MarkdownV2 => $"||{text}||",
                ParseModeKind.HTML => $"<span class=\"tg-spoiler\">{text}</span>",
                _ => input,
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
            string text = useFixer ? Parser.To(input, parseMode) : input;
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
            string text = useFixer ? Parser.To(input, parseMode) : input;
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
            string text = useFixer ? Parser.To(input, parseMode) : input;
            return parseMode switch
            {
                ParseModeKind.Markdown or ParseModeKind.MarkdownV2 => $"[{text}](tg://user?id={userId})",
                ParseModeKind.HTML => $"<a href=\"tg://user?id={userId}\">{text}</a>",
                _ => text,
            };
        }
    }
}
