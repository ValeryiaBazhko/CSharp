string Main(string message){
    Console.Write(message);
    string num = Console.ReadLine();
    return num;
}

double[] makeArray(string nums){
    int input = Convert.ToInt32(nums); 
    double[] arr = new double[input]; 

    Random ran = new Random();
    for(int i = 0; i < input; i++){
        arr[i] = ran.NextDouble();
        Console.Write(arr[i] + " ");
    }
    
    return arr;
}

double difference(double[] arr){
    double max = arr[0];
    double min = arr[0];
    
    for(int i=1; i<arr.Length; i++)
    {
        if(arr[i] > max)
            max = arr[i];
            
        if(arr[i] < min)
            min = arr[i];
    }
    double difference = max - min;
    Console.WriteLine("");
    Console.Write("The difference betweem max and min elt is: "+ difference);
    return difference;
}

double dif = difference(makeArray(Main("Enter the number of elts in the array: ")));

