
//Random

//Basic parameterless constructor

using System.Runtime.Serialization.Formatters;

Random random = new Random();
Console.WriteLine(random.Next());

Console.WriteLine(random.Next(6)); // Picks a random int between 0-5 but not 6

Console.WriteLine(random.Next(20, 25)); // Picks int between 20-24

Console.WriteLine(); // Double between 0.0 to 1.0

Random seedRandom = new Random(2); //Adds a seed to the random 

//DateTime Struct

DateTime time1 = new DateTime(2022, 12, 31);
DateTime time2 = new DateTime(2022, 12, 31, 23, 59, 55);


DateTime time3 = DateTime.Now;
DateTime time4 = DateTime.UtcNow;

// TimeSpan Struct

TimeSpan timeSpan1 = new TimeSpan(1, 30, 0);
TimeSpan timeSpan2 = new TimeSpan(2, 12, 0, 0);
TimeSpan timeSpan3 = new TimeSpan(0, 0, 0, 0, 500);
TimeSpan timeSpan4 = new TimeSpan(10);

TimeSpan aLittleWhile = TimeSpan.FromSeconds(3.5);
TimeSpan quiteAWhile = TimeSpan.FromHours(1.21);

// Guid Struct

Guid id = Guid.NewGuid();

Console.WriteLine(id); // 16 bytes.

// List<T> Class

List<int> numbers = new List<int>(); //Create empty List

List<int> numbersList = new List<int>() {1, 2, 3}; // Collection initializer

// List<T> Indexing

List<string> words = new List<string>() {"apple", "banana", "corn", "durian"};
Console.WriteLine(words[2]);

words[0] = "Avocado"; // Assignment by index.

// Adding and removing items

List<string> words1 = new List<string>();
words1.Add("apple"); //Puts it at back of list

List<string> words2 = new List<string>();
// words2.Insert(2, "Corn"); //Insert item at specified index

List<string> words3 = new List<string>();
words3.AddRange(new string[] { "Apple", "Durian" }); //Add multiple to end

List<string> words4 = new List<string>();
// words4.InsertRange(1, new string[] {"Banana", "Corn"}); //Insert multiple at index

words4.Remove("Corn"); //Remove specified item

// words4.RemoveAt(1); //Remove item at index

words4.Clear(); // Removes everything

// Dictionary <TKey, TValue> class

Dictionary<string, string> dictionary = new Dictionary<string, string>(); // Create empty Dictionary

dictionary["battleship"] = "a warship with guns";
dictionary["cruiser"] = "A fast warship";

foreach (var VARIABLE in dictionary)
{
    Console.WriteLine(dictionary["battleship"]);
}





