// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace Telegram.BotAPI.AvailableMethods.FormattingOptions
{
    /// <summary>Use this class to correct text with incorrect style tags or to create custom StyleFixers for use with the StyleParser.</summary>
    public class StyleFixer
    {
        /// <summary>Default StyleFixer.</summary>
        public static readonly StyleFixer Default = new StyleFixer();
        /// <summary>Fix specified text with wrong style tags.</summary>
        /// <param name="input">Input text.</param>
        /// <param name="parseMode">Style to be applied to the new text.</param>
        /// <returns><see cref="string"/></returns>
        public string FixTo(string input, StyleMode parseMode)
        {
            return parseMode switch
            {
                StyleMode.Markdown => FixToMarkdown(input),
                StyleMode.MarkdownV2 => FixToMarkdownV2(input),
                StyleMode.HTML => FixToHTML(input),
                _ => input,
            };
        }
        /// <summary>Replaces symbols that are not part of an HTML tag or entity with HTML entities (&lt; with &amp;lt;, &gt; with &amp;gt; and &amp; with &amp;amp;).</summary>
        /// <param name="input">Input text.</param>
        /// <returns>String with HTML entities.</returns>
        /// <returns><see cref="string"/></returns>
        public virtual string FixToHTML(string input)
        {
            if (input == null)
            {
                throw new NullReferenceException(nameof(input));
            }
            return input
                .Replace("&", "&amp;")
                .Replace("<", "&lt;")
                .Replace(">", "&gt;");
        }

        /// <summary>Prepends the character '\' for the escape characters: '_', '*', '`', '['.</summary>
        /// <param name="input">Input text.</param>
        /// <returns><see cref="string"/></returns>
        public virtual string FixToMarkdown(string input)
        {
            if (input == null)
            {
                throw new NullReferenceException(nameof(input));
            }
            var chars = "_*`[";
            return Prepends(input, '\\', chars);
        }
        /// <summary>Prepends the character '\' for the escape characters: '_', '*', '[', ']', '(', ')', '~', '`', '>', '#', '+', '-', '=', '|', '{', '}', '.', '!'.</summary>
        /// <param name="input">Input text.</param>
        /// <returns><see cref="string"/></returns>
        public virtual string FixToMarkdownV2(string input)
        {
            if (input == null)
            {
                throw new NullReferenceException(nameof(input));
            }
            var chars = "_*[]()~`>#+-=|{}.!";
            return Prepends(input, '\\', chars);
        }
        /// <summary>Returns a new string in which all occurrences of the specified Unicode characters in this instance are prepended with another specified Unicode character.</summary>
        /// <param name="text">The string to be prepends.</param>
        /// <param name="pChar">The character to be prepended to the other characters.</param>
        /// <param name="characters">The Unicode characters to be prepended by the specified character.</param>
        /// <returns><see cref="string"/></returns>
        protected string Prepends(string text, char pChar, IEnumerable<char> characters)
        {
            if (string.IsNullOrEmpty(text))
            {
                throw new ArgumentNullException(nameof(text));
            }
            var sb = new StringBuilder();
            foreach (var c in text)
            {
                if (characters.Contains(c))
                {
                    sb.Append(pChar);
                }
                sb.Append(c);
            }
            return sb.ToString();
        }
    }
}
