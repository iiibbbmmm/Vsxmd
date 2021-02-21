//-----------------------------------------------------------------------
// <copyright file="MemberKind.cs" company="Junle Li">
//     Copyright (c) Junle Li. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System.ComponentModel;

namespace Vsxmd.Units
{
    /// <summary>
    /// The member kind.
    /// </summary>
    internal enum MemberKind
    {
        /// <summary>
        /// Not supported member kind.
        /// </summary>
        [Description("不支持")]
        NotSupported,

        /// <summary>
        /// Type.
        /// </summary>
        [Description("类型")]
        Type,

        /// <summary>
        /// Constructor.
        /// </summary>
        [Description("构造函数")]
        Constructor,

        /// <summary>
        /// Constants
        /// </summary>
        [Description("常量")]
        Constants,

        /// <summary>
        /// Property.
        /// </summary>
        [Description("属性")]
        Property,

        /// <summary>
        /// Method.
        /// </summary>
        [Description("方法")]
        Method,
    }
}
