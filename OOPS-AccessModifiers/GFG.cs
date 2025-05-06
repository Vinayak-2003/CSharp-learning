// Inside the file GFG.cs 
using System;

namespace GFG {

class Child : Parent {

	
	public static void Main(String[] args)
	{
		// Accessing value in another assembly
		Child obj2 = new Child();

		// Member value is Accessible
		obj2.value = 9;
		Console.WriteLine("Value = " + obj2.value);
	}
}
}