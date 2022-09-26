using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._real;
using Q = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using Squee = nilnul.num._real.squeeze.Quotient;
using nilnul.num.real._quotient;

namespace nilnul.num._real.approach.generator_
{
	public class Quotient
		
		: num._real.approach.GeneratorI

	{
		private Q _q;
		public Q q
		{
			get { return _q; }
			set {
				
					_q = value;

					_squeeze = new approach_.Quotient(q);


			}
		}

		private ApproachI1 _squeeze;
		public ApproachI1 squeeze
		{
			get { return _squeeze; }
			
		}

		public Quotient():this(0)
		{

		}

		public Quotient(Q q)
		{
			this.q = q; 

		}

		public ApproachI1 generate()
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
