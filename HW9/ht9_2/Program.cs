
void Main(string message) {
    Console.Write(message);
    string[] input = Console.ReadLine().Split(" "); 
    int m = int.Parse(input[0]);
    int n = int.Parse(input[1]);
        
    if (ifValid(m,n)) {
        Console.WriteLine($"Sum of numbers between {m} and {n} is: {SumNumbers(m,n)}");
    } else {
        Console.WriteLine("Invalid input: m must be less than or equal to n.");
    }
}

int SumNumbers(int m, int n) {
    if (m == n) {
        return m;
    } else {
        return n + SumNumbers(m, n-1);
    } 
}
    
bool ifValid(int m, int n) {
    return m <= n;
}

Main("Enter m and n: ");
