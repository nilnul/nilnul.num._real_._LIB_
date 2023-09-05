using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.be_.approx_
{

	/// <summary>
	/// 
	/// </summary>
	public class Nonpostive4dbl
		: nilnul.obj.Box_ofIn<
			real.be_.AboutNil4Dbl
		>
		,
		nilnul.num.real.BeDblI
	{
		public Nonpostive4dbl(in AboutNil4Dbl val) : base(val)
		{
		}

		public Nonpostive4dbl(AboutNil4Dbl x) : base(x)
		{
		}
		public Nonpostive4dbl(double x):this(new AboutNil4Dbl(x))
		{
			
		}
		public bool be(double obj)
		{
			return obj<=0 || boxed.be(obj);
		}

	

	}
}
