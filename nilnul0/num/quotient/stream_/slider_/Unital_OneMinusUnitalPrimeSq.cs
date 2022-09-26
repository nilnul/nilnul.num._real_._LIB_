using nilnul.num_.plural_.prime.stream_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.stream_.slider_
{
	/// <summary>
	/// 1  / (1- p^-2)
	///		,
	///			for all prime p
	/// </summary>
	public class Unital_OneMinusUnitalPrimeSq :
		nilnul.obj.Box1<
			nilnul.num_.plural_.prime.stream_.Exhaustive
		>
		,
		num.quotient.stream_.SliderI1
	{
		public Unital_OneMinusUnitalPrimeSq(Exhaustive val) : base(val)
		{
		}

		public Quotient1 current => 1/boxed.;

		public void moveNext()
		{
			throw new NotImplementedException();
		}

		public Quotient1 next()
		{
			throw new NotImplementedException();
		}
	}
}
