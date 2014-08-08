using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuildfordBoroughCouncil.Web.Mvc
{
    public enum AlertType
    {
        Default,
        Warning,
        Danger,
        Success,
        Info
    }

    public class AlertBox
    {
        public AlertBox(AlertType Type, string Message, bool Dismissable = true)
        {
            this.Dismissable = Dismissable;
            this.Type = Type;
            this.Message = Message;
        }

        public AlertType Type { get; set; }

        public bool Dismissable { get; set; }

        public string CssClass
        {
            get
            {
                switch (Type)
                {
                    case AlertType.Default:
                        return string.Empty;
                    default:
                        return "alert-" + Type.ToString().ToLower();
                }
            }
        }

        public string Message { get; set; }
    }
}