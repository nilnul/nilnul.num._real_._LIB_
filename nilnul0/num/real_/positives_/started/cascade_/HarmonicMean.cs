using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real_.positives_.started.cascade_
{
	/// <summary>
	/// ( (x^n+x1^n+...+x[k]^n)  / k  )^ (1/n), where n = -1
	/// app:
	///		in electric,
	///			for paralleled resistors
	///				an equivalent single resisitor is computed as harmonicMean of those parallel resisitors
	/// </summary>
	public class HarmonicMean
		//: nilnul.objs_.started.CascadeA
	{
		public double cascade_assumePositivesStarted(IEnumerable<double> _positives_started) {
			return 1/ _positives_started.Select(x => 1 / x).Sum();
		}

		public real_.PositiveDbl cascade(real_.positives_.StartedDbl str) {
			return new PositiveDbl(
				started.op_.unary_.map_.InvertDbl.Singleton.op(str).Select(x => x.ee).Sum()
			);
		}


		static public HarmonicMean Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<HarmonicMean>.Instance;
			}
		}

	}
}
