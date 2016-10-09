using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Day1Homework
{
    public class cal
    {
        /// <summary>
        /// 需求:1. 來源可以是「任何型別的集合」 2. 可以任意決定幾筆一組 3. 回傳每一組 Σf(x) 的集合- Σ結果型別可直接用int
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="CalList">泛型資料</param>
        /// <param name="CalColName">計算欄位名稱</param>
        /// <param name="RowCnt">分組筆數</param>
        /// <returns></returns>
        public List<int> Sum<T>(List<T> CalList, string CalColName, int RowCnt)
        {
            List<int> Ret = new List<int>();
            int totalpage = Convert.ToInt32(System.Math.Ceiling(Convert.ToDouble(CalList.Count) / Convert.ToDouble(RowCnt)));
            int pagecnt = 1;
            int Sum = 0;
            for (int i = 0; i < totalpage; i++)
            {
                List<T> List = CalList.Skip((pagecnt - 1) * RowCnt).Take(RowCnt).ToList();
                for (int j = 0; j < List.Count(); j++)
                {
                    int iSum = 0;
                    if(int.TryParse(List[j].GetType().GetProperty(CalColName).GetValue(List[j], null).ToString(), out iSum))
                        Sum += iSum;
                }
                Ret.Add(Sum);
                pagecnt++;
                Sum = 0;
            }
            return Ret.ToList();
        }

    }


}
