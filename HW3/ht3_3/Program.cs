int main(string message){
    Console.Write(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int[] Cubes(int num){
    int[] cubes = new int[num];

    for (int i = 1; i <= num; i++){
        cubes[i-1] = Convert.ToInt32(Math.Pow(i, 3));
    }
    
    for (int i = 0; i < cubes.Length; i++){
        Console.Write($"{cubes[i]} ");
    }

    return cubes;
}

bool IfValid(int num){
    if(num > 0){
        return true;
    }
    
    return false;
}

int num = main("Enter the number: ");

if(IfValid(num)){
    int[] result = Cubes(num);
} else {
    Console.Write("Incorrect input");
}


