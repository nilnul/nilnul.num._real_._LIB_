using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.ext_.inf_
{
	public class Pos
		:InfI
	{
		public const char CHAR = '∞';
		public const string TXT = "∞";


		public override string ToString()
		{
			return CHAR.ToString();
		}


		static public Pos Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Pos>.Instance;
			}
		}


	}
}
