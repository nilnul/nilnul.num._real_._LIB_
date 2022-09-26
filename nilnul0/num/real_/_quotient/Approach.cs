using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._real;
using Q = nilnul.num._quotient.fraction.op.Simplify.Ed1;

namespace nilnul.num.real._quotient
{
	public class Quotient : num._real.ApproachI
	{
		private Q _q;
		public Q q
		{
			get { return _q; }
			set {
				
					_q = value;

					_squeeze = new Squeeze(q);


			}
		}

		private Squeeze _squeeze;
		public Squeeze squeeze
		{
			get { return _squeeze; }
			
		}

		public Quotient(Q q)
		{
			this.q = q; 

		}

		public SqueezeI converge()
		{
			return _squeeze;
			
			throw new NotImplementedException();
		}

		public override string ToString()
		{
			return _q.ToString();
		}
	}
}
