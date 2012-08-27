// (C) 2012 Christian Schladetsch. See http://www.schladetsch.net/flow/license.txt for Licensing information.

using System;
using System.Collections.Generic;

namespace Flow
{
	public static class Extension
	{
		/// <summary>
		/// Returns true if the given sequences contains a reference to the given object.
		/// </summary>
		/// <returns>
		/// True if the sequence described by the enumerable contains a reference to the given object
		/// </returns>
		/// <param name='list'>
		/// The sequence
		/// </param>
		/// <param name='obj'>
		/// The reference to check for
		/// </param>
		/// <typeparam name='T'>
		/// The 1st type parameter.
		/// </typeparam>
		public static bool ContainsRef<T>(this IEnumerable<T> list, T obj)
		{
			foreach (var elem in list)
			{
				if (object.ReferenceEquals(elem, obj))
				{
					return true;
				}
			}
			return false;
		}

		/// <summary>
		/// Removes a reference from the list
		/// </summary>
		/// <param name='list'>
		/// The list to search
		/// </param>
		/// <param name='obj'>
		/// The object reference to remove.
		/// </param>
		/// <typeparam name='T'>
		/// The 1st type parameter.
		/// </typeparam>
		public static void RemoveRef<T>(this IList<T> list, T obj)
		{
			for (var n = 0; n < list.Count; ++n)
			{
				if (object.ReferenceEquals(list[n], obj))
				{
					list.RemoveAt(n);
					return;
				}
			}
		}
	}

	public delegate RT Func<RT>();

	public delegate RT Func<T0, RT>(T0 t0);

	public delegate void Action<T0>(T0 t0);
}
