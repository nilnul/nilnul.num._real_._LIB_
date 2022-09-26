using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.num.real.trio_
{
		static public  class _AllNilX
		{
			private static readonly Lazy<(double,double,double)> _Trivia4dbl = new Lazy<(double,double,double)>(
				() => (0,0,0)
				,
				LazyThreadSafetyMode.ExecutionAndPublication
			);
			public static (double,double,double) Trivia4dbl
			{
				get { return _Trivia4dbl.Value; }
			}
		}
}