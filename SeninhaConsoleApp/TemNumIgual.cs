using System;
using System.Collections.Generic;

namespace Seninha
{
	public class Validacao
	{
		public bool TemNumIgual(List<int> l)
		{
			HashSet<int> num_vistos = new HashSet<int>();

			foreach(int n in l)
			{
				if (!num_vistos.Add(n))
				{
					return true;
				}
			}
			return false;
		}
	}
}