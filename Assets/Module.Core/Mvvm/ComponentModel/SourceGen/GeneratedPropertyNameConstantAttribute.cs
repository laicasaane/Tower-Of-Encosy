﻿using System;

namespace Module.Core.Mvvm.ComponentModel.SourceGen
{
    /// <summary>
    /// An attribute that indicates that a given constant is generated by the Observable Property generator.
    /// </summary>
    /// <remarks>
    /// This attribute is not intended to be used directly by user code to decorate user-defined properties.
    /// <br/>
    /// However, it can be used in other contexts, such as reflection.
    /// </remarks>
    /// <seealso cref="PropertyChangingEventHandler"/>
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = false)]
    public sealed class GeneratedPropertyNameConstantAttribute : Attribute { }
}
