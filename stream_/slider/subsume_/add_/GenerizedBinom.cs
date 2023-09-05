using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.stream_.slider.subsumed_.add_
{
	public class GenerizedBinom
		: num.real.stream_.slider.Subsume_opDefault_add
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="addendInBasis">
		///	when the abs of this is lt 1, this converges to (1+ addend)^index
		/// </param>
		/// <param name="index"></param>
		public GenerizedBinom(RealI addendInBasis, RealI index) : base(new _generizedBinom.Term(addendInBasis,index))
		{
		}
	}
}
