string Main(string message){
    Console.Write(message);
    string num = Console.ReadLine();
    return num;
}

int[,] makeMatrix(string nums){
    string[] input = nums.Split(" "); 
    int a = int.Parse(input[0]);
    int b = int.Parse(input[1]);
    int[,] matrix = new int[a,b];

    Random ran = new Random();
    for(int i = 0; i < a; i++){
        for(int j = 0; j < b; j++){
            matrix[i,j] = ran.Next(1,10);
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine("");
    }
    
    return matrix;
}

int minSum(int[,] matrix){

        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        int minRow = 0;
        int minSum = int.MaxValue;

        for (int i = 0; i < rows; i++) {
            int sum = 0;
            for (int j = 0; j < cols; j++) {
                sum += matrix[i, j];
            }
            if (sum < minSum) {
                minRow = i;
                minSum = sum;
            }
        }
        Console.WriteLine($"The row with the lowest sum is: {minRow + 1}");
        return minRow;
    }

int min = minSum(makeMatrix(Main("Enter the dimensions of the array: ")));