using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.stream_.convergent
{
	public interface CoI : nilnul.obj.CoI2<stream_.ConvergentI> {

	}
	public class Co : nilnul.obj.Co<stream_.ConvergentI>, CoI
	{
		public Co(Tuple<ConvergentI, ConvergentI> tuple) : base(tuple)
		{
		}

		public Co((ConvergentI, ConvergentI) valTuple) : base(valTuple)
		{
		}

		public Co(ConvergentI item1, ConvergentI item2) : base(item1, item2)
		{
		}
	}
}
