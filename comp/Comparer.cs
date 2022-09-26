using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.dbl
{
	public class Comp
		: IComparer<double>
	{
		public int Compare(double x, double y)
		{
			return Comparer<double>.Default.Compare(x,y);
		//	throw new NotImplementedException();
		}



		static public Comp Singleton
		{
			get
			{
				return nilnul.obj_.singleton_.Lazy<Comp>.Instance;
			}
		}



	}
}
