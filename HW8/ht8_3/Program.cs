string Main(string message) {
    Console.WriteLine(message);
    return message;
    
}


int[,,] writeMatrix(){
        int[,,] arr = {
            {{66, 0, 0, 0}, {25, 0, 1, 0}},
            {{34, 1, 0, 0}, {41, 1, 1, 0}},
            {{27, 0, 0, 1}, {90, 0, 1, 1}},
            {{26, 1, 0, 1}, {55, 1, 1, 1}}
        };

        int dim1 = arr.GetLength(0);
        int dim2 = arr.GetLength(1);
        int dim3 = arr.GetLength(2);

        for (int i = 0; i < dim1; i++) {
            for (int j = 0; j < dim2; j++) {
                for (int k = 0; k < dim3; k++) {
                    Console.Write($"{arr[i, j, k]}({i},{j},{k}) ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        return arr;
    }


    Main("The matrix is: ");

int[,,] arr = writeMatrix();

