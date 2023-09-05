namespace nilnul.num.real.op_.binary_
{
	public class KroneckerDelta
		: nilnul.num.real.of_.Binary4dblA
	{
		public override double _op_01finite(double x, double y)
		{
			return x == y ? 1 : 0;
		}


		static public KroneckerDelta Unison
		{
			get
			{
				return nilnul._obj.typ_._UnisonX<KroneckerDelta>.Unison;
			}
		}

	}
}
