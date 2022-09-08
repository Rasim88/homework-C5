// Задача 34

Console.WriteLine("Enter first array's size:  ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];

FillArrayRandomNumbers(numbers);
Console.WriteLine("First array: ");
PrintArray(numbers);
int count = 0;

for (int z = 0; z < numbers.Length; z++)
if (numbers[z] % 2 == 0)
count++;

Console.WriteLine($"There are {numbers.Length} numbers in total, {count} of them are even");

void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100,1000);
    }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}

// Задача 36

Console.WriteLine("Enter second array's size: ");
int size2 = Convert.ToInt32(Console.ReadLine());
int[] numbers2 = new int[size2];

FillArrayRandomNumbers(numbers2);
Console.WriteLine("Second array: ");
PrintArray(numbers2);
int sum = 0;

for (int z = 0; z < numbers2.Length; z+=2)
    sum = sum + numbers2[z];

    Console.WriteLine($"There are {numbers2.Length} numbers in total, sum of odd elements = {sum}");
{
    for(int i = 0; i < numbers2.Length; i++)
        {
            numbers2[i] = new Random().Next(1,10);
        }
}

//Задача 38

double[] arrayRealNumbers = new double[10];
  for (int i = 0; i < arrayRealNumbers.Length; i++ )
  {
    arrayRealNumbers[i] = new Random().Next(1, 100);
    Console.Write(arrayRealNumbers[i] + " ");
  }

double maxNumber = arrayRealNumbers[0];
double minNumber = arrayRealNumbers[0];

  for (int i = 1; i < arrayRealNumbers.Length; i++)
  {
    if (maxNumber < arrayRealNumbers[i])
    {
      maxNumber = arrayRealNumbers[i];
    }
        if (minNumber > arrayRealNumbers[i])
    {
      minNumber = arrayRealNumbers[i];
    }
  }

  double decision = maxNumber - minNumber;

  Console.WriteLine($"\nThe difference between Max - ({maxNumber}) and Min - ({minNumber}) elements: {decision}");