using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;
using System.Numerics;
//using nilnul.num.quotient.all;
using Q1 = nilnul.num.Quotient1;

namespace nilnul.num.real_._tau._cumulus
{
	/// <summary>
	 
	/// 
	/// , {k, 0, Infinity}
	/// </summary>
	public class Slider
		:
		nilnul.num.quotient.stream_.SliderA1
		//nilnul.num.quotient.SliderI2
	{


		private BigInteger _8kPlus2_ = 2;
		private BigInteger _8kPlus3_ = 3;
		private BigInteger _8kPlus4_ = 4;
		private BigInteger _8kPlus7_ = 7;


		private Q1 _coefficent =1 ; // 1/ 16^k


		public Q1 coefficent {
			get { return _coefficent; }
		}

		private Q1 _coefficentNext= nilnul.num.Quotient1.CreateUnit(16);

		public Q1 coefficientNext {
			get {
				return _coefficentNext;
			}
		}

		public override Q1 current
		{
			get
			{

				return _coefficent* (

					(8).QDiv(_8kPlus2_)
					+
					(4).QDiv(_8kPlus3_)
					+(4).QDiv( _8kPlus4_)
					- _8kPlus7_.Inverse()

				);

			}
		}

		

		public override void moveNext()
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
