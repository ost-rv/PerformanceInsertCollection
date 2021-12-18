using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerformanceInsertCollection
{
    public class TestLinkedList
    {
        LinkedList<string> _stringLinkedList = new LinkedList<string>();
        public LinkedList<string> GetLinkedListString(string[] text)
        {

            foreach (string str in text)
            {
                //_stringLinkedList.AddLast(str);
                _stringLinkedList.AddFirst(str);
            }

            return _stringLinkedList;
        }
    }
}
