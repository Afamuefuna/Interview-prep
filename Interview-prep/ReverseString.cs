using System;

public class ReverseString
{
	public ReverseString(string stringToReverse)
	{
		char[] charArray = stringToReverse.ToCharArray();
		Array.Reverse(charArray);
		return new string(charArray);
	}
}
