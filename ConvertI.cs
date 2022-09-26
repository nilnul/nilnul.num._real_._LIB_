using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real
{
	public interface ConvertI:
		nilnul.obj.ConvertI1< nilnul.num.RealI>
	{
	}

	public abstract class ConvertA : ConvertI
	{

		public abstract RealI convert(Real arg );
		public RealI convert(RealI arg) {
			return convert(new Real(arg));
		}
	}
}
