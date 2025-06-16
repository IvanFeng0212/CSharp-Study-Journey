using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CoreModule.Array
{
    /*
    Given a string s consisting of words and spaces,
    return the length of the last word in the string.
    A word is a maximal substring consisting of non-space characters only.

    Constraints:
    1 <= s.length <= 10^4
    s consists of only English letters and spaces ' '.
    There will be at least one word in s.

    Example 1:
    Input: s = "Hello World"
    Output: 5
    Explanation: The last word is "World" with length 5.

    Example 2:
    Input: s = "   fly me   to   the moon  "
    Output: 4
    Explanation: The last word is "moon" with length 4.

    Example 3:
    Input: s = "luffy is still joyboy"
    Output: 6
    Explanation: The last word is "joyboy" with length 6.
    */

    public class LengthofLastWord_58
    {
        public int LengthOfLastWord(string s)
        {
            int maxLength = 0;
            int lastIndex = s.Length - 1;
            while (lastIndex >= 0)
            {
                if (maxLength == 0 && s[lastIndex] == ' ')
                {
                    lastIndex -= 1;
                    continue;
                }

                if (maxLength == 0 && s[lastIndex] != ' ')
                {
                    maxLength += 1;
                }
                else
                {
                    if (s[lastIndex] != ' ')
                    {
                        maxLength += 1;
                    }
                    else
                    {
                        return maxLength;
                    }
                }

                lastIndex -= 1;
            }

            return maxLength;
        }
    }
}