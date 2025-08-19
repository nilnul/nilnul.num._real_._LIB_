using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._real.limit.sow;

namespace nilnul.num.real
{
	public class Singleton
		: nilnul.num.RealI
	{
		private nilnul.num._real.limit.cofinal.Singleton _cofinal;

		public nilnul.num._real.limit.cofinal.Singleton cofinal
		{
			get { return _cofinal; }
			set { _cofinal = value; }
		}

		public Singleton(
			nilnul.num._real.limit.cofinal.Singleton cofinal
		)
		{
			_cofinal = cofinal;
		}

		public Singleton(
			nilnul.num._real.LimitI limit
		):this(
			new num._real.limit.cofinal.Singleton(limit)
		)
		{

		}

		public Singleton(
			nilnul.num._quotient.fraction.op.Simplify.Ed1 q
		)
			:this(
				new num._real.limit.cofinal.Singleton(q) 
				 )
		{

		}

		public ConfluentI confluent
		{
			get
			{
				return _cofinal;
				throw new NotImplementedException();
			}
		}
	}
}
