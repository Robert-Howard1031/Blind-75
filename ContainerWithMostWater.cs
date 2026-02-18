public int MaxArea(int[] height)
    {
        int left = 0;                    // left pointer starts at the beginning
        int right = height.Length - 1;   // right pointer starts at the end
        int best = 0;                    // best (maximum) area found so far

        // Keep going until the two pointers meet
        while (left < right)
        {
            // The water height is limited by the shorter line
            int h = height[left] < height[right] ? height[left] : height[right];

            // Width is the distance between the two lines
            int w = right - left;

            // Area = height * width
            int area = h * w;

            // Update best if this container is bigger
            if (area > best)
                best = area;

            // Move the pointer at the shorter line inward:
            // - If left line is shorter, moving right inward might find a taller line
            // - If right line is shorter, moving left inward might find a taller line
            // Moving the taller one inward can't help because height would still be limited
            // by the shorter one (or possibly even smaller)
            if (height[left] < height[right])
                left++;
            else
                right--;
        }

        // Return the maximum area found
        return best;
    }
