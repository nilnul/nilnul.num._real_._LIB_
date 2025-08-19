namespace nilnul.num.real.op_.unary_
{

	/// <summary>
	/// eg:
	///		for computer, we often use 2's complement;
	/// </summary>
	public class Complement4dbl :
		nilnul.obj.Box_ofIn<double>
		,
		Unary4dblI
		
	{
		public Complement4dbl(in double val) : base(val)
		{
		}

		public Complement4dbl(double x) : base(x)
		{
		}
		/// <summary>
		/// for statistics, the boxed is one;
		/// </summary>
		public Complement4dbl():this(1)
		{

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="par">can be outside of [0,1] </param>
		/// <returns></returns>
		public double op(double par)
		{
			return boxed - par;
			//throw new NotImplementedException();
		}


		static public Complement4dbl Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Complement4dbl>.Instance;
			}
		}

	}
}
