using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.str.to_.scalar_
{
	/// <summary>
	/// distance
	/// </summary>
	 public class Norm
		:
		Scalar4dblA
		,
		to_.Scalar4dblI
		,
		to_.ScalarI
		
	{
	

		public override double op(IEnumerable<double> str)
		{
			return Math.Sqrt( to_.scalar_.SqSum.Singleton.op(str) );
		}

		public  double op(params double[] str)
		{
			return Math.Sqrt( to_.scalar_.SqSum.Singleton.op(str) );
		}
		public  double op((double,double) str)
		{
			return Math.Sqrt( to_.scalar_.SqSum.Singleton.op(str) );
		}

		public  double op((double,double,double) str)
		{
			return Math.Sqrt( to_.scalar_.SqSum.Singleton.op(str) );
		}

		public  double op((double,double,double,double) str)
		{
			return Math.Sqrt( to_.scalar_.SqSum.Singleton.op(str) );
		}
		public  double op((double,double,double,double,double) str)
		{
			return Math.Sqrt( to_.scalar_.SqSum.Singleton.op(str) );
		}

		public RealI to(IEnumerable<RealI> src)
		{
			return nilnul.num.real.op_.unary_.Sqrt.Singleton.op( SqSum.Singleton.to(src)
			);

		}

		static public Norm Lazy
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<Norm>.Instance;
			}
		}
		static public Norm Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Norm>.Instance;
			}
		}


	}
}
