using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
