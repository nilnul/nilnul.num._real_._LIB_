using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.rational.float_;
using nilnul.num.rational;
using nilnul.num.rational.float_.based;
using nilnul.num.rational.be;
using nilnul.num.rational.bound.pair.be;

namespace nilnul.num.real.op.sqrt.call
{
	[Obsolete(null,true)]
	public partial class OfTau
		: RealI4
	{
        public Nonempty.Asserted interval
        {
            get
            {

                throw new NotImplementedException();
            }
        }

        public void converge(Positive.Asserted diameter)
        {
            throw new NotImplementedException();
        }

        public class Singleton:
			nilnul.SingletonByDefaultNew<SqrtOfTwo>
		{
			
		}

		

    }
}
