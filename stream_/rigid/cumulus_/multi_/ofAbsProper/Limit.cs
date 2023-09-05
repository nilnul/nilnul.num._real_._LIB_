using nilnul.num.quotient.bound_;
using nilnul.num.quotient_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.stream_.rigid.cumulus_.multi_.ofAbsProper
{
	/// <summary>
	/// 1/(1-x)
	/// </summary>
	public class Limit
		: nilnul.obj.Box<OfAbsProper>
		,
		nilnul.num.RealI
	{
		private nilnul.num.RealI _real;

		public nilnul.num.RealI real
		{
			get { return _real; }
			set { _real = value; }
		}

		public Limit(OfAbsProper val) : base(val)
		{
			_real = (1) / (1 - this.boxed.item.ToReal());
		}

		public Closed current => _real.current;

		public void squeeze(Positive1 diameter)
		{
			_real.squeeze(diameter);
			//throw new NotImplementedException();
		}
	}
}
