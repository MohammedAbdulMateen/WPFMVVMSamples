//-----------------------------------------------------------------------
// <copyright file="PropertySupport.cs" company="Independent">
//     Copyright (c). All rights reserved.
// </copyright>
// <author>Mohammed Abdul Mateen</author>
//-----------------------------------------------------------------------

namespace PWP.ViewModels.Core
{
    using System;
    using System.Linq.Expressions;
    using System.Reflection;

    /// <summary>
    /// Provides support for extracting property information based on a property expression.
    /// </summary>
    public static class PropertySupport
    {
        /// <summary>
        /// Extracts the name of the property.
        /// </summary>
        /// <typeparam name="T">The element type of PropertySupport</typeparam>
        /// <param name="propertyExpression">The property expression.</param>
        /// <returns>Property name</returns>
        /// <exception cref="System.ArgumentNullException">property Expression</exception>
        /// <exception cref="System.ArgumentException">
        /// The expression is not a member access expression.;property Expression
        /// or
        /// The member access expression does not access a property.;property Expression
        /// or
        /// The referenced property is a static property.;property Expression
        /// </exception>
        public static string ExtractPropertyName<T>(Expression<Func<T>> propertyExpression)
        {
            if (propertyExpression == null)
            {
                throw new ArgumentNullException("propertyExpression");
            }

            var memberExpression = propertyExpression.Body as MemberExpression;
            if (memberExpression == null)
            {
                throw new ArgumentException("The expression is not a member access expression.", "propertyExpression");
            }

            var property = memberExpression.Member as PropertyInfo;
            if (property == null)
            {
                throw new ArgumentException("The member access expression does not access a property.", "propertyExpression");
            }

            var getMethod = property.GetGetMethod(true);
            if (getMethod.IsStatic)
            {
                throw new ArgumentException("The referenced property is a static property.", "propertyExpression");
            }

            return memberExpression.Member.Name;
        }
    }
}
