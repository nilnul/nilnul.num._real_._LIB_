using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real_.eg_._exp._subsume
{
	internal class Peek
		: nilnul.obj.stream_.slider_.Peek<num.quotient_.DenomNonnil>
	{
		private num.quotient.stream_.slider_.factorial.Inverse_onInteger _slider;

		public ref BigInteger indexAhead { get { return ref _slider.indexAhead; } }




		Peek(num.quotient.stream_.slider_.factorial.Inverse_onInteger x)
		   :
			base(

			   x

			)

		{
			this._slider = x;

		}
		public Peek() : this(new num.quotient.stream_.slider_.factorial.Inverse_onInteger())
		{
		}

	}
}
