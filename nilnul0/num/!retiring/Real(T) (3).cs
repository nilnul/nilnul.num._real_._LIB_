﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.collection.set;


namespace nilnul.math.number.complex.real
{
	/// <summary>
	/// convert clr types.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public partial class Real<T>
	{
		private T _value;

		public Real(T value){
			if (
				typeof(T).IsElementOf(ClrRealTypeS).HasValue
				&&
				typeof(T).IsElementOf(ClrRealTypeS).Value==true
			)
			{
				_value = value;
			}
			else {
				throw new Exception();
			}

		}

		public T value {
			get {
				return _value;
			}
			set {
				_value = value;
			}
		}

		static public implicit operator T(Real<T> a){
			//return (T)((object)(a._value));
			return a._value;
		}

		static public implicit operator Real<T>(T a)
		{
			return new Real<T>(a);
		}

		

		
		

		


	}//struct


	
   
}//namespace




