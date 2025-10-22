// See https://aka.ms/new-console-template for more information



// EXERCISE 1 - ARRAYS


int[] numbers = new int[10];
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = rand.Next(10, 91);
}

// a) 
bool found = false;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] == 50)
    {
        Console.WriteLine("Found 50!");
        found = true;
        break;
    }
}
if (!found)
{
    Console.WriteLine("50 not found.");
}

// b)
int count50 = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] == 50)
    {
        count50++;
    }
}
Console.WriteLine("50 appears " + count50 + " times.");

// c) 
float average = 0;
for (int i = 0; i < numbers.Length; i++)
{
    average += numbers[i];
}
average = average / numbers.Length;
Console.WriteLine("Average: " + average);

// d) 
int min = numbers[0];
int max = numbers[0];
for (int i = 1; i < numbers.Length; i++)
{
    if (numbers[i] < min)
        min = numbers[i];
    if (numbers[i] > max)
        max = numbers[i];
}
Console.WriteLine("Min: " + min + ", Max: " + max);

// e)
long sum = 0;
long product = 1;
for (int i = 0; i < numbers.Length; i++)
{
    sum += numbers[i];
    product *= numbers[i];
}
Console.WriteLine("Sum: " + sum + ", Product: " + product);

// f) 
Console.Write("Reverse order: ");
for (int i = numbers.Length - 1; i >= 0; i--)
{
    Console.Write(numbers[i] + " ");
}
Console.WriteLine();

// g) 
int[] reversedNumbers = new int[numbers.Length];
for (int i = 0; i < numbers.Length; i++)
{
    reversedNumbers[i] = numbers[numbers.Length - 1 - i];
}

// h) 
int evenCount = 0, oddCount = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] % 2 == 0)
        evenCount++;
    else
        oddCount++;
}

int[] evenNumbers = new int[evenCount];
int[] oddNumbers = new int[oddCount];

int e = 0, o = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] % 2 == 0)
        evenNumbers[e++] = numbers[i];
    else
        oddNumbers[o++] = numbers[i];
}


// EXERCISE 2 


Console.Write("\nEnter how many integers (n > 0): ");
int n = int.Parse(Console.ReadLine());
int[] values = new int[n];
for (int i = 0; i < n; i++)
{
    Console.Write("Value " + (i + 1) + ": ");
    values[i] = int.Parse(Console.ReadLine());
}
Console.Write("Result: ");
for (int i = 0; i < n; i++)
{
    Console.Write(values[i] * i + " ");
}
Console.WriteLine();


// EXERCISE 3 


Console.Write("\nEnter number of throws: ");
int throwsN = int.Parse(Console.ReadLine());
int[] throwsCount = new int[6];
for (int i = 0; i < throwsN; i++)
{
    int face = rand.Next(1, 7);
    throwsCount[face - 1]++;
}

Console.WriteLine("Number of throws: " + throwsN);
for (int i = 0; i < 6; i++)
{
    double percent = (double)throwsCount[i] / throwsN * 100;
    Console.WriteLine("Face " + (i + 1) + ": " + throwsCount[i] + " (" + percent.ToString("F2") + "%)");
}


// EXERCISE 4 


int[,] matrix = new int[4, 4];
Console.WriteLine("\nEnter 16 integers (4x4 matrix):");
for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
    {
        matrix[i, j] = int.Parse(Console.ReadLine());
    }
}

int totalSum = 0;
for (int i = 0; i < 4; i++)
    for (int j = 0; j < 4; j++)
        totalSum += matrix[i, j];
Console.WriteLine("Total sum: " + totalSum);

int sumRow2 = 0;
for (int j = 0; j < 4; j++)
    sumRow2 += matrix[1, j];
Console.WriteLine("Sum of 2nd row: " + sumRow2);

int sumCol3 = 0;
for (int i = 0; i < 4; i++)
    sumCol3 += matrix[i, 2];
Console.WriteLine("Sum of 3rd column: " + sumCol3);

Console.Write("Main diagonal: ");
for (int i = 0; i < 4; i++)
    Console.Write(matrix[i, i] + " ");
Console.WriteLine();

Console.Write("Secondary diagonal: ");
for (int i = 0; i < 4; i++)
    Console.Write(matrix[i, 3 - i] + " ");
Console.WriteLine();


// EXERCISE 5 


Console.Write("\nEnter size n for square matrix: ");
int size = int.Parse(Console.ReadLine());
int[,] square = new int[size, size];

Console.WriteLine("Enter " + (size * size) + " integers:");
for (int i = 0; i < size; i++)
    for (int j = 0; j < size; j++)
        square[i, j] = int.Parse(Console.ReadLine());

int refSum = 0;
for (int j = 0; j < size; j++)
    refSum += square[0, j];

bool isMagic = true;
int sumDiag1 = 0, sumDiag2 = 0;

// Check rows
for (int i = 0; i < size; i++)
{
    int sumRow = 0;
    for (int j = 0; j < size; j++)
        sumRow += square[i, j];
    if (sumRow != refSum)
        isMagic = false;
}

// Check columns
for (int j = 0; j < size; j++)
{
    int sumCol = 0;
    for (int i = 0; i < size; i++)
        sumCol += square[i, j];
    if (sumCol != refSum)
        isMagic = false;
}

// Check diagonals
for (int i = 0; i < size; i++)
{
    sumDiag1 += square[i, i];
    sumDiag2 += square[i, size - 1 - i];
}

