int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


try
{
    int el = nums[100];
    int zero = 0;
    int num = 100 / zero;
}
catch (DivideByZeroException e)
{
    Console.WriteLine(e.ToString());
}
catch (IndexOutOfRangeException e)
{
    Console.WriteLine(e.ToString());
}



int max = findMax(nums);
Console.WriteLine(max);




int findMax(int[] nums)
{
    int max = nums[0];
    for (int i = 1; i < nums.Length; i++)
    {
        if (nums[i] > max)
        {
            max = nums[i];
        }
    }
    return max;
}