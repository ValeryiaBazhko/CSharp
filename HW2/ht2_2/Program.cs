Console.Write("Enter the number: ");

int num = Convert.ToInt32(Console.ReadLine());

int third_digit = 0;
if(num < 100){
    Console.Write("Third digit doesnt exist");
} else {
    while(num > 999){
        num /= 10;
    }

    third_digit = num % 10;
    Console.Write($"{third_digit}");
}