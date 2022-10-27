using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaiwanStock.Utility
{
    public class Class1
    {
		/// <summary>
		/// 判斷時間是否在股票營業日及時間裡
		/// </summary>
		/// <param name="dt">日期及時間</param>
		/// <returns>是或否</returns>
	    public bool isTradingTime(DateTime dt)
	    {
			//判斷日期
			if (dt.DayOfWeek == DayOfWeek.Sunday || dt.DayOfWeek == DayOfWeek.Saturday)
			{
				return false;
			}
			int time = (dt.Hour * 100) + dt.Minute;

			if (time >= 900 && time <= 1330)
			{
				return true;
			}

			return false;
	    }
    }
}
