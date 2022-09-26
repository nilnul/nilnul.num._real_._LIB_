
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using nilnul.num.quotient;
using nilnul.num.quotient_;
using nilnul.num.real.be_.negative.vow;

namespace nilnul.num.real_
{
	public interface NonnilDblI
	{

		nilnul.num.real.be_.nonnil.vow.EeDbl dblee { get; }

	}

	public class NonnilDbl :
		num.real.be_.nonnil.vow.EeDbl
		, NonnilDblI
		,
		_real_.DblI
	{


		public nilnul.num.real.be_.nonnil.vow.EeDbl dblee => this;

		public double Dbl => this;

		public NonnilDbl(double val) : base(val)
		{

		}
	}
}
