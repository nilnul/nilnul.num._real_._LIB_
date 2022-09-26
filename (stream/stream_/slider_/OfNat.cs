using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.stream_.slider_
{
	/// <summary>
	/// map N to R
	/// </summary>
	public class OfNat
		:
		
		nilnul.num.real.stream_.SliderA
	{

		private nilnul.num.stream_.slider_.Nat _nat=new num.stream_.slider_.Nat();

		public nilnul.num.stream_.slider_.Nat nat
		{
			get { return _nat; }
			//set { _nat = value; }
		}

		private Func<nilnul.Num1, nilnul.num.RealI> _map;

		public Func<nilnul.Num1, nilnul.num.RealI> map
		{
			get { return _map; }
			set { _map = value; }
		}
		public OfNat(Func<nilnul.Num1, nilnul.num.RealI> map)
		{
			_map = map;
		}

		public override RealI current => _map(_nat.current);

		public override void moveNext()
		{
			_nat.moveNext();
		}
	}
}
