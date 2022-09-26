using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real
{
	/*extern alias obj;*/
	public interface BeDblI
		:
		/*obj::*/nilnul.obj.BeI1<double>

	{
	}

	[Obsolete()]
	public interface IBeOfDouble
		:
		BeDblI
		/*obj::*///nilnul.obj.BeI1<double>

	{
	}


	public  class BeOfDouble :
		nilnul.obj.Box<Func<double,bool>>
		,
		IBeOfDouble
	{
		public BeOfDouble(Func<double, bool> val) : base(val)
		{
		}

		public bool be(double x) {
			return boxed(x);
		}
	}
}
