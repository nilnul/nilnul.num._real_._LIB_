using nilnul.num.real.ext.be_.pos.vow;

namespace nilnul.num.real.ext_
{
	public class Positive4dbl
		: real.ext.be_.pos.vow.Ee4dbl
		,
		Positive4dblI
	{
		public Positive4dbl(in Ext4dblI val) : base(val)
		{
		}

		public Positive4dbl(Ext4dblI val) : base(val)
		{
		}

		public Positive4dbl(Ext4dbl val) : base(val)
		{
		}

		public Positive4dbl(double x) : base(x)
		{
		}

		public double errable => eeByRef.errable;

		public Ee4dbl vowee => this;
	}
}
