// Copyright (c) 2022 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System;

namespace Telegram.BotAPI.AvailableMethods.FormattingOptions
{
    /// <summary>This class contains a set of useful methods for formatting the text of messages.</summary>
    [Obsolete("This class has been replaced by FormattingHelper and will be removed in future releases.")]
    public class FormattingBuilder : FormattingHelper<StyleFixer>
    {
        /// <summary>Initialize a new instance of <see cref="FormattingBuilder"/>.</summary>
        public FormattingBuilder() : base(StyleFixer.Default)
        {
        }

        /// <summary>Initialize a new instance of <see cref="FormattingBuilder"/>.</summary>
        /// <param name="styleFixer">Custom StyleFixer.</param>
        public FormattingBuilder(StyleFixer styleFixer) : base(styleFixer)
        {
        }
    }
}
