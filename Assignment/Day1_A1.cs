namespace Assignment
{
    internal class Day1_A1
    {
        static void Main(string[] args)
        {
            int val;
            Console.WriteLine("Enter the value: ");
            val = int.Parse(Console.ReadLine());

            Console.WriteLine("The Square of {0} is {1}",val,(square(val)));
            Console.WriteLine("The Square of {0} is {1}", val, (cube(val)));

        }
        static int square(int x)
        {
            return x * x;
        }
        static int cube(int x)
        {
            return x * x * x;
        }
    }
}