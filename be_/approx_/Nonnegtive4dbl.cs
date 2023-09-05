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
	public class Nonnegtive4dbl
		: nilnul.obj.Box_ofIn<
			real.be_.AboutNil4Dbl
		>
		,
		nilnul.num.real.BeDblI
	{
		public Nonnegtive4dbl(in AboutNil4Dbl val) : base(val)
		{
		}

		public Nonnegtive4dbl(AboutNil4Dbl x) : base(x)
		{
		}
		public Nonnegtive4dbl(double x):this(new AboutNil4Dbl(x))
		{
			
		}
		public bool be(double obj)
		{
			return obj>=0 || boxed.be(obj);
		}

	

	}
}
