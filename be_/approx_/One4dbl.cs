using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.be_.approx_
{

	/// <seealso cref="be_.IInsignificant"/>, which is <see cref="approx_"/> 0;
	/// <summary>
	/// 
	/// </summary>
	public class One4dbl
		: nilnul.obj.Box_ofIn<
			real.be_.AboutNil4Dbl
		>
		,
		nilnul.num.real.BeDblI
	{
		public One4dbl(in AboutNil4Dbl val) : base(val)
		{
		}

		public One4dbl(AboutNil4Dbl x) : base(x)
		{
		}
		public One4dbl(double x):this(new AboutNil4Dbl(x))
		{
			
		}
		public bool be(double obj)
		{
			return boxed.be(obj-1);
		}

	

	}
}
