using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real
{
	static public class _SignDblX
	{
		static public int Int(double x) {
			return x.CompareTo(0);
		}

		static public bool? BitNul(double x) {
			return x==0?(bool?)null: x>0;
		}

		/// <summary>
		/// 1,0,-1
		/// </summary>
		/// <param name="x"></param>
		/// <returns></returns>
		static public int Sign(double x) {
			return x==0?0: x>0?1:-1;
		}




	}
}
