 public int CountSubstrings(string s)
    {
        int count = 0; // This will store how many palindromic substrings we find

        // Outer loop chooses the starting index of a substring
        for (int start = 0; start < s.Length; start++)
        {
            // Inner loop chooses the ending index of a substring
            // It always starts at "start" so we don't go backwards
            for (int end = start; end < s.Length; end++)
            {
                // Check if the substring from start to end is a palindrome
                if (IsPalindrome(s, start, end))
                {
                    // If it is a palindrome, increase the count
                    count++;
                }
            }
        }

        // After checking every possible substring, return total count
        return count;
    }

    // This helper checks if characters between two indices form a palindrome
    private bool IsPalindrome(string s, int left, int right)
    {
        // Keep checking characters from both ends moving inward
        while (left < right)
        {
            // If characters don't match, it's not a palindrome
            if (s[left] != s[right])
                return false;

            // Move inward
            left++;
            right--;
        }

        // If we never found a mismatch, it is a palindrome
        return true;
    }
