#region Copyright Ben Cheetham 2011
// 
// All rights are reserved. Reproduction or transmission in whole or in part, in 
// any form or by any means, electronic, mechanical or otherwise, is prohibited 
// without the prior written consent of the copyright owner. 
// 
// Filename: EnumExtension.cs
// 
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using GuildfordBoroughCouncil.Linq;

namespace GuildfordBoroughCouncil.Web.Mvc
{
    public static partial class EnumHelper
    {
        // http://blog.milrr.com/2012/01/code-convert-enum-to-mvc-selectlist.html
        // e.g.EnumHelper.GetSelectList<CommunicationTypes>()
        [Obsolete("Use as int", false)]
        public static List<SelectListItem> GetSelectList<TEnum>(params TEnum[] ignoreList)
        {
            return GetSelectListAsInt<TEnum>(false, ignoreList);
        }

        public static List<SelectListItem> GetSelectListAsInt<TEnum>(bool Lower = false, params TEnum[] ignoreList)
        {
            List<SelectListItem> enumList = new List<SelectListItem>();
            foreach (TEnum data in Enum.GetValues(typeof(TEnum)))
            {
                if (!ignoreList.Contains(data))
                {
                    enumList.Add(new SelectListItem
                    {
                        Text = (Lower) ? data.ToString().FormatEnum().ToLower() : data.ToString().FormatEnum(),
                        Value = ((int)Enum.Parse(typeof(TEnum), data.ToString())).ToString()
                    });
                }
            }

            return enumList;
        }

        public static List<SelectListItem> GetSelectListAsString<TEnum>(params TEnum[] ignoreList)
        {
            List<SelectListItem> enumList = new List<SelectListItem>();
            foreach (TEnum data in Enum.GetValues(typeof(TEnum)))
            {
                if (!ignoreList.Contains(data))
                {
                    enumList.Add(new SelectListItem
                    {
                        Text = data.ToString().FormatEnum(),
                        Value = data.ToString()
                    });
                }
            }

            return enumList;
        }
    }
}