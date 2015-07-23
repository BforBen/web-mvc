using System.Collections.Generic;
using System.Web.Mvc;

namespace GuildfordBoroughCouncil.Linq
{
    public static class KeyValuePairExtension
    {
        /// <summary>
        /// Returns a select list from an enumerable KeyValuePair.
        /// </summary>
        public static SelectList ToSelectList<TKey, TValue>(this IEnumerable<KeyValuePair<TKey, TValue>> list)
        {
            return new SelectList(list, "Key", "Value");
        }
    }
}
