

class Program
{
	static void Main ()
	{
		Stack<Tuple<int,int>> path = new Stack<Tuple <int,int>>();

		int[,] labirynth1 = new int[,]
		{
			{1, 1, 1, 1, 1, 1, 1 },
			{1, 0, 0, 0, 0, 0, 1 },
			{1, 0, 1, 1, 1, 0, 1 },
			{0, 0, 0, 0, 1, 0, 2 },
			{1, 1, 0, 0, 1, 1, 1 },
			{1, 1, 1, 1, 1, 1, 1 },
			{1, 1, 1, 1, 1, 1, 1 }
		};

		Console.WriteLine(FindPath(3, 0));
		


		int FindPath(int i, int j)
		{

				if (labirynth1[i, j] == 0) path.Push(new(i, j));

				while (path.Count > 0)
				{
					int exits = 0;
					var current = path.Pop();

					Console.WriteLine($"{current.Item1},{current.Item2}");

				if (labirynth1[current.Item1, current.Item2] == 2)
					{
						exits ++;
					return exits;

					}

					labirynth1[current.Item1, current.Item2] = 1;

					if (current.Item1 + 1 < labirynth1.GetLength(0) && labirynth1[current.Item1 + 1, current.Item2] != 1 )
					{
						path.Push(new Tuple<int, int>(current.Item1 + 1, current.Item2));
					}


					if ( current.Item2 + 1 < labirynth1.GetLength(1) && labirynth1[current.Item1, current.Item2 + 1] != 1 )
					{
						path.Push(new Tuple<int, int>(current.Item1, current.Item2 + 1));
					}

					if ( current.Item1 > 0 && labirynth1[current.Item1 - 1, current.Item2] != 1 )
					{
						path.Push(new Tuple<int, int>(current.Item1 - 1, current.Item2));
					}


				if ( current.Item2 > 0 && labirynth1[current.Item1, current.Item2 - 1] != 1 )
					{
						path.Push(new Tuple<int, int>(current.Item1, current.Item2 - 1));
					}

				}
				Console.WriteLine("Пути не найдено");
				return 0;
			
		}

	}

	

}
