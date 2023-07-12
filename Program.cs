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

        Console.WriteLine("What is your age?");

        int yourage = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("my age is " + yourage);

    }

}

