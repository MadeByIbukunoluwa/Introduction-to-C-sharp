
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
            if (val1 > val2) {
                Console.WriteLine("val1 is greater than val2");
            }
            else {
                Console.WriteLine("val1 is less than val2");
            }
            int value = 89;
            switch(value){
                case 1: Console.WriteLine("Value is 1");
                    break;
                case 2:Console.WriteLine("Value is 2 ");
                    break;
                default:Console.WriteLine("Value is different");
                    break; 
            }
            int val = 4,i = 0;
            while(i < val){
                Console.WriteLine(i);
                i += 1;
            }
            for (int j = 0; i < 7; i++)
            {
                Console.WriteLine(j);
            }
            int[] values;

            values = new int[4];
            values[0] = 1;
            values[1] = 2;
            values[2] = 3;
            Console.WriteLine(values[0]);
            Console.WriteLine(values[1]);
            Console.WriteLine(values[2]);
        } 
    }
}