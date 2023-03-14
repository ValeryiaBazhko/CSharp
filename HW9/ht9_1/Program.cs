int main(string message){
    Console.Write(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

void Print(int num){
    if(ifValid(num)){
        if(num == 1){
            Console.Write("1");
        } else {
            Console.Write($"{num}, ");
            Print(num-1);
        }
    }
}

bool ifValid(int num){
    if(num > 0){
        return true;
    }
    return false;
}

Print(main("Enter the number: "));