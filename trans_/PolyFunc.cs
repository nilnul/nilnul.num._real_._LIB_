﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.func_
{
	public  class _PolynomialX
	{



		/// <summary>
		/// Evaluates a polynomial of degree N
		/// </summary>
		/// <param name="x">Main variant</param>
		/// <param name="coef">Array of coefficients in reverse order.
		/// for: a * x^3 + b *x^2 + c* x^1 +d, the array is [a,b,c,d]
		/// </param>
		/// <param name="N">
		/// Degree of the polynomial, also one less than the number of coefficients. Must be >= 1
		/// </param>
		/// <returns>Solution of the polynomial</returns>
		public static double PolyEval(double x, double[] coef, int N)
		{
			if (N < 1) { return 0; }

			double ans = coef[0];
			int i = 1;

			do
			{
				ans = ans * x + coef[i];
				i++;
			} while (--N > 0);

			return ans;
		}



		/// <summary>
		/// 
		/// </summary>
		/// <param name="coef"> index is the order</param>
		/// <param name="x"></param>
		/// <returns></returns>
		public static double PolyEval2(double[] coef,double x)
		{
			if (coef is null)
			{
				return 0;
				
			}


			double ans=0;

			int power=coef.Length-1;

			///firs the nthe coef.
			///

			

			while (power>=0)
			{
				ans = ans*x+coef[power];
				power--;
			}
		

			return ans;




			
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="x"></param>
		/// <param name="coef">
		/// from x^0 to x^(n-1).   i.e., [0,n)
		/// index is the order
		/// </param>
		/// <returns></returns>
		/// Horner's method
		public static double PolyEval3(double x,params double[] coef )
		{
			if (coef   is null)
			{
				return 0;
			}

			double result = 0;
			int power = coef.Length - 1;

			///firs the n-th coef.
			///

			while (power >= 0)
			{
				result = result * x + coef[power];
				power--;
			}


			return result;




		}

	}
}
