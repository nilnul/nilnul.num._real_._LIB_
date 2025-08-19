using nilnul.num.real.be_;

namespace nilnul.num.real.vec.be_
{
	public class Unnil8dble
		:
		nilnul.obj.Box_ofIn<nilnul.num.real.be_.Insignificant4dbl>
	{
		public Unnil8dble(in Insignificant4dbl val) : base(val)
		{
		}

		public Unnil8dble(Insignificant4dbl x) : base(x)
		{
		}

		public Unnil8dble(double x):this( new Insignificant4dbl(x))
		{
				
		}
		public Unnil8dble():this(
			nilnul.num.real_.nonneg.be_.Small4dbl.DEFAULTED
		)
		{
				
		}


		static public Unnil8dble Unison
		{
			get
			{
				return nilnul._obj.typ_._UnisonX<Unnil8dble>.Unison;
			}
		}

	}

}
