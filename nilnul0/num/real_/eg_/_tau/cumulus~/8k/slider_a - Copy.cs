using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;
using System.Numerics;
using nilnul.num.quotient.all;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;

namespace nilnul.num._real.approach_.tau_._a
{
	/// <summary>
	/// 
	/// , {k, 0, Infinity}
	/// </summary>
	/// 
	[Obsolete()]
	public class Slider : nilnul.num.quotient.SliderI
	{


		private BigInteger _8kPlus2_ = 2;
		private BigInteger _8kPlus3_ = 3;
		private BigInteger _8kPlus4_ = 4;
		private BigInteger _8kPlus7_ = 7;


		private Q1 _coefficent =1 ; // 1/ 16^k


		public Q1 coefficent {
			get { return _coefficent; }
		}

		private Q1 _coefficentNext= nilnul.num.quotient.all.X.QDiv( (1) , (16) );

		public Q1 coefficientNext {
			get {
				return _coefficentNext;
			}
		}

		public Simplify.Ed1 current
		{
			get
			{

				return _coefficent* (

					nilnul.num.quotient.all.X.QDiv(
						(8),(_8kPlus2_)
					)
					+
					nilnul.num.quotient.all.X.QDiv(
						(4), (_8kPlus3_)
					)
					+
					nilnul.num.quotient.all.X.QDiv(
						(4), ( _8kPlus4_)
					)
					- 
					nilnul.num.quotient.all.X.Inverse(
						_8kPlus7_
					)

				);

			}
		}

		

		public void moveNext()
		{



			_coefficent = _coefficentNext;
			_coefficentNext /= 16;

			_8kPlus2_ += 8;
			_8kPlus3_ += 8;
			_8kPlus4_ += 8;
			_8kPlus7_ += 8;
		}
	}
}
