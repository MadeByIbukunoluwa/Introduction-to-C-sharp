
namespace HelloWorld
{
    class Program
    {
        enum Days {Sun,Mon,Tue,Wed,Thu,Fri,Sat}
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Console.ReadKey();
            //Console.ReadLine();
            int num = 30;
            Console.WriteLine(num);
            double numDouble = 56.92;
            Console.WriteLine(numDouble);
            bool status = true;
            Console.WriteLine(status);
            string message = "Hello";
            Console.WriteLine(message);
            Console.WriteLine(Days.Sun);
            int val1 = 34, val2 = 45;
            Console.WriteLine(val1 > val2);
        } 
    }
}