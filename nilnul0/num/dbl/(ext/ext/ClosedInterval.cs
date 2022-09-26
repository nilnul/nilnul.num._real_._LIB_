using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.double_
{
	public partial class CloseInterval
		:nilnul.order.total.finite.CloseInterval<double,LessThanOrEqualTo>
	{


		public CloseInterval(double a,double b)
			:base(a,b)
		{
		}



		public class Unit
			:CloseInterval
		{

			static public bool ContainsValue(double x) {
				return Instance.contains(x);
			}


			static public void AssertContains(double x) {
				nilnul.obj.AssertX.True(ContainsValue(x));
			}


			public Unit()
				:base(0,1)
			{
			}

			static public Unit Instance = SingletonByDefaultNew<Unit>.Instance;
			static public Unit Singleton = SingletonByDefaultNew<Unit>.Instance;

			static public nilnul.collection.set.Assertion<double, Unit> assertion = new collection.set.Assertion<double, Unit>();

			public class Contains
				:nilnul.bit.Be<double>
			{
				public Contains()
					:base(Singleton.contains)
				{

				}

				public class Asserted :
					nilnul.bit.be.Asserted<double,Contains>
				{

					public Asserted(double val)
						:base(val)
					{

					}


				}

			}

			
		}

	
	

					

	}
}
