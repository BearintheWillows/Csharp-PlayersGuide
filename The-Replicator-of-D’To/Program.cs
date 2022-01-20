int[] array1 = new int[5];
int[] array2 = new int[5];
int loopNum = 0;

// add the user input to array1
//Loops 5 times
do
{
    Console.WriteLine($@"Input a number ({loopNum} of 5)");
    array1[loopNum] = int.Parse(Console.ReadLine());
    loopNum++;

} while (loopNum < 5);

//Copies array1 to array2.
//First param is source array
//Second param is first index of source array
//Third param is destination array
//Fourth param is first index of destination array
//Final param is how many indexes to copy

Array.Copy(array1, 0, array2, 0, 5);

//Prints array2 to console.

foreach (var item in array2)
{
    Console.WriteLine($"New array: {item}");
}