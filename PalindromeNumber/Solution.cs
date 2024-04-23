namespace PalindromeNumber;

public static class Solution
{
    public static bool IsPalindrome(int x)
    {
        char[] xArray = x.ToString().ToCharArray();
        char[] xReverseArray = xArray.Reverse().ToArray();

        return (new string(xArray)).Equals(new string(xReverseArray));
    } 
}