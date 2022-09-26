using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real
{
	/*extern alias obj;*/
	public interface Be4floatI
		:
		/*obj::*/nilnul.obj.BeI1<float>

	{
	}

	


	public  class Be4float :
		nilnul.obj.Box1<Func<float,bool>>
		,
		Be4floatI
	{
		public Be4float(Func<float, bool> val) : base(val)
		{
		}

		public bool be(float x) {
			return boxed(x);
		}
	}
}
