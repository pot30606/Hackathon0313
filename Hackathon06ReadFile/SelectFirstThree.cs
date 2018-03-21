using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon06ReadFile
{
    public delegate bool MyPredicate(string value);
    public class SelectFirstThree
    {
        public List<string> DoWhere(List<string> source, MyPredicate predicate)
        {
            List<string> result = new List<string>();
            foreach (var item in source)
            {
                if (predicate.Invoke(item))
                {
                    result.Add(item);
                }
            }
            return result;
        }
    }
}
