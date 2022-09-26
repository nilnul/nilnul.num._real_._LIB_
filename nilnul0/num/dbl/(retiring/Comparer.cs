using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.ieee
{
	public class Comparer
		: IComparer<double>
	{
		public int Compare(double x, double y)
		{
			return Comparer<double>.Default.Compare(x,y);
		//	throw new NotImplementedException();
		}



		static public Comparer Lazy
		{
			get
			{
				return nilnul.obj_.singleton_.Lazy<Comparer>.Instance;
			}
		}



	}
}
