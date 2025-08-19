using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.str.op_.unary_._add
{
	public class Ret4dbl
		:
		nilnul.obj.Box1<
			IEnumerable<double>
		>
		,
		IEnumerable<double>
	{
		public Ret4dbl(IEnumerable<double> val) : base(val)
		{

		}

		public IEnumerator<double> GetEnumerator()
		{
			var sum = 0d;


			yield return sum;

			foreach (var item in boxed)
			{
				yield return sum += item;
			}


			//throw new NotImplementedException();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
			throw new NotImplementedException();
		}
	}
}
