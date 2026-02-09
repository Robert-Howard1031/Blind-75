public int LongestConsecutive(int[] nums)
    {
        if (nums.Length == 0)
            return 0;

        // Sort the numbers so consecutive values are next to each other
        Array.Sort(nums);

        int longest = 1; // longest streak found
        int current = 1; // current streak length

        for (int i = 1; i < nums.Length; i++)
        {
            // Skip duplicates
            if (nums[i] == nums[i - 1])
                continue;

            // If numbers are consecutive, extend streak
            if (nums[i] == nums[i - 1] + 1)
                current++;
            else
                current = 1; // reset streak

            // Update longest streak if needed
            if (current > longest)
                longest = current;
        }

        return longest;
    }
