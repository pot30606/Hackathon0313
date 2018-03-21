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
        //委派函式 傳入list list是讀取的檔案  然後透過委派MyPredicate predicate
        // 來找到符合條件的 建立成新的list 名為result 並回傳~
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
