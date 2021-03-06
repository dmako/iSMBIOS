﻿
namespace iTin.Core.Hardware
{
    using System;

    /// <inheritdoc />
    /// <summary>
    /// Attribute that allows you to add a description to a property.
    /// </summary>
    [AttributeUsage(AttributeTargets.Field)]
    public sealed class PropertyDescriptionAttribute : Attribute
    {
        #region constructor/s

        #region [public] PropertyDescriptionAttribute(string): Initialize a new instance of the class by setting a string that defines the property
        /// <inheritdoc />
        /// <summary>
        /// Initialize a new instance of the <see cref="T:iTin.Core.Hardware.PropertyDescriptionAttribute" /> class by setting a string that defines the property.
        /// </summary>
        /// <param name="description">String that defines the property</param>
        public PropertyDescriptionAttribute(string description)
        {
            Description = description;
        }
        #endregion

        #endregion

        #region public readonly properties

        #region [public] (string) Description: Gets a string that defines the property
        /// <summary>
        /// Gets a string that defines the property.
        /// </summary>
        /// <value>
        /// <see cref="T:System.String"/> that defines the property.
        /// </value>
        public string Description { get; }
        #endregion

        #endregion
    }
}
