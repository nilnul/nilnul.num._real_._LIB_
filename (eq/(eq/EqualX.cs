using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace nilnul.number.integer
{
	static public partial class EqualX
	{
		static public bool Equal(IntegerI a,IntegerI b)
		{
			return integer.Equal.Instance.eval(a, b);
		}
	}
}
