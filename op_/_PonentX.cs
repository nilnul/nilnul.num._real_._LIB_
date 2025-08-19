using N = nilnul.Num1;
using R = nilnul.num.RealI_onQuotient;//.R;//.RealI;

namespace nilnul.num.real.op_
{
	/// <summary>
	/// 
	/// </summary>
	/// alias:
	///		ponent;
	///		poly
	static public class _PonentX
	{
		static public R _AsInterface_0asNonquotient(R base_, nilnul.num_.Plural1 _index__plural)
		{


			var half = nilnul.num.op_.unary_.Half1.Singleton.op(_index__plural);  //.natural.op.DivideX.Half(_index);

			var anotherHalf = _index__plural.en - half.en;


			var powedToHalf = op_._SquareX.Op(
				_AsInterface_0asNonquotient_1positive(base_, half)
			);

			if (anotherHalf > half)
			{
				return
					of_.binary_.Multi.Singleton.op(powedToHalf, base_);

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
		static public R _AsInterface_0asNonquotient_1plural(R base_, N sup)
		{

			return _AsInterface_0asNonquotient(base_, new nilnul.num_.Plural1(sup));

		}


		static public R _AsInterface_0asNonquotient_1positive(R base_, N _index)
		{

			if (_index == 1)
			{
				return base_;
			}

			return _AsInterface_0asNonquotient_1plural(base_, _index);

		}

		static public R _AsInterface_0asNonquotient(R base_, nilnul.num_.Positive1 _index)
		{

			if (_index == 1)
			{
				return base_;
			}

			return _AsInterface_0asNonquotient_1plural(base_, _index);

		}



		static public R _AsInterface_0asNonquotient(R base_, N _index)
		{
			if (_index == 0)
			{
				return num.real_.Quotient_denomNonnil.CreateOne();
			}

			return _AsInterface_0asNonquotient_1positive(base_, _index);

		}

		static public nilnul.num.real_.Quotient_denomNonnil AsReal(nilnul.num.quotient_.DenomNonnil base_, N _index__plural)
		{
			return  nilnul.num.quotient.op_._PonentX._Quotient_1natural(base_, _index__plural);
		}
		static public R _AsInterface_1positive(R base_, N sup)
		{
			if (nilnul.num.real.be_.Quotient.Singleton.be(base_))
			{
				return  AsReal(base_.current.begin, sup);
			}
			return _AsInterface_0asNonquotient_1positive(base_, sup);
		}

		static public R AsInterface(R base_, nilnul.num_.Positive1 sup)
		{
			if (nilnul.num.real.be_.Quotient.Singleton.be(base_))
			{
				return AsReal(base_.current.begin, sup);
			}
			return _AsInterface_0asNonquotient(base_, sup);
		}


		static public R AsInterface(R base_, N sup)
		{
			if (nilnul.num.real.be_.Quotient.Singleton.be(base_))
			{
				return AsReal(base_.current.begin, sup);
			}
			return _AsInterface_0asNonquotient(base_, sup);
		}

		static public R AsInterface(R base_, NumI1 sup)
		{
			if (nilnul.num.real.be_.Quotient.Singleton.be(base_))
			{
				return AsReal(base_.current.begin, new Num1( sup.toBigint() ));
			}
			return _AsInterface_0asNonquotient(base_,new Num1( sup.toBigint()) );
		}


		static public R AsInterface(R base_, int sup)
		{
			return AsInterface(base_, new N(sup));
		}



	}
}
