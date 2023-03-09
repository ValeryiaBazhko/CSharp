string Main(string message){
    Console.Write(message);
    string num = Console.ReadLine();
    return num;
}

int Power(string num){
    string[] input = num.Split(" ");
    int a = int.Parse(input[0]);

    int b = int.Parse(input[1]);

    int power = 1;

    for(int i = 0; i < b; i++){
        power *= a;
    }

    Console.Write($"Power of {a} in the exp {b} is: {power}");
    return power;
}

int power = Power(Main("Enter the base and the exp in the format: "));