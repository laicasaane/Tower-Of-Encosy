﻿using System;

namespace Module.Core.Mvvm.Input.SourceGen
{
    /// <summary>
    /// An attribute that indicates that a given property is generated by the Relay Command generator.
    /// </summary>
    /// <remarks>
    /// This attribute is not intended to be used directly by user code to decorate user-defined properties.
    /// <br/>
    /// However, it can be used in other contexts, such as reflection.
    /// </remarks>
    /// <seealso cref="RelayCommandAttribute"/>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
    public sealed class GeneratedRelayCommandAttribute : Attribute
    {
        public string ForMemberName { get; }

        public GeneratedRelayCommandAttribute(string forMemberName)
        {
            this.ForMemberName = forMemberName;
        }
    }
}
