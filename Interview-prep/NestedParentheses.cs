using System;

public class NestedParentheses
{
	public static Boolean NestedParentheses(string s)
	{
		int count = 0;
        for (int i = 0; i < s.Length; i++)
        {
			char ch = s[i];
			if(ch == "(")
            {
				++count;
            }else if(ch == ")")
            {
                --count;
                if (count < 0) return false;
            }
        }
        return count == 0;
	}
}
