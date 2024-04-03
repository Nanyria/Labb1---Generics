namespace Labb1____Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BoxCollection boxList = new BoxCollection();
            boxList.Add(new Box(5, 7, 18));
            boxList.Add(new Box(7, 3, 4));
            boxList.Add(new Box(9, 9, 9));
            boxList.Add(new Box(2, 14, 5));
            boxList.Add(new Box(5, 7, 18));

            Display(boxList);
            Console.WriteLine("-----------------------------");

            boxList.Remove(new Box(9, 9, 9));

            Display(boxList);
            Console.WriteLine("-----------------------------");

            Box boxToCheck = new Box(5, 7, 18);
            Console.WriteLine($"Checking to see if box with the following dimentions exists in collection:" +
                $"\nHeight: {boxToCheck.Height}" +
                $"\tWidth: {boxToCheck.Width}" +
                $"\tLength: {boxToCheck.Length}" +
                $"\tIs in collection: {boxList.Contains(boxToCheck)}");

            Console.WriteLine("-----------------------------");
            Box boxToCheckFalse = new Box(7, 7, 18);
            Console.WriteLine($"Checking to see if box with the following dimentions exists in collection:" +
                $"\nHeight: {boxToCheckFalse.Height}" +
                $"\tWidth: {boxToCheckFalse.Width}" +
                $"\tLength: {boxToCheckFalse.Length}" +
                $"\tIs in collection: {boxList.Contains(boxToCheckFalse)}");

        }

        public static void Display(BoxCollection boxes)
        {
            Console.WriteLine("\nAvailable boxes:\nHeight\tWidth:\tLength:");
            foreach (Box box in boxes)
            {
                Console.WriteLine($"{box.Height}\t{box.Width}\t{box.Length}");
            }
        }
    }
}
