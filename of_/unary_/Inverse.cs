namespace nilnul.num.real.of_.unary_
{
	public class Inverse
		:
		num.real.of_.Unary4dblI
	{
		public double op(double par)
		{
			return 1 / par;
			//throw new System.NotImplementedException();
		}


		static public Inverse Unison
		{
			get
			{
				return nilnul._obj.typ_._UnisonX<Inverse>.Unison;
			}
		}


	}


}
