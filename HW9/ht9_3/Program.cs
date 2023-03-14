
void Main(string message) {
    Console.Write(message);
    string[] input = Console.ReadLine().Split(" "); 
    int m = int.Parse(input[0]);
    int n = int.Parse(input[1]);
        
    if (ifValid(m,n)) {
        Console.WriteLine($"Ackermann number is: {Ackermann(m,n)}");
    } else {
        Console.WriteLine("Invalid input: m and n must be not negative!");
    }
}

int Ackermann(int m, int n) {
    if (m == 0) {
        return n + 1;
    } else if (n == 0) {
        return Ackermann(m - 1, 1);
    } else {
        return Ackermann(m - 1, Ackermann(m, n - 1));
    }
    
}
    
bool ifValid(int m, int n) {
    return (m >=0 && n >=0);
}

Main("Enter m and n: ");