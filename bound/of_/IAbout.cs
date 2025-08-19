namespace nilnul.num.real.bound.of_
{
	/// <summary>
	/// given a real number: a,
	/// , x is in (0.5 * a, 1.5* a)
	/// , where 1.5a - 0.5a = a, meaning that the variation cannot exceed given number;
	/// around; approximate; near; close; about; proximity; vicinity; neighborhood;
	/// </summary>
	/// vs:
	///		neighbor, which is a centered bound that is symmetric;
	/// 
	public interface IAbout { }

	static public class _AboutX
	{
		/// <summary>
		/// eg:
		///		about 1500 is (750, 2250 )
		/// </summary>
		/// <param name="x"></param>
		/// <returns>
		/// when x is 0, the returned as unclose bound is empty; in that case, no real but 0 is about 0.
		/// </returns>
		static public (double lower, double upper) _Open_0unneg(double x) {
			return (x*0.5, x*1.5);
		}
		static public (double lower, double upper) _Open(double x) {
			if (x<0)
			{
				 var co= _Open_0unneg(-x);
				return (-co.upper,-co.lower);
			}
			return _Open_0unneg (x);
		}


	}


}
