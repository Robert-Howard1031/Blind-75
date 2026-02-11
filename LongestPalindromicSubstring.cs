public string LongestPalindrome(string s)
    {
        if (string.IsNullOrEmpty(s))
            return "";

        string best = "";

        for (int start = 0; start < s.Length; start++)
        {
            for (int end = start; end < s.Length; end++)
            {
                int len = end - start + 1;

                // if it can't beat the best, skip
                if (len <= best.Length)
                    continue;

                if (IsPalindrome(s, start, end))
                    best = s.Substring(start, len);
            }
        }

        return best;
    }

    private bool IsPalindrome(string s, int left, int right)
    {
        while (left < right)
        {
            if (s[left] != s[right])
                return false;

            left++;
            right--;
        }

        return true;
    }
