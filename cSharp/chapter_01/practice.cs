using System;
/**
	1.1 Is Unique: Implement an algorithm to determine if a string has all unique characters.
		What if you cannot use additional data structures?

		SOLUTION: Letters.HasUnique() is a static method that takes a string, 
				  computes an O(N^2) algorithm and returns a booloean: true if the 
				  characters are unique and false if it finds repeated characters. 
				  Case and special characters matter as they are treated the same. 
				  I could defenitely add logic to ignore case and spaces, but that's 
				  outside the scope of this lesson, I think. Part of the reason
				  the algorithm isn't as optimal is because the only data structure
				  I make use of is the array. I can get this down to O(N) if I
				  implemented a hash table, but the problem reqirement prohibitis 
				  this.

	1.2 Check Permutation: Given two strings, write a method to decide if one is 
				  a permutation of the other.




*/

public class Letters
{

	public static bool HasUnique(String phrase)
	{
		for (int i = 0; i < phrase.Length; i++)
		{
			for (int j = i-1; j >= 0; j--)
			{
				if (phrase[i] == phrase[j])
				{
					return false;
				}
			}
		}

		return true;
	}

}

public class Sandbox
{
	public static void Main(String[] args)
	{

		String phrase = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
		String phrase1 = "HELLO WORLD";
		String answer = Letters.HasUnique(phrase).ToString();
		String directory = @"C:/Users/Public/chapter_01_practice.txt";
		System.IO.File.WriteAllText(directory, answer);

	}
}