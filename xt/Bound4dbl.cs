using nilnul.num.real._bound;
using nilnul.num.real._bound.lowerUpper.be_.dwelt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R = nilnul.num.real.Ext4dblI;


namespace nilnul.num.real.ext
{
	public interface IBound
		//:nilnul.obj.IBound<real.IExt>
	{ }
	/// <summary>
	/// </summary>
	/// <remarks>
	/// useful in measure theory, where the value can be: [0,inf]
	/// </remarks>
	public class Bound4dbl
		:
		ext.border.co.be_.dwelt.vow.Ee4dbl
		
	{
		

		public Bound4dbl(in (Border4dblI , Border4dblI) border2) : base(in border2)
		{
		}
		public Bound4dbl((Border4dblI , Border4dblI) border2) : this(in border2)
		{
		}

		public Bound4dbl(Border4dblI border1, Border4dblI border2) : this( (border1, border2) )
		{
		}

		public Border4dblI lower => base.eeByRef.Item1;

		public Border4dblI upper => base.eeByRef.Item2;



		/// <summary>
		/// maybe infinite
		/// </summary>
		public double diameter => upper.mark.errable - lower.mark.errable;

		public bool has(Ext4dblI x)
		{
			return nilnul.num.real.ext.border_.lower.be_._HasX.Has(lower, x)
				&&
			nilnul.num.real.ext.border_.upper.be_._HasX.Has(upper, x);
		}

		static public Bound4dbl CreateOpen(R a, R b)
		{
			return new Bound4dbl(
				 Border4dbl.CreateOpen(a)
				

				 ,
				 Border4dbl.CreateOpen(
					b
				 )
			);
		}

		public static Bound4dbl CreateClopen(R real1, R real2)
		{
			return new Bound4dbl(
				Border4dbl.CreateClose(real1)
				,
				Border4dbl.CreateOpen(real2)
			);
		}

		public static Bound4dbl CreateOpenClose(R real1, R real2)
		{
			return new  Bound4dbl(
				Border4dbl.CreateOpen(real1)
				,
				Border4dbl.CreateClose(real2)
			);
		}

		public static Bound4dbl CreateOpenClose(Ext4dbl real1, Ext4dbl real2)
		{
			return new  Bound4dbl(
				Border4dbl.CreateOpen(real1)
				,
				Border4dbl.CreateClose(real2)
			);
		}
		public static Bound4dbl CreateClose(Ext4dblI real1, Ext4dblI real2)
		{
			return new  Bound4dbl(
				Border4dbl.CreateClose(real1)
				,
				Border4dbl.CreateClose(real2)
			);
		}

		public static Bound4dbl CreateClose(Ext4dbl real1, Ext4dbl real2)
		{
			return new  Bound4dbl(
				Border4dbl.CreateClose(real1)
				,
				Border4dbl.CreateClose(real2)
			);
		}


		static public Bound4dbl CreateClose(double a, double b)
		{
			return CreateClose(
				new Ext4dbl(a)
				,
				new Ext4dbl(b)
			);
		}

		public static Bound4dbl CreateClose(int v, R argSquared)
		{
			return CreateClose(
				new nilnul.num.real.Ext4dbl(v)
				,argSquared
			);
		}
	



	}


}
