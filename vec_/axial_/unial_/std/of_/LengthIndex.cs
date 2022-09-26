using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.vec_.axial_.unial_.std.of_
{
	public class OfLengthIndex
	{
		public double[] _arr_lengthIndexAssumeNumsGt(int en1, int en2)
		{
			var r = new double[en1];
			r[en2] = 1;
			return r;
		}

		public double[] _arrOfOneAtLast_lengthAssumePositive(int en1)
		{
			return _arr_lengthIndexAssumeNumsGt(en1, en1 - 1);
		}

		internal double[] _arrOfOneAtBegin_lengthAssumePositive(int _lengthAssumePositive)
		{
			return _arr_lengthIndexAssumeNumsGt(_lengthAssumePositive, 0);
		}

		public double[] _arr_lengthIndexAsInts(nilnul.num.co.be_.gt.vow.Ee ee) {

			return _arr_lengthIndexAssumeNumsGt	(
				(int) (ee.component.toBigint().en)
				,
				(int) (ee.component1.toBigint().en)
			);

		}

		static public OfLengthIndex Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<OfLengthIndex>.Instance;
			}
		}



	}
}
