using nilnul.num._real;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num._real.limit.all
{
	/// <summary>
	/// an equivalence partition; so no two subset is joint, in the sense of Object.referenceEquals. 
	/// </summary>
	public class KnownConfluent:HashSet<Set>
	{

		static public KnownConfluent Static = new KnownConfluent();


	}


	static public class KnownConfluentX
	{
		static public bool KnownEq(LimitI x,LimitI y) {


			throw new NotImplementedException("check whether they are in the same cluster");
		}

		
	}



}
