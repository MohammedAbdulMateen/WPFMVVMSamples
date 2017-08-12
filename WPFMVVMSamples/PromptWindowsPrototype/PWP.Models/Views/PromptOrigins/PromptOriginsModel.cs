//-----------------------------------------------------------------------
// <copyright file="PromptOriginsModel.cs" company="Independent">
//     Copyright (c). All rights reserved.
// </copyright>
// <author>Mohammed Abdul Mateen</author>
//-----------------------------------------------------------------------

namespace PWP.Models.Views.PromptOrigins
{
    using System.Windows.Media;
    using PWP.ViewModels.Core;

    /// <summary>
    /// class PromptOriginsModel
    /// </summary>
    public class PromptOriginsModel : BaseNotification
    {
        /// <summary>
        /// Gets or sets the prompt origins identity.
        /// </summary>
        /// <value>
        /// The prompt origins identity.
        /// </value>
        public int PromptOriginsIdentity { get; set; }

        /// <summary>
        /// Gets or sets the prompt origins text.
        /// </summary>
        /// <value>
        /// The prompt origins text.
        /// </value>
        public string PromptOriginsText { get; set; }

        /// <summary>
        /// Gets or sets the prompt origins response.
        /// </summary>
        /// <value>
        /// The prompt origins response.
        /// </value>
        public string PromptOriginsResponse { get; set; }

        /// <summary>
        /// Gets or sets the prompt origins brush.
        /// </summary>
        /// <value>
        /// The prompt origins brush.
        /// </value>
        public Brush PromptOriginsBrush { get; set; }
    }
}
