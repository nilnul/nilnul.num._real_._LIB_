using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace nilnul.realNumber
{
	public partial class Negate
		:UnaryOpI<RealI,RealI>

	{


		static private readonly Negate _Instance = new Negate();
		static public Negate Instance
		{
			get
			{
				return _Instance;
			}
		}
		private Negate()
		{
		}

				
		public override string ToString()
		{
			return "-";
		}

		static public RealI Call(ExprI<RealI> a) {
			return new NegateExpr(a);
		
		} 

		
		



	}

	static public partial class NegateX {
		static public RealI Negate(this ExprI<RealI> a) {
			return new NegateExpr(a);
		
		}
	}
}
