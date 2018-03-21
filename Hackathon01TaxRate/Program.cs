using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon01TaxRate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入你的年收入:");
            decimal total = int.Parse(Console.ReadLine());
            decimal Total_Money =0;
            var list = taxes();

            while (total > 0)
            {
                var result = list.Where((x) => x.Range_st <= total && total <= x.Range_ed).ToList();
                foreach (var item in result)
                {
                    if (item.Range_st != 0)
                    {
                        Total_Money += (total - (item.Range_st - 1)) * item.Rate;
                        total =item.Range_st - 1;
                    }
                    if (item.Range_st == 0)
                    {
                        Total_Money += total * item.Rate;
                        total = total - total;
                    }
                }
            }
            Console.WriteLine($"您要繳的稅為 : {Total_Money}");
            
            Console.ReadLine();
        }

        public static List<Tax> taxes()
        {
            var taxes = new List<Tax>() {
            new Tax(){Range_st=0,Range_ed=540000,Rate=0.05m},
            new Tax(){Range_st=540001,Range_ed=1210000,Rate=0.12m},
            new Tax(){Range_st=1210001,Range_ed=2420000,Rate=0.20m},
            new Tax(){Range_st=2420001,Range_ed=4530000,Rate=0.30m},
            new Tax(){Range_st=4530001,Range_ed=10310000,Rate=0.40m},
            new Tax(){Range_st=10310001,Range_ed=int.MaxValue,Rate=0.50m},
            };
            return taxes;
            
        }
    }
}
