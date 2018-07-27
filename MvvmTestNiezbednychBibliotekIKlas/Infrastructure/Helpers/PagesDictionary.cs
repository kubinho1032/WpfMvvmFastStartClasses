using System;
using System.Collections.Generic;
using WarsztatWpf.Modules.Customers.Views;

namespace WarsztatWpf.Infrastructure
{
    public static class PagesDictionary
    {
        public static Dictionary<string, Type> ViewSources = new Dictionary<string, Type>() {
            // SampleEntity
            { "SampleEntityList", typeof(SampleEntityList) },
            { "SampleEntityEdit", typeof(SampleEntityEdit) }
        };

        public static Dictionary<string, string> ViewNamesPolishTranslate = new Dictionary<string, string>() {
            //SampleEntity
            { "SampleEntityList", "SampleEntity" },
            { "SampleEntityEdit", "SampleEntity" }
        };
    }
}
