namespace ConsoleApp1
{
    internal class Program
    {
        // C# cheet sheet https://www.thecodingguys.net/resources/cs-cheat-sheet.pdf
        // C# cheet sheet 2 https://cheatography.com/laurence/cheat-sheets/c/
        //     // console class and some of its methods, for more info visit https://learn.microsoft.com/en-us/dotnet/api/system.console?view=net-7.0
        static void First()
        {

            Console.Write("Enter a "); // print th text in same line
            Console.WriteLine("string"); // jumps to next line after printing

            string readInput = Console.ReadLine();
            Console.WriteLine("you have entered {0}", readInput);
            Console.WriteLine("Enter any key to get ASCII value");
            int asciiValue = Console.Read();
            Console.WriteLine("ASCII value is {0}", asciiValue);
            Console.ReadKey();

        }

        static void Second()
        {
            // Console class properties
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();


        }

        static void Third()
        {
            string myString = "15";
            string notAStringWithNum = "15a";
            int x = 5;

            Console.WriteLine("{0}", Int32.Parse(myString) + x); // parse convert string into integer
            //Console.WriteLine("{0}", Int32.TryParse(notAStringWithNum));
        }

        //String Manipulation
        static void Fourth()
        {
            string Name = "kunal";
            string Profession = "developer";

            // 1. String concatenation
            Console.WriteLine("Hello my name is " + Name + " My profession is " + Profession);

            // 2. String Fromatting
            Console.WriteLine("Hello my name is {0} My profession is {1}", Name, Profession);


            // 3. Strign interpolation best
            Console.WriteLine($"Hello my name is {Name}, My profession is {Profession}");

            // 4. verbatim String
            Console.WriteLine(@"Lorem ipsum is the,
                best in the world");

            Console.WriteLine(@"\n has no power or escape powre when using @");

            Console.WriteLine("enter a string in which searching shoudl be done");
            string str = Console.ReadLine();
            Console.WriteLine("enter a char to be search for");
            char searchForThis = Console.ReadLine()[0];

            Console.WriteLine($"the character {searchForThis} is found at index {str.IndexOf(searchForThis)}");

        }

        //Try Catch
        static void Fifth()
        {

            Console.WriteLine("please enter a number");
            string userInput = Console.ReadLine();

            // hover on parse to read about it and see the exceptions associated with


            try
            {
                int userInputAsInt = int.Parse(userInput);

            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Please don't leave empty");
            }
            catch (FormatException)
            {
                Console.WriteLine("Please Enter an integer");
                // throw throws the error in the main code and blocks the program from running further
                //throw;
            }
            catch (OverflowException)
            {
                Console.WriteLine("Please Enter an integer with 9 billion range");
            }
            catch (Exception) // this handles all the exception
            {
                Console.WriteLine("There is an error in input");
            }
            finally
            {
                Console.WriteLine("This will run in any case");

            }

        }
        static void Main(string[] args)
        {
            //First();
            //Second();
            //Third();
            //Fourth();
            Fifth();





        }
    }
}