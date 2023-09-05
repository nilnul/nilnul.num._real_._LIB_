using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.ext.be.vow_
{
	public class BeDefaulted<TBe>
		:
		ext.be.Vow4dbl
		where TBe : nilnul.obj.BeI_ofIn<Ext4dblI>, new()
	{
		public BeDefaulted() : base(
			 nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TBe>.Instance
		)
		{
		}


		static public BeDefaulted<TBe> Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<BeDefaulted<TBe>>.Instance;
			}
		}

	}
}
