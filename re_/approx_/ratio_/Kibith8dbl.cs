namespace nilnul.num.real.re_.approx_.ratio_
{
	/// <summary>
	/// decimal 0.001, as in millimeter
	/// </summary>
	/// alias:
	///		per kibi
	///		kibi-th
	///	not kiloth, which means 1/1000, not 1/1024
	public class Kibith8dbl 
		:
		re_.approx_.Ratio8dbl
	{

		public Kibith8dbl() : base(
			//0b0.001

			1d/1024d
		)
		{
		}

		static public Kibith8dbl Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Kibith8dbl>.Instance;
			}
		}



	}


}
