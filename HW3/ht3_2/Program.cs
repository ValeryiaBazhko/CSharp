string Main(string message){
    Console.Write(message);
    string nums = Console.ReadLine();
    return nums;
} 

double Distance(string nums){
    string[] input = nums.Split(" ");
    int x1 = int.Parse(input[0]);
    int y1 = int.Parse(input[1]);
    int z1 = int.Parse(input[2]);
    int x2 = int.Parse(input[3]);
    int y2 = int.Parse(input[4]);
    int z2 = int.Parse(input[5]);

    double dist = Math.Sqrt(Math.Pow(x2 - x1, 2) + 
                            Math.Pow(y2 - y1, 2) + 
                            Math.Pow(z2 - z1, 2));
    Console.Write($"The distance between two point is: {dist}");

    return dist;
}

double nums = Distance(Main("Enter the coordinates of the two points in the format 'x1 y1 z1 x2 y2 z2': "));