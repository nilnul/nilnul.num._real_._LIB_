using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.stream.be_
{
	public interface PiableI:real.stream.BeI { }
	/// <summary>
	/// Pi, the greek leter, means infinite product
	/// </summary>
	public class Piable : 
		nilnul.obj.Box< nilnul.num.real.stream.be_.ConvergentI>
		,
		PiableI
		,
		nilnul.num.real.stream.BeI

	{
		public Piable(ConvergentI val) : base(val)
		{
		}

		public bool be(StreamI obj)
		{
			return boxed.be(
				real.stream.op_.unary_.Prod.Singleton.op(obj)
			);
		}
	}
}
