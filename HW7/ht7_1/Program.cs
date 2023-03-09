string Main(string message){
    Console.Write(message);
    string num = Console.ReadLine();
    return num;
}

double[,] makeMatrix(string nums){
    string[] input = nums.Split(" "); 
    int a = int.Parse(input[0]);
    int b = int.Parse(input[1]);
    double[,] matrix = new double[a,b];

    Random ran = new Random();
    for(int i = 0; i < a; i++){
        for(int j = 0; j < b; j++){
            matrix[i,j] = (ran.NextDouble() * (5 -(-5)));
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine("");
    }
    
    return matrix;
}

double[,] matrix = makeMatrix(Main("Enter dimensions of the matrix: "));

