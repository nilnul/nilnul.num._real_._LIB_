using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R = nilnul.num.RealI;

namespace nilnul.num.real
{
	/// <summary>
	/// a contain is a tuple: real and (cauchy list). containS is a collection of such contain_s.
	/// </summary>

	public class KnownCauchies
		:Dictionary<num.RealI_blank,num._real.limit.List>///note here the eqOfReal is Object.referenceEquals
	{

		//public class ContainCauchy
		//{
		//	private RealI _real;

		//	public RealI real
		//	{
		//		get { return _real; }
		//		set { _real = value; }
		//	}

		//	private num._real.cauchy.List _list;

		//	public num._real.cauchy.List list
		//	{
		//		get { return _list; }
		//		set { _list = value; }
		//	}


		//}

		static public KnownCauchies Static = new KnownCauchies();



	}

	static public class KnownCauchiesX
	{

		static public num._real.limit.List KnowCauchies(this R x) {
			///todo
			/// 

			return KnownCauchies.Static[x];

			throw new NotImplementedException("check in the db and return the list.");
		}
	}

}
