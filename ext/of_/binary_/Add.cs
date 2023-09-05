using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.ext.of_.binary_
{
	public class Add : real.ext.of_.Binary4dblI
	{

		public ExtI op(ext_.inf_.Neg par, ExtI par1)
		{
			switch (par1)
			{
				case ext_.inf_.Neg neg:
					return ext_.inf_.Neg.Singleton;
				case ext_.Bare bare:
					return ext_.inf_.Neg.Singleton;
				case ext_.inf_.Pos pos:
					throw new InvalidOperationException(
						"-inf + inf is indeterministic."
					);
				default:
					break;
			}
			throw new UnexpectedReachException();
		}

		public ExtI op(ext_.inf_.Pos par, ExtI par1)
		{
			switch (par1)
			{
				case ext_.inf_.Neg neg:
					throw new InvalidOperationException(
						"-inf + inf is indeterministic."
					);

				default:
					return ext_.inf_.Pos.Singleton;
					break;
			}
			throw new UnexpectedReachException();
		}

		public ExtI op(ext_.Bare par, ExtI par1)
		{
			switch (par1)
			{
				case ext_.inf_.Neg neg:
					return ext_.inf_.Neg.Singleton;

				case ext_.Bare bare:
					return new ext_.Bare(nilnul.num.real.op_.binary_.Add.Singleton.op(par.val, bare.val));

				case ext_.inf_.Pos pos:
					return ext_.inf_.Pos.Singleton;

				default:
					break;
			}
			throw new UnexpectedReachException();
		}

		public ExtI op(ExtI par, ExtI par1)
		{
			switch (par)
			{
				case ext_.inf_.Neg neg:
					return op(neg, par1);
				case ext_.Bare bare:
					return op(bare, par1);
				case ext_.inf_.Pos pos:
					return op(pos, par1);

				default:
					return ext_.inf_.Neg.Singleton;

					break;
			}

		}


		public double _op_exts(double par, double par1)
		{
			return par + par1;
		}


		public Ext4dblI op(Ext4dblI par, Ext4dblI par1)
		{
			return new Ext4dbl( _op_exts(par.errable,par1.errable) );

		}

		static public Add Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Add>.Instance;
			}
		}

	}
}
