using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using R = System.Double;


namespace nilnul.num.real.ext
{
	public class Border4dbl
		:
		nilnul.obj.Border<Ext4dblI>
		, Border4dblI
	{
		public Border4dbl(bool openFalseCloseTrue, Ext4dblI mark) : base(openFalseCloseTrue, mark)
		{
		}
		public Border4dbl(bool openFalseCloseTrue, Ext4dbl mark) : base(openFalseCloseTrue, mark)
		{
		}


		public Border4dbl(bool closed, double v1):this(closed, new Ext4dbl(v1))
		{
		}

		static public Border4dbl operator -(Border4dbl x) {
			return new Border4dbl(x.openFalseCloseTrue, -x.mark.ToImpl());
		}

		static public Border4dbl CreateClose(Ext4dblI x) {
			return new Border4dbl(true, x);
		}


		static public Border4dbl CreateClose(Ext4dbl x) {
			return new Border4dbl(true, x);
		}



		static public Border4dbl CreateOpen(Ext4dblI x) {
			return new Border4dbl(false, x);
		}

		static public Border4dbl CreateOpen(Ext4dbl x) {
			return new Border4dbl(false, x);
		}


		public static Border4dbl CreateClose(R lower)
		{
			return CreateClose( new nilnul.num.real.ext_.Finite4dbl(lower).ToImpl());
			//throw new NotImplementedException();
		}

		public static Border4dbl CreateOpen(R lower)
		{
			return CreateOpen( new nilnul.num.real.ext_.Finite4dbl(lower).ToImpl());
			//throw new NotImplementedException();
		}


	}
}
