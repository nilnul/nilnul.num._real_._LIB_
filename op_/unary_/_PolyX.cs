using N = nilnul.Num1;
using R = nilnul.num.RealI;//.R;//.RealI;

namespace nilnul.num.real.op_.unary_
{
	static public class _PolyX
	{
		static public R RealI_baseUnsureQuotient(R base_, nilnul.num_.Plural1 _index__plural)
		{


			var half = nilnul.num.op_.unary_.Half1.Singleton.op(_index__plural);  //.natural.op.DivideX.Half(_index);

			var anotherHalf = _index__plural.en - half.en;


			var powedToHalf = op_.unary_.Square.Lazy.op(
				RealI_baseUnsureQuotient_assumeSupPositive(base_, half)
			);

			if (anotherHalf > half)
			{
				return
					op_.binary_.Multi.Singleton.op(powedToHalf, base_);

			}
			else
			{
				return powedToHalf;

			}
			#region the following doesnot using same objects as many as enough; and hece doesnot reuse the convergeed result of each object.
			/*
			///anotherHalf >= half

			if (anotherHalf == 1)//halft ==1, as index is assumed plural
			{

				return op_.unary_.Square.Lazy.op(base_);

			}

			///now: maybe:
			///		half be one, another half is 2


			return op_.binary_.Multi.Singleton.op(
				 RealI_baseUnsureQuotient_assumeSupPositive(base_, half)
				,
				RealI_baseUnsureQuotient_assumeIndexPlural(base_, new N(anotherHalf))
			);

	*/

			#endregion
		}
		static public R RealI_baseUnsureQuotient_assumeIndexPlural(R base_, N sup)
		{

			return RealI_baseUnsureQuotient(base_, new nilnul.num_.Plural1(sup));

		}


		static public R RealI_baseUnsureQuotient_assumeSupPositive(R base_, N _index)
		{

			if (_index == 1)
			{
				return base_;
			}

			return RealI_baseUnsureQuotient_assumeIndexPlural(base_, _index);

		}

		static public R RealI_baseUnsureQuotient(R base_, nilnul.num_.Positive1 _index)
		{

			if (_index == 1)
			{
				return base_;
			}

			return RealI_baseUnsureQuotient_assumeIndexPlural(base_, _index);

		}



		static public R RealI_baseUnsureQuotient(R base_, N _index)
		{
			if (_index == 0)
			{
				return num.real_.Quotient.CreateOne();
			}

			return RealI_baseUnsureQuotient_assumeSupPositive(base_, _index);

		}

		static public Real Real(nilnul.num.Quotient1 base_, N _index__plural)
		{
			return nilnul.num.quotient.op_.unary_.Poly.Eval(base_, _index__plural);
		}
		static public R RealI_assumeSupPositive(R base_, N sup)
		{
			if (nilnul.num.real.be_.Quotient.Singleton.be(base_))
			{
				return Real(base_.current.lower.mark, sup);
			}
			return RealI_baseUnsureQuotient_assumeSupPositive(base_, sup);
		}

		static public R RealI(R base_, nilnul.num_.Positive1 sup)
		{
			if (nilnul.num.real.be_.Quotient.Singleton.be(base_))
			{
				return Real(base_.current.lower.mark, sup);
			}
			return RealI_baseUnsureQuotient(base_, sup);
		}


		static public R RealI(R base_, N sup)
		{
			if (nilnul.num.real.be_.Quotient.Singleton.be(base_))
			{
				return Real(base_.current.lower.mark, sup);
			}
			return RealI_baseUnsureQuotient(base_, sup);
		}

		static public R RealI(R base_, NumI1 sup)
		{
			if (nilnul.num.real.be_.Quotient.Singleton.be(base_))
			{
				return Real(base_.current.lower.mark, new Num1( sup.toBigint() ));
			}
			return RealI_baseUnsureQuotient(base_,new Num1( sup.toBigint()) );
		}


		static public R RealI(R base_, int sup)
		{
			return RealI(base_, new N(sup));
		}



	}
}
