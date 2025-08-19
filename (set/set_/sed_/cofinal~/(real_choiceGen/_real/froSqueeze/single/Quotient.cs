using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._real.limit.sow;
using Q = nilnul.num._quotient.fraction.op.Simplify.Ed1;

namespace nilnul.num.real.single
{
	/// <summary>
	/// the instance of this type is a cluster of all cauchies that converge to the same number: the quotient field. if a cauchy converges to this quotient, the cauchy belongs to the instance of this class.
	/// So this type is the cluster generator. this type can generate many such clusters.
	/// </summary>
	public class Quotient:

		num.RealI
	{
		private Q _quotient;

		public Q quotient
		{
			get { return _quotient; }
			set { _quotient = value; }
		}

		public Quotient(Q q)
		{
			_quotient = q;
			_cofinal=new nilnul.num._real.limit.cofinal.single.Quotient(_quotient);
		}



		private nilnul.num._real.limit.cofinal.single.Quotient _cofinal;

		public nilnul.num._real.limit.cofinal.single.Quotient cofinal
		{
			get { return _cofinal; }
			private set { _cofinal = value; }
		}

		public ConfluentI confluent
		{
			get
			{
				return _cofinal;
				throw new NotImplementedException();
			}
		}

		public nilnul.num._real.LimitI limit {
			get {
				return _cofinal.limit;
			}
		}

		public override string ToString()
		{
			return _quotient.ToString();
		}


	}


}
