using System.Collections;
using System.Text.Json;
using System.IO;
using System.Net;
using Fundamentals;
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
            Tutorial ptutor = new Tutorial();
            ptutor.SetTutorial(1, ".Net");
            Console.WriteLine(ptutor.GetTutorial());
            ChildTutorial pTutor = new ChildTutorial();
            pTutor.RenameTutorial(".Net online Tutorial");
            Console.WriteLine(pTutor.GetTutorial());
            pTutor.SetTutorial(1, "First Tutorial");
            pTutor.SetTutorial("First Tutorial");
            // Implementation of ArrayList 
            ArrayList a1 = new ArrayList();
            a1.Add("ELEMENT1");
            a1.Add(true);
            a1.Add("1");
            a1.Add(5589);
            a1.Add("Angular");
            a1.Add("React");
            //a1.Count();
            a1.Contains("true");
            a1.RemoveAt(2);
            Console.WriteLine(a1[0]);
            Console.WriteLine(a1[1]);
            Console.WriteLine(a1[2]);
            Console.WriteLine(a1[3]);
            Console.WriteLine(a1[4]);
            // Implementation of Stack 
            Stack st = new Stack();
            st.Push("hello");
            st.Pop();
            st.Push(1);
            st.Push(2);
            st.Push(3);
            // Implementatiion of Queue
            Queue qt = new Queue();
            qt.Enqueue('1');
            qt.Enqueue('2');
            qt.Enqueue('3');
            qt.Dequeue();
            foreach (Object obj1 in qt)
            {
                Console.WriteLine(obj1);
            }
                Console.WriteLine("The number of elements in the Queue is" + qt.Count);
            Hashtable ht = new Hashtable();
             ht.Add("key", "value");
             ht.Add("001", "Machine Learning");
             ht.Add("002", "Game Development");
             ht.Add("003", "Embedded Systems engineering");
            ht.ContainsKey("900");
            ht.ContainsValue("hrnibrinc");
            // Dictionary <Tkey Tvalue>
            string path = "/Users/ibukunoluwaakintobi/Documents/text.txt";
            if (File.Exists(path))
            {
                Console.WriteLine("File Exists");
            }
            string[] lines;

            lines = File.ReadAllLines(path);
            Console.WriteLine(lines[0]);
            Console.WriteLine(lines[1]);

            string allLines;
            allLines = File.ReadAllText(path);

            Console.WriteLine(lines);

            string copypath = "/text1.txt";

            // For macOS, it throws an exception that tells me its a read-only File System 
            //File.Copy(path, copypath);


            //File.Delete(path);

            //Read only file system it will not work

            using (StreamReader sr = File.OpenText(path))
            {
                string s = "";

                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
            using (StreamWriter sr = File.AppendText(path))
            {
                sr.WriteLine("C sharp programming");
                sr.Close();

                Console.WriteLine(File.ReadAllText(path));
            }
            Tutorial2 obj = new Tutorial2();
            obj.ID = 1;
            obj.Name = "Game Development";

            //BinaryFormatter is considered obsolete , it has been replaced with JSON.serializer
            //ICustomFormatter formatter = new BinaryFormatter();
            //Stream stream = new FileStream()
            string JSONstring = JsonSerializer.Serialize(obj);
            Console.WriteLine(obj);
            Console.WriteLine(JSONstring);

            // Using asynchronous code
            // We have to put this code in a public static async Main method
            //string fileName = "newobj.json";
            //using FileStream createStream = File.Create(fileName);
            //await JsonSerializer.SerializeAsync(createStream,obj);
            //await createStream.DisposeAsync();

            //Console.WriteLine(File.ReadAllText(fileName));
            //string uservalue = Console.ReadLine();

            int x = 7;

            string message1 = (x == 1) ? "Car" : "Boat";

            Console.WriteLine(message1);

            //Console.ReadLine();

           

            string zig = "You can get what you want in life if you help other people get what they want";

            Random myRandom = new Random();
            int randomNumber = myRandom.Next(1, 11);
            Console.WriteLine(randomNumber.ToString());

            //String Formatting
            string anotherString = string.Format("{0:N}",123.45);
            string  anotherString1= string.Format("{0:P}",1234567890);
            string anotherString2 = string.Format("{0:C}", .123);
            string anotherString3 = string.Format("{0:(###) ###-####}", 1234567890);
            Console.WriteLine(anotherString);
            Console.WriteLine(anotherString1);
            Console.WriteLine(anotherString2);
            Console.WriteLine(anotherString3);

            // String Methods 
            string myString2 = "Tell her that she is going to come";
            Console.WriteLine(myString2.Substring(6,14));
            Console.WriteLine(myString2.ToUpper());
            Console.WriteLine(myString2.Remove(5,18));
            Console.WriteLine(myString2.Replace(" ","--"));
            Console.WriteLine(string.Concat("H3LLO", " HOW ARE YOU"));
            //Console.WriteLine(myString2.Append("XXXX"));

            // Dates and date formatting
            DateTime myValue = DateTime.Now;
            Console.WriteLine(myValue.ToShortTimeString());
            Console.WriteLine(myValue.ToLongTimeString());
            Console.WriteLine(myValue.ToShortDateString());

            Console.WriteLine(myValue.AddDays(3).ToShortDateString());
            Console.WriteLine(myValue.AddHours(3).ToShortDateString());
            Console.WriteLine(myValue.AddDays(-3).ToShortDateString());


            char[] charArray = zig.ToCharArray();
            Array.Reverse(charArray);

            foreach (char zigChar in charArray)
            {
                Console.Write(zigChar);
            }

            Car newCar = new Car("Ford", "2023",2026, "black");
            Console.WriteLine(newCar);

            //Web client is obsolete, use WebRequest, HttpWebRequest instead
            //string WebClient = new WebClient();

            Console.ReadLine();
        }

    }
}

