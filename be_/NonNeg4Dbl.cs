using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.be_
{

	public class NonnegOfDouble
		: 
		
		nilnul.num.real.IBeOfDouble
	{

		static public NonnegOfDouble Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<NonnegOfDouble>.Instance;
			}
		}

		public bool be(double obj)
		{
			return obj>=0;
		}
	}
}
