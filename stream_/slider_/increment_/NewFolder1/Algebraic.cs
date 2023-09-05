using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R = nilnul.num.RealI;

namespace nilnul.num.real.stream_.slider_
{
	/// <summary>
	/// 
	/// </summary>
	/// alias:
	///		arithmatic
	///		algebra;
	///		triangular
	///		
	[Obsolete(nameof(IIncrement) + "shall be used;")]
	public class Algebraic:nilnul.num.real.stream_.SliderA
		//		,
		//nilnul.num.real.stream_._func_.OnNumeroI

	{
		private R _accumulated;

		public override R current
		{
			get { return _accumulated; }
			//set { _current = value; }
		}

		private R _augend;

		public R augend
		{
			get { return _augend; }
			set { _augend = value; }
		}


		public Algebraic(R head, R rate)
		{
			_accumulated = head;
			_augend = rate;
		}

		public Algebraic(R head, int v):this(head, (num.Real)v)
		{
			
		}

		public override void moveNext()
		{
			_accumulated = nilnul.num.real.op_.binary_.Add.Singleton.op(_accumulated, _augend);
		}

		/// <summary>
		/// a constant stream + std arithmetic stream
		/// </summary>
		/// <param name="head"></param>
		/// <param name="rate"></param>
		/// <param name="numero"></param>
		/// <returns></returns>

		static public R Term(R head, R rate, NumI1 numero)
		{
			return head.ToReal()+ arithmetic_.Std.Term( rate,numero);
		}
	}
}
