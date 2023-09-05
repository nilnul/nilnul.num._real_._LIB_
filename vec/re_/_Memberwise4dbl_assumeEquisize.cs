using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.vec.re_
{
	 public class _Memberwise4dbl_assumeEquisize
		:
		nilnul.obj.str.vec.re_._Memberwise_assumesVec<double>
		//nilnul.obj.Box1<
		//	nilnul.num.real.ReDblI
		//>

	{
		public _Memberwise4dbl_assumeEquisize(ReDblI val) : base(val)
		{
		}

		public _Memberwise4dbl_assumeEquisize(in obj.ReI<double> val) : base(val)
		{
		}

		public _Memberwise4dbl_assumeEquisize(obj.ReI<double> x) : base(x)
		{
		}
	}
}
