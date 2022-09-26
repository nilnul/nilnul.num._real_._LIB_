using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.real.stream.be_.piable;
using nilnul.num.real.stream.be_.piable.vow;
using nilnul.obj_.xpn_;

namespace nilnul.num.real.stream_
{
	/// <summary>
	/// for stream s, if
	/// stream.op_.unary_.Prod(s) has limit
	/// then s is Piable
	/// </summary>
	public interface PiableI
	{
		real.stream.be_.piable.vow.En stream {
			get;
		}
	}

	public class Piable :
		real.stream.be_.piable.vow.En,

		PiableI
	{
		public Piable(Vow<UnacceptableException<stream.be_.piable.VowI>> vow, StreamI val) : base(vow, val)
		{
		}

		public En stream => this;
	}
}
