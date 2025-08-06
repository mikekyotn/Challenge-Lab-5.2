namespace Challenge_Lab_5._2
{
    //Given an array nums containing n distinct numbers in the range [0, n],
    //return the only number in the range that is missing from the array.
    //Status: Complete
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 3, 0, 1 };
            int[] nums2 = { 0, 1 };
            int[] nums3 = { 5, 3, 2, 0, 1 };
            Console.WriteLine(FindMissingNum(nums1));//2
            Console.WriteLine(FindMissingNum(nums2));//2
            Console.WriteLine(FindMissingNum(nums3));//4
        }
        static int FindMissingNum(int[] numsArray)
        {
            int[] holdArray = new int[numsArray.Length +1];
            Array.Fill(holdArray, 0);

            for (int i = 0; i < numsArray.Length; i++)
            {
                holdArray[numsArray[i]] = 1;
            }

            return Array.IndexOf(holdArray, 0);
        }
    }
}
