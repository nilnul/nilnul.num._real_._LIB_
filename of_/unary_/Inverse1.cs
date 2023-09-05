namespace nilnul.num.real.op_.unary_
{
	public class Inverse
		:
		num.real.op_.Unary4dblI
	{
		public double op(double par)
		{
			return 1 / par;
			//throw new System.NotImplementedException();
		}


		static public Inverse Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Inverse>.Instance;
			}
		}

	}


}
