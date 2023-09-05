namespace nilnul.num.real.ext.re_
{
	public abstract class AssumeExts4DblA : Re4dblA, _assumesExt_.AssumeExts4DblI
	{

		public abstract bool _re_01ext(double x, double y);
		public override bool re(Ext4dblI a, Ext4dblI b)
		{
			return _re_01ext(a.errable, b.errable);
		}

	}





}