if (sumDiag1 != refSum || sumDiag2 != refSum)
    isMagic = false;

if (isMagic)
    Console.WriteLine("Magic square!");
else
    Console.WriteLine("Not a magic square.");


// LIST 


List<int> list = new List<int>();
int option = 0;

do
{
    Console.WriteLine("\n=== LIST ===");
    Console.WriteLine("1) Add number");
    Console.WriteLine("2) Remove number");
    Console.WriteLine("3) Remove by position");
    Console.WriteLine("4) Print list");
    Console.WriteLine("5) Print list in reverse order");
    Console.WriteLine("6) Count elements");
    Console.WriteLine("7) Clear list");
    Console.WriteLine("8) Exit");
    Console.Write("Option: ");

    if (!int.TryParse(Console.ReadLine(), out option))
    {
        Console.WriteLine("Invalid input.");
        continue;
    }

    if (option == 1)
    {
        Console.Write("Enter number: ");
        int value = int.Parse(Console.ReadLine());
        list.Add(value);
    }
    else if (option == 2)
    {
        Console.Write("Enter number to remove: ");
        int value = int.Parse(Console.ReadLine());
        if (list.Contains(value))
        {
            list.Remove(value);
            Console.WriteLine("Number removed.");
        }
        else
            Console.WriteLine("Number not found.");
    }
    else if (option == 3)
    {
        Console.Write("Enter position: ");
        int pos = int.Parse(Console.ReadLine());
        if (pos >= 0 && pos < list.Count)
        {
            list.RemoveAt(pos);
            Console.WriteLine("Element removed.");
        }
        else
            Console.WriteLine("Invalid position.");
    }
    else if (option == 4)
    {
        Console.Write("List: ");
        for (int i = 0; i < list.Count; i++)
            Console.Write(list[i] + " ");
        Console.WriteLine();
    }
    else if (option == 5)
    {
        Console.Write("Reversed: ");
        for (int i = list.Count - 1; i >= 0; i--)
            Console.Write(list[i] + " ");
        Console.WriteLine();
    }
    else if (option == 6)
    {
        Console.WriteLine("List has " + list.Count + " elements.");
    }
    else if (option == 7)
    {
        list.Clear();
        Console.WriteLine("List cleared.");
    }

} while (option != 8);


// STACK MENU


Stack<int> stack = new Stack<int>();
option = 0;

do
{
    Console.WriteLine("\n=== STACK MENU ===");
    Console.WriteLine("1) Push a number");
    Console.WriteLine("2) Pop a number");
    Console.WriteLine("3) Peek (show top)");
    Console.WriteLine("4) Count elements");
    Console.WriteLine("5) Clear stack");
    Console.WriteLine("6) Exit");
    Console.Write("Option: ");

    if (!int.TryParse(Console.ReadLine(), out option))
    {
        Console.WriteLine("Invalid input.");
        continue;
    }

    if (option == 1)
    {
        Console.Write("Enter number: ");
        int value = int.Parse(Console.ReadLine());
        stack.Push(value);
        Console.WriteLine("Number pushed.");
    }
    else if (option == 2)
    {
        if (stack.Count > 0)
            Console.WriteLine("Popped: " + stack.Pop());
        else
            Console.WriteLine("Stack is empty.");
    }
    else if (option == 3)
    {
        if (stack.Count > 0)
            Console.WriteLine("Top: " + stack.Peek());
        else
            Console.WriteLine("Stack is empty.");
    }
    else if (option == 4)
    {
        Console.WriteLine("Stack has " + stack.Count + " elements.");
    }
    else if (option == 5)
    {
        stack.Clear();
        Console.WriteLine("Stack cleared.");
    }

} while (option != 6);


// QUEUE 


Queue<string> queue = new Queue<string>();
option = 0;

do
{
    Console.WriteLine("\n=== QUEUE MENU ===");
    Console.WriteLine("1) Enqueue string");
    Console.WriteLine("2) Dequeue string");
    Console.WriteLine("3) Peek (show front)");
    Console.WriteLine("4) Print all elements");
    Console.WriteLine("5) Count elements");
    Console.WriteLine("6) Clear queue");
    Console.WriteLine("7) Exit");
    Console.Write("Option: ");

    if (!int.TryParse(Console.ReadLine(), out option))
    {
        Console.WriteLine("Invalid input.");
        continue;
    }

    if (option == 1)
    {
        Console.Write("Enter string: ");
        string text = Console.ReadLine();
        queue.Enqueue(text);
        Console.WriteLine("String enqueued.");
    }
    else if (option == 2)
    {
        if (queue.Count > 0)
            Console.WriteLine("Dequeued: " + queue.Dequeue());
        else
            Console.WriteLine("Queue is empty.");
    }
    else if (option == 3)
    {
        if (queue.Count > 0)
            Console.WriteLine("Front: " + queue.Peek());
        else
            Console.WriteLine("Queue is empty.");
    }
    else if (option == 4)
    {
        Console.Write("Queue contents: ");
        foreach (string s in queue)
            Console.Write(s + " ");
        Console.WriteLine();
    }
    else if (option == 5)
    {
        Console.WriteLine("Queue has " + queue.Count + " elements.");
    }
    else if (option == 6)
    {
        queue.Clear();
        Console.WriteLine("Queue cleared.");
    }

} while (option != 7);
    
