using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.str.be_
{
	/// alias:
	///		unial
	///			
	///		one
	///			but [-1] is also unial.
	///		unit
	///			used by <see cref="obj._measure.IUnit"/>
	///		unitary
	///			reserved for complex matrix.
	///		unital
	///		unary
	///			used for <see cref="vec_.Uno4dbl"/>
	///
	public class Unial
		:
		num.real.str.Be4dblI
	{
		public bool be(IEnumerable<double> obj)
		{

			return num.real.re_.approx_.ByInjected.Singleton.re( str.to_.scalar_.SqSum.Singleton.op(obj) , 1 );
		}

		static public Unial Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Unial>.Instance;
			}
		}

	}
}
