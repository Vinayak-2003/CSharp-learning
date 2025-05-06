// Inside file Parent.cs
using System;

public class Parent
{
    // Declaring protected internal
    protected internal int value;
}

class ABC
{
    // Trying to access 
    // value in another class
    public void testAccess()
    {
        // Member value is Accessible
        Parent obj1 = new Parent();
        obj1.value = 12;
    }
}