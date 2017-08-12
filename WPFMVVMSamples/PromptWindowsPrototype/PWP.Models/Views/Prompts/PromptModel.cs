//-----------------------------------------------------------------------
// <copyright file="PromptModel.cs" company="Independent">
//     Copyright (c). All rights reserved.
// </copyright>
// <author>Mohammed Abdul Mateen</author>
//-----------------------------------------------------------------------

namespace PWP.Models.Views.Prompts
{
    /// <summary>
    /// class PromptModel
    /// </summary>
    public class PromptModel
    {
        /// <summary>
        /// Gets or sets the identity.
        /// </summary>
        /// <value>
        /// The identity.
        /// </value>
        public int Identity { get; set; }

        /// <summary>
        /// Gets or sets the prompt response.
        /// </summary>
        /// <value>
        /// The prompt response.
        /// </value>
        public string PromptResponse { get; set; }
    }
}
