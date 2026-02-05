public int[] TwoSum(int[] nums, int target)
{
    // Loop through each number in the array
    for (int i = 0; i < nums.Length; i++)
    {
        // For each number, check every number that comes after it
        // This prevents checking the same pair twice
        for (int j = i + 1; j < nums.Length; j++)
        {
            // Check if the two numbers add up to the target
            if (nums[i] + nums[j] == target)
            {
                // If they do, return their indices
                return new int[] { i, j };
            }
        }
    }

    // If no valid pair is found, return null
    return null;
}
