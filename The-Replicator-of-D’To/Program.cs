int[] array1 = new int[5];
int[] array2 = new int[5];
int loopNum = 0;
int element;

do
{
    Console.WriteLine($@"Input a number ({loopNum} of 5)");
    array1[loopNum] = int.Parse(Console.ReadLine());
    loopNum++;

} while (loopNum < 5);

Array.Copy(array1, 0, array2, 0, 5);

foreach (var item in array2)
{
    Console.WriteLine($"New array: {item}");
}