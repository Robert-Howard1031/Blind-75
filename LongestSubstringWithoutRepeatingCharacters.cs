public int LengthOfLongestSubstring(string s)
    {
        int longest = 0;

        // start of substring
        for (int start = 0; start < s.Length; start++)
        {
            string current = "";

            // expand substring until duplicate appears
            for (int end = start; end < s.Length; end++)
            {
                char c = s[end];

                // if duplicate found, stop expanding
                if (current.Contains(c))
                    break;

                current += c;

                // update longest length
                if (current.Length > longest)
                    longest = current.Length;
            }
        }

        return longest;
    }
