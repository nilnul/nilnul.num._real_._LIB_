using nilnul.num.real.ext.be_.pos.vow;
using nilnul.obj.vow._ee_;

namespace nilnul.num.real.ext_
{
	public class Nonneg4dbl
		: real.ext.be_.nonneg.vow.Ee4dbl
		,
		Nonneg4dblI
	{
		public Nonneg4dbl(in Ext4dblI val) : base(val)
		{
		}

		public Nonneg4dbl(Ext4dblI val) : base(val)
		{
		}

		public Nonneg4dbl(Ext4dbl val) : base(val)
		{
		}

		public Nonneg4dbl(double x):this(new Ext4dbl(x) )
		{
			
		}

		public double errable => eeByRef.errable;

		
	}
}
