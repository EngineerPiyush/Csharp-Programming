class Program {
    public static void Main(string[] args){
        Console.WriteLine("Enter the number of elements in the array");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for(int i=0;i<arr.Length;i++){
            Console.WriteLine($"Enter {i+1} no. element");
            arr[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Your array is : ");
        for(int i=0;i<arr.Length;i++){
            Console.Write(arr[i]);
            if(i<(arr.Length-1)){
                Console.Write(" , ");
            }
        }
    }
}
