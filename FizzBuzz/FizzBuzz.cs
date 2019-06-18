using System;

namespace FizzBuzz
{
public class FizzBuzzClass
	{
		public string Main(int candidate)
		{
			if (candidate % 5 == 0 && candidate % 3 == 0) {
				return "FizzBuzz";
				Console.WriteLine("FizzBuzz");
			} 
			else if (candidate % 3 == 0){
				return "Fizz";
				Console.WriteLine("Fizz");
			} 
			else if (candidate % 5 == 0){
				return "Buzz";
				Console.WriteLine("Buzz");
			}
			else {
				return candidate.ToString();
				Console.WriteLine(candidate.ToString());
				};
		}
	}
}
