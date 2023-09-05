using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.real.stream.be_.piable;
using nilnul.num.real.stream.be_.piable.vow;
using nilnul.num.real.stream.be_.piable.vow.en_;
using nilnul.obj_.xpn_;

namespace nilnul.num.real.stream_.piable_
{
	/// <summary>
	/// for stream s, if
	/// stream.op_.unary_.Prod(s) has limit
	/// then s is Piable
	/// </summary>
	public interface VowGeneralI
	{
		real.stream.be_.piable.vow.en_.VowGeneral stream {
			get;
		}
	}

	public class VowGeneral :
		real.stream.be_.piable.vow.en_.VowGeneral
		,
		VowGeneralI
	{
		public VowGeneral(stream.be_.piable.VowI vow, StreamI val) : base(vow, val)
		{
		}

		public stream.be_.piable.vow.en_.VowGeneral stream => this;
	}
}
