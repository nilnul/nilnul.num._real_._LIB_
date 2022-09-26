using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.ieeeF.be_
{
	public class NonNeg : BeI
	{
		public bool be(float obj)
		{
			return obj >= 0;
			//	throw new NotImplementedException();
		}

		public class En : be.En_beDefaultable<NonNeg>
		{
			public En(float val) : base(val)
			{
			}

			static public explicit operator En(float f)
			{
				return new En(f);
			}
			static public implicit operator float(En f)
			{
				return f.avowed;
			}

			static public En CreateByAbs(float f) {
				return new En(Math.Abs(f));
			}

		}
	}
}
