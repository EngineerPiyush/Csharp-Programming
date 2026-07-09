class Program {
    public static void Main(String []args){
    DateTime dt = DateTime.Now;
    // Console.WriteLine("{0:d}",dt);
    // Console.WriteLine("{0:D}",dt);
    // Console.WriteLine("{0:f}",dt);
    // Console.WriteLine("{0:F}",dt);
    // Console.WriteLine("{0:g}",dt);
    // Console.WriteLine("{0:G}",dt);
    // Console.WriteLine("{0:T} {1:t}",dt,dt);

    //  Console.WriteLine("{0:yyyy}",dt); // Represents the year
    //  Console.WriteLine("{0:ddd}",dt); // Represents the name of the day of week in short format
    //  Console.WriteLine("{0:dddd}",dt); // Represents the name of the day of week in full format
    //  Console.WriteLine("{0:HH}",dt); // Represents the current hours of the day in 24 hours format 
    //  Console.WriteLine("{0:m}",dt); // Represents the month with the date
    //  Console.WriteLine("{0:mm}",dt); // Represents the  minutes
    //  Console.WriteLine("{0:hh}",dt); // Represents the current hours of the day in 12 hours format 
    //  Console.WriteLine("{0:MM}",dt); // Represents the month in the number format out of 12
    //  Console.WriteLine("{0:MMM}",dt); // Represents the current month name in short format
    //  Console.WriteLine("{0:MMMM}",dt); // Represents the curent month name in full format
    //  Console.WriteLine("{0:ss}",dt); // Represents the seconds out of 00 to 59
    //  Console.WriteLine("{0:F}",dt); // Represents the firt digit of miliseconds
    //  Console.WriteLine("{0:FF}",dt); // Represents the firt two digits of miliseconds
    //  Console.WriteLine("{0:F}",dt); // Represents the All digits of miliseconds
    // // Lets try the combination
    // Console.WriteLine("{0:hh:mm:ss tt}",dt); // here ttt represents the AM or PM
    // Console.WriteLine("{0:HH:mm:ss }",dt);
    Console.WriteLine("{0:dd-MM-yyyy}",dt);
    Console.WriteLine("{0:dd/MM/yyyy}",dt);
    Console.WriteLine("{0:YYYY}",dt); // nothing represents just s string
    Console.WriteLine("{0:yy}",dt); // year of last two digit
    }
}
