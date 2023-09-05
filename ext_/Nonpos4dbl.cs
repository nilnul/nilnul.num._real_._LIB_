using nilnul.num.real.ext.be_.pos.vow;
using nilnul.obj.vow._ee_;

namespace nilnul.num.real.ext_
{
	public class Nonpos4dbl
		: real.ext.be_.nonpos.vow.Ee4dbl
		,
		Nonpos4dblI
	{
		public Nonpos4dbl(in Ext4dblI val) : base(val)
		{
		}

		public Nonpos4dbl(Ext4dblI val) : base(val)
		{
		}

		public Nonpos4dbl(Ext4dbl val) : base(val)
		{
		}

		public Nonpos4dbl(double x) : base(x)
		{
		}

		public double errable => eeByRef.errable;

		
	}
}
