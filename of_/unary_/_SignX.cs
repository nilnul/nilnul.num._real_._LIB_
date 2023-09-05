namespace nilnul.num.real.op_.unary_
{

	static public class _SignX
	{
		/// <summary>
		/// when x=1, the returned is x;
		/// when x=-1, the returned is x;
		/// </summary>
		/// <remarks>
		/// when x==0, the returned is x;
		///
		/// </remarks>
		/// <param name="x"></param>
		/// <returns></returns>
		static public int Sign(double x) {
			return x == 0 ? 0 : x > 0 ? 1 : -1;
		}

	}





}
