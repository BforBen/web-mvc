using System;

namespace GuildfordBoroughCouncil.ComponentModel.DataAnnotations
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter, AllowMultiple = false)]
    public sealed class HelpAttribute : Attribute
    {
        public HelpAttribute()
        { }

        public string Text { get; set; }
    }
}
