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
	///
	[Obsolete(nameof(Nonnegtive4dbl) + " is more relevant|revealing|descriptive;")]
	public class Positive4dbl
		: nilnul.obj.Box_ofIn<
			real.be_.AboutNil4Dbl
		>
		,
		nilnul.num.real.BeDblI
	{
		public Positive4dbl(in AboutNil4Dbl val) : base(val)
		{
		}

		public Positive4dbl(AboutNil4Dbl x) : base(x)
		{
		}
		public Positive4dbl(double x):this(new AboutNil4Dbl(x))
		{
			
		}
		public bool be(double obj)
		{
			return obj>=0 || boxed.be(obj);
		}

	

	}
}
