using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.be_
{

	public class PositiveDbl
		: 
		
		nilnul.num.real.IBeOfDouble
		,nilnul.num.real.BeDblI
	{

		static public PositiveDbl Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<PositiveDbl>.Instance;
			}
		}

		public bool be(double obj)
		{
			return obj>0;
		}
	}
}
