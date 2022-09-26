using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real
{
	public class ComparerDbl
		: IComparer<double>
	{
		public int Compare(double x, double y)
		{
			return Comparer<double>.Default.Compare(x,y);
		//	throw new NotImplementedException();
		}




		static public ComparerDbl Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<ComparerDbl>.Instance;
			}
		}



	}
}
