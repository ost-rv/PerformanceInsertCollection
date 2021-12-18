using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerformanceInsertCollection
{
    public class TestList
    {
        public List<string> GetListString(string[] text)
        {
            List<string> stringList = new List<string>();

            foreach (string str in text)
            {
                stringList.Add(str);
            }

            return stringList;
        }
    }
}
