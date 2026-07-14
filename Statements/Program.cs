class Program {
    public static void Main(String []args){
        // Null-Coalescing Operator
        string name = null;
        string result = name ?? "piyush";
        Console.WriteLine(result);
        
        // if else statement using Relationl Operator 
        int age = 22;
        if(age<=22){
            Console.WriteLine("You are restricted from adult life");
        }
        else{
            Console.WriteLine("Ok bro you can enjoy");
        }

        // using Logical Expression
        bool isAdmin = true;
        bool isActive = true;
        if (isAdmin && isActive)
        {
            Console.WriteLine("Access Granted");
        }

        // using Method that returns bool
        static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        if (IsEven(10))
        {
            Console.WriteLine("Even");
        }

        // using a Boolean variable (no Relational Operator)
        bool isLoggedIn = true;
        if (isLoggedIn)
        {
            Console.WriteLine("Welcome");
        }

        Console.WriteLine("Enter the username");
        string userName = Console.ReadLine();
        Console.WriteLine("Enter the password");
        string password = Console.ReadLine();
        if(userName == "Piyush" && password == "user@123"){
            Console.WriteLine("Login Successfull");
        }else{
            Console.WriteLine("You have entered wrong credentials");
        }

        // if else ladder 
        Console.WriteLine("Enter the percentage");
        int Percentage = int.Parse(Console.ReadLine());
        if(Percentage>=90){
            Console.WriteLine("You got A Grade");
        }else if(Percentage>=80){
            Console.WriteLine("You got B Grade");
        } else if(Percentage>=70){
            Console.WriteLine("You got C Grade");
        } else if(Percentage>=60){
            Console.WriteLine("You got D Grade");
        } else{
            Console.WriteLine("You are failed");
        }

        // Nested if else 
        Console.WriteLine("Enter a Number");
        int n = int.Parse(Console.ReadLine());
        if(n>0 && n<= 100){
            if(n%2==0){
                if(n>=50){
                    Console.WriteLine("Even number less than 50 or equal");
                }else{
                    Console.WriteLine("Even number between 51 to 100");
                }
            }else{
                Console.WriteLine("Number is ODD");
            }
        }else{
            Console.WriteLine("Please enter a number between 1 to 100");
        }
    }
}