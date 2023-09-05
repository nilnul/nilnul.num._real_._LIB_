namespace nilnul.num.real.ext
{
	public abstract class Re4dblA : Re4dblI
		,
		_re_.OfDblsI
	{
		public abstract bool re(Ext4dblI a, Ext4dblI b);
		public  bool re(Ext4dbl a, Ext4dbl b) {
			return re(( Ext4dblI)a,(Ext4dblI)b);
		}
		public  bool re(double a, double b) {
			return re(new Ext4dbl(a),new Ext4dbl(b));
		}
	}





}
