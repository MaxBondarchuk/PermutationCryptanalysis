﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace PermutationCryptanalysis
{
	internal static class Program
	{
		private const bool ArticleMode = false;
		private const int M = 4;
		private const int N = 4;

		private static void Main()
		{
			var machine = new Machine(m: M, n: N);
			Console.WriteLine(machine.InitialState);
			machine.OutputStateMatrix(ArticleMode);
			Console.WriteLine();
			machine.OutputOutputMatrix(ArticleMode);
			Console.WriteLine(machine.EnsurePermutation(4, 4));

			// Console.WriteLine("--");
			//
			// var reversedMachine = new ReversedMachine(machine);
			// Console.WriteLine(reversedMachine.InitialState);
			// reversedMachine.OutputStateMatrix(ArticleMode);
			// Console.WriteLine();
			// reversedMachine.OutputOutputMatrix(ArticleMode);
			//
			// Console.WriteLine("--");
			// // var inputs = new List<int> {0, 1, 2, 3};
			// var rnd = new Random();
			// var inputs = new List<int>();
			// int count = rnd.Next(35);
			// for (int i = 0; i < count; i++)
			// {
			// 	inputs.Add(rnd.Next(N));
			// }
			//
			// // var inputs = new List<int> {0, 1, 2, 3, 4, 5, 6};
			// // var inputs = new List<int> {0, 4, 2, 7, 3, 6};
			// foreach (int i in inputs)
			// {
			// 	Console.Write($"{i+1,4}");
			// }
			// Console.WriteLine();
			//
			// List<int> outputs = machine.Transform(inputs).ToList();
			// foreach (int o in outputs)
			// {
			// 	Console.Write($"{o+1,4}");
			// }
			// Console.WriteLine();
			//
			// Console.WriteLine("--");
			// IEnumerable<int> restoredInputs = reversedMachine.Transform(outputs);
			// foreach (int i in restoredInputs)
			// {
			// 	Console.Write($"{i+1,4}");
			// }
			// Console.WriteLine();
		}
	}
}