using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.of_.binary_
{
	/// <summary>
	/// x^2 + y^2
	/// </summary>
	public class Variance :
		of_.Binary4dblA
		,
		of_.Binary4dblI
	{


		public double of(double x, double y)
		{
			return x*x+y*y;
		}

		public double op(double x, double y)
		{
			return of(x,y);
		}

		public override double _op_01finite(double x, double y)
		{
			return x * x + y * y;
		}

		static public Variance Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Variance>.Instance;
			}
		}

	}

}
