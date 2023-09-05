using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.solo.sqrt.call
{
   public partial class Tau :solo.op.Sqrt.Expr
    {
        public Tau()
            :base(real.Tau_posConverge2interval.GetPi())
        {

        }
    }
}
