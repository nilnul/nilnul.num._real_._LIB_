using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.ext.of_.binary_
{
	/// <summary>
	/// the abs of difference;
	/// </summary>
	public class Distance :
		nilnul.num.real.ext.of_.binary_.EachAssumeExtA 
		
		,
		nilnul.num.real.ext.of_.Binary4dblI
	{

		public override double _op_01ext(double a, double b)
		{
			return Math.Abs( Minus.Singleton._op_01ext(a,b) );
		}

	


		static public Distance Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Distance>.Instance;
			}
		}

	}
}
