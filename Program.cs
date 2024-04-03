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



        }
        
        public static void Display(BoxCollection boxes)
        {
            Console.WriteLine("\nAvailable boxes:\nWidth\tLength:\tHeight:");
            foreach (Box box in boxes)
            {
                Console.WriteLine($"{box.Width}\t{box.Length}\t{box.Height}");
            }
        }
    }
}
