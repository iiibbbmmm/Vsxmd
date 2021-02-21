namespace Vsxmd
{
    using System;
    using System.ComponentModel;

    /// <summary>
    /// Helper to Enum.
    /// </summary>
    internal static class EnumHelper
    {
        /// <summary>
        /// Get Description Attribute Value.
        /// </summary>
        /// <param name="e">enum value</param>
        /// <returns>Description.</returns>
        public static string GetDescription(this Enum e)
        {
            var enumType = e.GetType();
            var memberInfos = enumType.GetMember(e.ToString());
            var valueAttributes = memberInfos[0].GetCustomAttributes(typeof(DescriptionAttribute), false);
            return ((DescriptionAttribute)valueAttributes[0]).Description;
        }
    }
}