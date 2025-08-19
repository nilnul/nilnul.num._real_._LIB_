namespace nilnul.num.real.re_.approx_.ratio_
{
	/// <summary>
	/// decimal 0.001, as in millimeter
	/// </summary>
	public class Milli8dbl 
		:
		re_.approx_.Ratio8dbl
	{

		public Milli8dbl() : base(0.001)
		{
		}

		static public Milli8dbl Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Milli8dbl>.Instance;
			}
		}



	}


}
