class demo
{
    //string name = "Lokesh";

    public static void Main(string[] args)
    {
        ////implicit
        //int price = 10;
        //double prices = price;

        ////explicit
        //double age = 10.11;
        //int myage = (int)age;

        //Console.WriteLine(age);
        //Console.WriteLine(myage);

        //Type conversion Methods
        //int age = 10;
        //double ages = 10.20;
        //bool isactive = true;

        //Console.WriteLine(Convert.ToString(age)); //10 "10"
        //Console.WriteLine(Convert.ToDouble(age));
        //Console.WriteLine(Convert.ToInt32(ages));
        //Console.WriteLine(Convert.ToString(isactive));  
        //Console.WriteLine(isactive);  

        //userInput

        //Console.WriteLine("What is your age?");

        //int yourage = Convert.ToInt32(Console.ReadLine());

        //Console.WriteLine("my age is " + yourage);


        //int age = 4 ;
        //string drink = (age > 5) ? "Drink coffe" : "drink milk";


        // Console.WriteLine(drink);

        //int day = 0;

        //switch (day)
        //{
        //    case 1:
        //        //function
        //        Console.WriteLine("Monday");
        //        break;
        //    case 2:
        //        Console.WriteLine("tuesday");
        //        break;
        //    default:
        //        Console.WriteLine("None");
        //        break;
        //}


        //int number = 0;

        ////while(number <= 5)
        ////{
        ////    Console.WriteLine(number);
        ////    number++;
        ////}

        //do
        //{
        //    Console.WriteLine(number);
        //    number++;
        //}
        //while (number <= 5);

        //for(int number = 0; number <=5; number++)
        //{
        //    Console.WriteLine(number);
        //}

        //string[] colors = { "red", "blue", "green" };
        //colors[0] = "white";

        //Console.WriteLine(colors[0]);

        //foreach(string color in colors)
        //{
        //    Console.WriteLine(color);
        //}

        //myMethod("lokesh",0);

      int a  =  myMethod(10,20);
      double b =  myMethod(10.20,20.30);

        Console.WriteLine(a);
        Console.WriteLine(b);
    }

    static int myMethod(int a, int b)
    {
        return a + b;    
    }

    static double myMethod(double a, double b) {
        return a + b;
    }
}
 
