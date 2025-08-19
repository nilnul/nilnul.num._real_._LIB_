using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.num.rational.be;
using nilnul.num.rational.bound.pair.be;
using N = nilnul.num.natural.Natural_bigInteger;
using N1 = nilnul._num.bigint.op.Abs.Ed;

using Q = nilnul.num.rational.Rational_InheritFraction2;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using R = nilnul.num.real.RealI_posConverge2NonEmpty;
using System.Numerics;
using nilnul.num.real;
using nilnul.num.quotient.be;
using nilnul.num.quotient.ext.border.duo.be;

namespace nilnul.num._real.squeeze.op.sqrt.call
{


	/// <summary>
	/// 
	/// </summary>
	/// <remarks>
	/// Naming: N is too short. 
	/// </remarks>
	/// 
	[Obsolete()]
	public class OfN
		:
		nilnul.num._real.SqueezeI
	{


		private N1 _arg;

		public N1 arg
		{
			get { return _arg; }
			set { _arg = value; }
		}

		private Q1 _lower;

		public Q1 lower
		{
			get { return _lower; }
			set { _lower = value; }
		}

		private Q1 _upper;

		public Q1 upper
		{
			get { return _upper; }
			set { _upper = value; }
		}
		public OfN(int arg) : this(new N1(arg))
		{
		}

		public OfN(N1 arg)
		{
			_arg = arg;

			_ini();

		}
		public OfN(BigInteger arg)
			: this(new N1(arg))
		{


		}

		public void _ini()
		{

			var interval = nilnul.num.natural.op.SqrtX._Eval_ofNatural_retInterval(_arg);

			_lower = interval.Item1;
			_upper = interval.Item2;


		}






		public nilnul.num.quotient.ext.border.duo.be.Bound.Asserted bound
		{
			get
			{
				if (_lower != _upper)
				{
					return nilnul.num.quotient.ext.border.duo.be.Bound.Asserted.CreateOpen(_lower, _upper);
				}
				else
				{
					return nilnul.num.quotient.ext.border.duo.be.Bound.Asserted.CreateSingleton(_lower);
				}



				throw new NotImplementedException();
			}
		}

		public void squeeze_lessThan1()
		{
			///for the init has already made it converge less than 1.
			return;

			//converge(1);

		}

		public void squeeze(int i)
		{
			squeeze(new quotient.be.Positive.Asserted(i));
		}

	

		public void squeeze(quotient.be.Positive.Asserted diameter)
		{
			if (bound.notSpanLessThan(diameter))
			{
				var middle = (_lower + _upper) / 2;

				var middleSquare = middle * middle;
				var argSquare = _arg * arg;
				var compareResult = nilnul.num.quotient.Le.Singleton.Compare(middleSquare, argSquare);

				if (compareResult == 0)
				{
					_lower = middle;
					_upper = middle;
				}
				else
				if (compareResult < 0)
				{
					_lower = middle;


				}
				else
				{
					_upper = middle;
				}

			}
			return;


			throw new NotImplementedException();
		}

		
	}

}
