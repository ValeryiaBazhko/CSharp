string Main(string message){
    Console.Write(message);
    string num = Console.ReadLine();
    return num;
}

void ifExists(string nums){
    string[] input = nums.Split(" "); 
    int a = int.Parse(input[0]);
    int b = int.Parse(input[1]);
    int[,] matrix = new int[6,6];

    Random ran = new Random();
    for(int i = 0; i < a; i++){
        for(int j = 0; j < b; j++){
            matrix[i,j] = (ran.Next(1,10));
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine("");
    }

    if(ifValid(a,b) && a < matrix.GetLength(0) && b < matrix.GetLength(1)){
        Console.Write($"The value of matrix at the position [{a},{b}] is: " + matrix[a,b]);
    } else {
        Console.Write("Such element doesnt exist");
    }
}

bool ifValid(int a, int b){
    return (a >= 0 && a < 6 && b >= 0 && b < 6);
}

ifExists(Main("Enter the position of the element you want to find: "));