Console.Write("Enter three-digit number: ");

int num = Convert.ToInt32(Console.ReadLine());

int two_digit = 0;
int second_digit = 0;
if(num > 99 && num < 1000){
    two_digit = num / 10;
    second_digit = two_digit % 10;
}

Console.Write($"{second_digit}");
