using nilnul.num.real.ext.be_.pos.vow;

namespace nilnul.num.real.ext_
{
	public class Negative4dbl
		: real.ext.be_.neg.vow.Ee4dbl
		,
		Negative4dblI
	{
		public Negative4dbl(in Ext4dblI val) : base(val)
		{
		}

		public Negative4dbl(Ext4dblI val) : base(val)
		{
		}

		public Negative4dbl(Ext4dbl val) : base(val)
		{
		}

		public Negative4dbl(double x) : base(x)
		{
		}

		public double errable => eeByRef.errable;

		public ext.be_.neg.vow.Ee4dbl vowee => this;
	}
}
