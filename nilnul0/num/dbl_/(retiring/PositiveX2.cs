using nilnul.bit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real.double_
{

	static public class PositiveX2
	{
		static public bool Positive(double x)
		{
			return x > 0;
		}

		public partial class Adjective
			: nilnul.bit.AdjectiveI2<double>
		{

			public bool be(double obj)
			{
				return PositiveX.Positive(obj);

				throw new NotImplementedException();
			}



		}



		/// <summary>
		/// by func expression
		/// </summary>
		public partial class Adjective_FroFunc
			:
			nilnul.bit.Adjective_FroFunc<double>
		{


			public Adjective_FroFunc()
				: base(PositiveX.Positive)
			{
			}



		}

		public class Assertion
			:nilnul.bit.AssertionFroAdjSingleton<double,Adjective>
		{

			
		}

		public partial class Double
			: nilnul.bit.AdjectiveType<double, Positive>
		{

			public Double(double x)
				: base(x)
			{
			}
			//static public nilnul.bit.AssertDeny_byAdjSingleton<double, Positive> AssertDeny = AssertDeny_byAdjSingleton<double, Positive>.Instance;

		}
	}
}