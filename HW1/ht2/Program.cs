Console.Write("Enter three numbers: ");
List<int> nums = new List<int>();
for(int i = 0; i < 3; i++){
    nums.Add(Convert.ToInt32(Console.ReadLine()));
}

int max = 0;
for (int i = 0; i < nums.Count; i++){
    if (nums[i] > max){
        max = nums[i];
    }
}
Console.Write($"Max is: {max}");