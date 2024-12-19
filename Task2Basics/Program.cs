// C# Control Flow
//Challenge 1: Use a for loop to print the numbers from 1 to 10.
for (int i=1; i<=10;i++)
{
    Console.WriteLine(i);
}
Console.WriteLine("-------------------------------------------------");

//Bonus:Experiment with a while loop. Make it display a countdown from 5 to 1.
int n = 5;
int num;
while (n >= 1){
    num = n;
    n--;   
    Console.WriteLine(num);
}

Console.WriteLine("-------------------------------------------------");
//4️ C#
//Challenge 1: Create an array to store your weekly class schedule. Print the days of the week.
string[] daysOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
for (int x = 0; x < daysOfWeek.Length; x++)
{
    Console.WriteLine(daysOfWeek[x] );
}

Console.WriteLine("-------------------------------------------------");
//Challenge 2: Use a loop to sum the numbers in a simple array of integers.
int sum = 0;
int[] numbers = new int[10];
Random random = new Random(); // using random to generate random numbers for the array 
for (int i=0; i < 10; i++)
{
    numbers[i] = random.Next(10);
    sum += numbers[i];
    Console.WriteLine(numbers[i]);
}
Console.WriteLine("sum is: "+sum);
Console.WriteLine("-------------------------------------------------");

//Bonus! (+ 3pt)
//Look into multi-dimensional arrays. Can you think of when they might be useful?
// multi-dimensional array are usefull when we are dealing with tbles and grids.
string[,] schedule = { { "Monday", "Mohammad" }, { "Tuesday", "Ahmad" }, { "Wednesday", "Sara" }, { "Thursday", "Hassan" }, { "Friday", "Noor" } };
for (int c = 0; c < schedule.GetLength(0); c++)
{
    Console.WriteLine($"{schedule[c, 0]}: {schedule[c, 1]}");
}