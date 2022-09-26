using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul;

namespace nilnul.num._real.limit.duo.be
{
	/// <summary>
	/// if the two sequnce 
	/// </summary>
	public class InConfluent
	{
		[MayPerpetual]
		static public bool Eval(real.RealI_posConverge2NonEmpty x, real.RealI_posConverge2NonEmpty y) {

			//#warning
			return !Confluent.Eval(x, y);
		}

	}
}
