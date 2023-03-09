string Main(string message){
    Console.Write(message);
    string num = Console.ReadLine();
    return num;
}

int[] makeArray(string nums){
    int input = Convert.ToInt32(nums); 
    int[] arr = new int[input]; 

    Random ran = new Random();
    for(int i = 0; i < input; i++){
        arr[i] = ran.Next(1, 1001);
        Console.Write(arr[i] + " ");
    }
    
    return arr;
}

int sumOdd(int[] arr){
    int sum = 0;
    for(int i = 0; i < arr.Length; i++){
        if(i % 2 == 1){
            sum += arr[i];
        }
    }
    
    Console.WriteLine("");
    Console.Write("The sum of the numbers on odd positions is: " + sum);
    return sum;
}

int sum = sumOdd(makeArray(Main("Enter the number of elts in the array: ")));
