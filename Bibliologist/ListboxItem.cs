using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bibliologist
{
    class ListboxItem
    {
        string Value { get; set; }
        string Key { get; set; }

        public ListboxItem(string key, string value)
        {
            this.Key = key;
            this.Value = value;
        }

        public override string ToString()
        {
            return Value;
        }

        public static ListboxItem[] ToArray(Dictionary<string, string> items)
        {
            ListboxItem[] itemArray = new ListboxItem[items.Count];

            int i = 0;

            foreach (var s in items.Keys)
            {
                ListboxItem itm = new ListboxItem(s, items[s]);

                itemArray[i] = itm;

                i++;
            }

            return itemArray;
        }
    }
}
