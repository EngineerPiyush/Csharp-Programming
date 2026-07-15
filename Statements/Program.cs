class Program {
    public static void Main(String []args){
        // Null-Coalescing Operator
        // string name = null;
        // string result = name ?? "piyush";
        // Console.WriteLine(result);
        
        // // if else statement using Relationl Operator 
        // int age = 22;
        // if(age<=22){
        //     Console.WriteLine("You are restricted from adult life");
        // }
        // else{
        //     Console.WriteLine("Ok bro you can enjoy");
        // }

        // // using Logical Expression
        // bool isAdmin = true;
        // bool isActive = true;
        // if (isAdmin && isActive)
        // {
        //     Console.WriteLine("Access Granted");
        // }

        // using Method that returns bool
        // static bool IsEven(int number)
        // {
        //     return number % 2 == 0;
        // }

        // if (IsEven(10))
        // {
        //     Console.WriteLine("Even");
        // }

        // using a Boolean variable (no Relational Operator)
        // bool isLoggedIn = true;
        // if (isLoggedIn)
        // {
        //     Console.WriteLine("Welcome");
        // }

        // Console.WriteLine("Enter the username");
        // string userName = Console.ReadLine();
        // Console.WriteLine("Enter the password");
        // string password = Console.ReadLine();
        // if(userName == "Piyush" && password == "user@123"){
        //     Console.WriteLine("Login Successfull");
        // }else{
        //     Console.WriteLine("You have entered wrong credentials");
        // }

        // if else ladder 
        // Console.WriteLine("Enter the percentage");
        // int Percentage = int.Parse(Console.ReadLine());
        // if(Percentage>=90){
        //     Console.WriteLine("You got A Grade");
        // }else if(Percentage>=80){
        //     Console.WriteLine("You got B Grade");
        // } else if(Percentage>=70){
        //     Console.WriteLine("You got C Grade");
        // } else if(Percentage>=60){
        //     Console.WriteLine("You got D Grade");
        // } else{
        //     Console.WriteLine("You are failed");
        // }

        // Nested if else 
        // Console.WriteLine("Enter a Number");
        // int n = int.Parse(Console.ReadLine());
        // if(n>0 && n<= 100){
        //     if(n%2==0){
        //         if(n>=50){
        //             Console.WriteLine("Even number less than 50 or equal");
        //         }else{
        //             Console.WriteLine("Even number between 51 to 100");
        //         }
        //     }else{
        //         Console.WriteLine("Number is ODD");
        //     }
        // }else{
        //     Console.WriteLine("Please enter a number between 1 to 100");
        // }

        // multiple if statement
        // Console.WriteLine("enter the fruit name from this list {mango,banana,apple,grapes,guava,pineapple}");
        // string fruit = Console.ReadLine();
        // if(fruit=="mango"){
        //     Console.WriteLine($"Your choice is : {fruit}");
        // }
        // if(fruit=="banana"){
        //     Console.WriteLine($"Your choice is : {fruit}");
        // }
        // if(fruit=="grapes"){
        //     Console.WriteLine($"Your choice is : {fruit}");
        // }
        // if(fruit=="pineapple"){
        //     Console.WriteLine($"Your choice is : {fruit}");
        // }
        // if(fruit=="guava"){
        //     Console.WriteLine($"Your choice is : {fruit}");
        // }
        // if(fruit=="apple"){
        //     Console.WriteLine($"Your choice is : {fruit}");
        // }

        // switch case
        // Console.WriteLine("enter any day name of week in lowercase");
        // string day = Console.ReadLine();
        // switch(day){
        //     case "monday": 
        //     Console.WriteLine($"You have selected {day}");
        //     break;
        //     case "tuesday" :
        //     Console.WriteLine($"You have selected {day}");
        //     break;
        //     case "wednesday" :
        //     Console.WriteLine($"You have selected {day}");
        //     break;
        //      case "thursday" : 
        //     Console.WriteLine($"You have selected {day}");
        //     break;
        //     case "Friday" : 
        //     Console.WriteLine($"You have selected {day}");
        //     break;
        //     case "saturday" :
        //     Console.WriteLine($"You have selected {day}");
        //     break;
        //     case "sunday" :
        //     Console.WriteLine($"You have selected {day}");
        //     break;
        //     default :
        //     Console.WriteLine("you have entered wrong day/format");
        // }

        // C# allows the switch case constructed to be nested as well 
        Console.WriteLine("Enter what you would like to eact \"veg\" or \"non-veg\" ");
        string choice = Console.ReadLine();
        switch(choice){
            case "veg" :
            Console.WriteLine("Enter the choice from this list {paneer,masroom,dal-makhni,razma}");
            string veg_item = Console.ReadLine();
            switch(veg_item){
                case "paneer" :
                Console.WriteLine($"your choice is {veg_item}");
                break;
                case "dal-makhni" :
                Console.WriteLine($"your choice is {veg_item}");
                break;
                case "razma" :
                Console.WriteLine($"your choice is {veg_item}");
                break;
                case "masroom" :
                Console.WriteLine($"your choice is {veg_item}");
                break;
                default :
                Console.WriteLine("This veg-item is not available");
                break;
            }
            break;
            case "non-veg" :
            Console.WriteLine("Enter the choice from this list {mutton,chicken,fish,egg}");
            string item = Console.ReadLine();
            switch(item){
                case "mutton" :
                Console.WriteLine($"your choice is {item}");
                break;
                case "chicken" :
                Console.WriteLine($"your choice is {item}");
                break;
                case "fish" :
                Console.WriteLine($"your choice is {item}");
                break;
                case "egg" :
                Console.WriteLine($"your choice is {item}");
                break;
                default :
                Console.WriteLine("This item is not available");
                break;
            }
            break;
            default :
            Console.WriteLine("Please enter the exact word veg  or  non-veg");
            break;
        }
    }
}