using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;
using nilnul.num.quotient.radix;
using R = nilnul.num.RealI;


namespace nilnul.num.real.bound_
{
	public class Neighbor
	{
		private R _center;

		public R center
		{
			get { return _center; }
			set { _center = value; }
		}
		private num.real.be_.positive.vow.En _radius;

		public num.real.be_.positive.vow.En radius
		{
			get { return _radius; }
			set { _radius = value; }
		}


		public Neighbor(
			R center,
			be_.positive.vow.En radius
		)
		{
			_center = center;
			_radius = radius;

		}


		public Neighbor(num.quotient_.radix_.Dec1 avg_q, num.quotient_.radix_.Dec1 radius_q)
			:this(
				new nilnul.num.real_.Quotient(avg_q)
				 ,
				new  be_.positive.vow.En (
					new nilnul.num.real_.Quotient(
						radius_q
					)
				) 
				)
		{
			
		}
		public Neighbor(
			R center,
			real_.PositiveI radius
		):this(center, radius.real)
		{
			

		}

		public Neighbor(
			Real center,
			real_.PositiveI radius
		):this((RealI)center, radius.real)
		{
			

		}

		public Neighbor(real_.PositiveI radius):this(  0,radius)
		{

		}

		public Bound toOpenRange() {
			return Bound.CreateOpen(
				nilnul.num.real.op_.binary_.Minus.Singleton.op(_center, _radius.en)
				,
				nilnul.num.real.op_.binary_.Add.Singleton.op(_center, _radius.en)

			);
		}

		public bool contains(R x) {
			return toOpenRange().contains(x);
		}
		public bool contains(Quotient1 ed1)
		{
			return contains( new nilnul.num.real_.Quotient(ed1) as R);
			//throw new NotImplementedException();
		}

		

		public override string ToString()
		{
#if DEBUG
			return $"{ nilnul.num.real._PhraseX.Phrase( _center )}∓{  nilnul.num.real._PhraseX.Phrase( _radius.en)}";
#else
			return $"{_center}∓{_radius}";

#endif
		}

	}
}
