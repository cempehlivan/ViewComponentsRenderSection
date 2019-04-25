using Microsoft.AspNetCore.Html;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CMP.SectionControls
{
    public class SectionControl
    {
        public class SectionControlItem
        {
            public string SectionName { get; set; }
            public string Value { get; set; }
        }

        public List<SectionControlItem> SectionItems { get; set; }

        public object AddItem(string SectionName, string Value, bool Multiple = false)
        {
            if (SectionItems == null)
                SectionItems = new List<SectionControlItem>();

            if (Multiple == true || SectionItems.FirstOrDefault(s => s.SectionName == SectionName && s.Value == Value) == null)
                SectionItems.Add(new SectionControlItem { SectionName = SectionName, Value = Value });

            return null;
        }

        public HtmlString GetItems(string SectionName)
        {
            if (SectionItems == null)
                return new HtmlString("");

            return new HtmlString(String.Join("\n", SectionItems.Where(s => s.SectionName == SectionName).Select(s => s.Value).ToList()));
        }
    }
}
