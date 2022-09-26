using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._real;
using Q = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using Squee = nilnul.num._real.squeeze.Quotient;
using nilnul.num.real._quotient;

namespace nilnul.num._real.approach
{
	[Obsolete(nameof(generator_.Quotient))]
	public class Quotient
		
		: num._real.ApproachI

	{
		private Q _q;
		public Q q
		{
			get { return _q; }
			set {
				
					_q = value;

					_squeeze = new Squee(q);


			}
		}

		private Squee _squeeze;
		public Squee squeeze
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
