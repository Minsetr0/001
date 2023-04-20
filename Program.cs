int[,] array = { { 7, 4, 3, 7, 9 }, { 1, 5, 4, 3, 2, }, { 6, 8, 9, 4, 1 }, { 4, 1, 3, 2, 7 }, { 7, 4, 3, 2, 1 } };
int sumInArray = 0;
int multiplicationInArray = 1;
int lineIndex = 1;
int columnIndex = 0;

for (int i = 0; i < array.GetLength(0); i++)
{
	for (int j = 0; j < array.GetLength(1); j++)
    { 
		Console.Write(array[i,j] + " ");
	}

	Console.WriteLine();
}

for (int i = 0; i < array.GetLength(0); i++)
{
	multiplicationInArray *= array[i, columnIndex];
}

for (int i = 0; i < array.GetLength(1); i++)
{
    sumInArray += array[lineIndex, i];
}

Console.WriteLine($"Сумма второй строки равна {sumInArray}, а произведение первого столбца равно {multiplicationInArray}.");