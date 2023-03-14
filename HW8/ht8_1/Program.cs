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

int[,] sortMatrix(int[,] matrix){

    int rows = matrix.GetLength(0);
    int cols = matrix.GetLength(1);

    for (int i = 0; i < rows; i++) {    
        for (int j = 0; j < cols - 1; j++) {
            for (int k = 0; k < cols - j - 1; k++) {
                if (matrix[i, k] < matrix[i, k + 1]) {
                    int temp = matrix[i, k];
                    matrix[i, k] = matrix[i, k + 1];
                    matrix[i, k + 1] = temp;
                }
            }
        }
    }

    Console.WriteLine("Array after sorting: ");

    for (int i = 0; i < rows; i++) {
        for (int j = 0; j < cols; j++) {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }

    return matrix;
}

int[,] sorted = sortMatrix(makeMatrix(Main("Enter the dimensions of the array: ")));