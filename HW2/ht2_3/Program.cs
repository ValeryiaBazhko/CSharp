Console.Write("Enter the number of the day in a week: ");

int num = Convert.ToInt32(Console.ReadLine());

if(num < 1 || num > 7){
    Console.Write("Incorrect input.");
} else {
    if(num == 6 || num == 7 ){
        Console.Write("Yes");
    } else {
        Console.Write("No");
    }
}