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
            //讀取稅務累計算進表
            var list = taxes();
            //每做一次迴圈都會把計算完的金額給減少 當金額歸零時代表計算完成
            while (total > 0)
            {
                //找到現在金額屬於哪一個區間的
                var result = list.Where((x) => x.Range_st <= total && total <= x.Range_ed).ToList();
                //將該區間的值取出(item)
                foreach (var item in result)
                {
                    //如果不是第一個區間 0~54萬元 5%稅率的話
                    if (item.Range_st != 0)
                    {
                        //累計稅金 += 目前的總額減去 (起始區間值 -1) 最後再乘以稅率%數
                        //為何要-1 ?　因為該區間的起始值(第1塊錢)也要計算到 
                        Total_Money += (total - (item.Range_st - 1)) * item.Rate;
                        //目前的總額更改為 起始值-1
                        //為何要-1 ? 因為這個區間計算完了 = 那個第1塊錢也算完了 
                        total =item.Range_st - 1;
                    }
                    //如果是第一個區間
                    if (item.Range_st == 0)
                    {
                        //累計稅金 += 目前的總額 乘以 第一區間的稅率
                        Total_Money += total * item.Rate;
                        // 第一區間算完就代表結束了
                        total = total - total;
                    }
                    //追求最佳化寫法  能夠因應不同的變化 
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
