int Main(string message){
    Console.Write(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

bool IsPalindrom(int num){
    int reverse = 0;
    int pal = num;

    while(pal != 0){
        int rem = pal % 10;
        reverse = reverse * 10 + rem;
        pal = pal / 10;
    }

    if (num == reverse){
        return true;
    }
    return false;
}

int num = Main("Enter the number: ");

if(IsPalindrom(num)){
    Console.Write("Yes");
} else {
    Console.Write("No");
}