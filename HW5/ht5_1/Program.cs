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

int even(int[] arr){
    int num = 0;
    for(int i = 0; i < arr.Length; i++){
        if(arr[i] % 2 == 0){
            num++;
        }
    }
    Console.WriteLine("");
    Console.Write("Number of even numbers in the array is: " + num);
    return num;
}

int nums = even(makeArray(Main("Enter the number of elts in the array: ")));


