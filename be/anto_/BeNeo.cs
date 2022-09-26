using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.be.anto_
{

	public class BeNeo<TBe>
		:
		real.be.Anto4dbl

		where TBe : nilnul.obj.BeI1<double>, new()
	{
		public BeNeo() : base(
				 nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TBe>.Instance
		)
		{
		}

		static public BeNeo<TBe> Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<BeNeo<TBe>>.Instance;
			}
		}


	}
}
