namespace LEARNING_CSHARP
{
	public class Person
	{
		public int Age;
		public string FullName;

		public void ShowInfo()
		{
			System.Console.WriteLine("I'm {0} and {1} years old.", FullName, Age);
		}
	}
}
