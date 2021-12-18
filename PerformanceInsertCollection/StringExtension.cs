using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerformanceInsertCollection
{
    public static class StringExtension
    {
        public static string[] GetStringArray(this string text)
        {
            return text.Split('\n');
        }
    }
}
