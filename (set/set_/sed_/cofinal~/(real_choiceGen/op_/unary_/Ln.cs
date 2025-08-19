using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R = nilnul.num.RealI_blank;


namespace nilnul.num.real.op
{
	[Obsolete()]
	public class Ln1 : OpI
	{
		public static readonly Ln1 Singleton = SingletonByDefault<Ln1>.Instance;

		public num.RealI_blank eval(num.RealI_blank arg)
		{
			return new Call(arg);

			throw new NotImplementedException();
		}

		public class Call:nilnul._call.ArgA<R>,R
		{
			public Call(R x):base(x)
			{

			}

			public override string ToString()
			{
				return $"ln({arg})";
            }
		}

	}
}
