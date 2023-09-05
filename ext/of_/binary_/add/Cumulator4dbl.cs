using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.ext.of_.binary_.add
{
	public class Cumulator4dbl
		: nilnul.obj.op_.binary.cumulator_.OpDefault<Ext4dblI, Add>
,
		nilnul.obj.op_.binary.CumulatorI<Ext4dblI>
		,
		nilnul.obj.op_.binary.cumulator_.IUnardable
		//,
		//nilnul.obj.op_.binary_.commutative.CumulatorI<double>
	{
		public Cumulator4dbl() : base(
			Ext4dbl.Nil
			
			
		)
		{
		}


		static public Cumulator4dbl Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Cumulator4dbl>.Instance;
			}
		}

	}
}
