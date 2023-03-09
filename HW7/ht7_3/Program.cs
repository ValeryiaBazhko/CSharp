string Main(string message){
    Console.Write(message);
    string num = Console.ReadLine();
    return num;
}

void means(string nums){
    string[] input = nums.Split(" "); 
    int a = int.Parse(input[0]);
    int b = int.Parse(input[1]);
    int[,] matrix = new int[a,b];

    double[] colMeans = new double[b];

    Random ran = new Random();
    for(int i = 0; i < a; i++){
        for(int j = 0; j < b; j++){
            matrix[i,j] = (ran.Next(1,10));
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine("");
    }

    for(int j = 0; j < b; j++){
        double colSum = 0;
        for(int i = 0; i < a; i++){
            colSum += matrix[i,j];
        }
        colMeans[j] = colSum / a;
        Console.WriteLine($"Column {j+1} mean: {colMeans[j]}");
    }

}

means(Main("Enter dimensions of the matrix: "));
