using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.op_.unary_.sqrt
{
	/// <summary>
	/// cache some results
	/// </summary>
	static public class _OfX
	{
		public static readonly double OfTwo = Math.Sqrt(2);

		public static readonly double OfThree = Math.Sqrt(3);

		public static readonly double OfFive = Math.Sqrt(5);

		public static readonly double OfSix = OfTwo*OfThree;

		public static readonly double OfSeven = Math.Sqrt(7);

		public static readonly double OfEight = 2* OfTwo;

		public static readonly double OfTen =  OfTwo * OfFive;


	}
}
