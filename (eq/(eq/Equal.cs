using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace nilnul.number.integer
{
	public partial class Equal
	{

		static private readonly Equal _Instance = new Equal();
		static public Equal Instance
		{
			get
			{
				return _Instance;
			}
		}
		private Equal()
		{
		}

		public bool eval(Integer a, Integer b)
		{
			return a.bigInt==b.bigInt;


		}

		public bool eval(IntegerI a,IntegerI b)
		{
			if (a is Integer && b is Integer)
			{
				return eval(
					(Integer)a
					,
					(Integer)b
					);

			}
			else
			{
				throw new Exception();
			}
		}
				

	}
}
