using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.integer.stream_.slider_.positive.factorial.inverse.subsume_
{
	/// <summary>
	/// 1/0! + 1/1! + 1/2! + ...;
	/// </summary>
	/// <remarks>
	/// the initial current index: 0;
	/// </remarks>
	public class Add
		: nilnul.num.quotient.stream_.slider.subsume_.Add<Inverse>
	{

		/// <summary>
		/// initially, this is 1;
		/// </summary>
		public BigInteger indexAhead { get { return base._slider.indexAhead; } }

		public BigInteger denominator { get { return _slider.denominator; } }

		public Add(Inverse slider) : base(slider)
		{
		}

	}
}
