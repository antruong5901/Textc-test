﻿using System.Text;
using Takenet.Text.Templates;

namespace Takenet.Text
{
    /// <summary>
    /// Defines a text structure with token templates that can be used to parse a text input into a <see cref="Expression" />.
    /// </summary>
    public sealed class Syntax
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Syntax" /> class.
        /// </summary>
        /// <param name="tokenTemplates">The token templates.</param>
        /// <param name="rightToLeftParsing">if set to <c>true</c> [right to left parsing].</param>
        /// <param name="perfectMatchOnly">if set to <c>true</c> [perfect match only].</param>
        public Syntax(ITokenTemplate[] tokenTemplates, bool rightToLeftParsing, bool perfectMatchOnly)
        {
            TokenTemplates = tokenTemplates;
            RightToLeftParsing = rightToLeftParsing;
            PerfectMatchOnly = perfectMatchOnly;
        }

        /// <summary>
        /// Gets the syntax token templates.
        /// </summary>
        public ITokenTemplate[] TokenTemplates { get; }

        /// <summary>
        /// Indicates if the parsing should be done from the right to the left direction.
        /// </summary>
        public bool RightToLeftParsing { get; private set; }

        /// <summary>
        /// Indicates if the syntax demands that
        /// all input should be consumed in order to satisfy it.
        /// </summary>
        public bool PerfectMatchOnly { get; private set; }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            var builder = new StringBuilder();

            if (TokenTemplates != null)
            {
                foreach (var tokenTemplate in TokenTemplates)
                {
                    builder.AppendFormat("{0} ", tokenTemplate);
                }
            }

            return builder.ToString().Trim();
        }
    }
}