namespace OOP5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region part1 Q1
            /*
            An interface in C# is a contract that defines methods or properties a class must implement.

            We use interfaces instead of depending directly on concrete classes because they provide:

                 Loose Coupling: Reduces dependency between classes.
                 Flexibility: Different classes can implement the same interface in different ways.
                 Testability: Makes unit testing and mocking easier.
                 Polymorphism: Allows different objects to be handled through the same interface.
            */
            #endregion

            #region part1 Q2
            /*
            a) The problem is that both interfaces define a method named Greet(), but the class provides only one public implementation.
            Therefore, both interfaces use the same method implementation, which prints "Hello / Ahlan".

            b) The solution is to use Explicit Interface Implementation:
            c) No, translator.Greet() cannot be called directly because the methods are implemented explicitly.
            We must call each method through its interface reference:

            */
            #endregion

            #region part1 Q3
            /*
            Shallow Copy: Creates a new object but copies reference-type fields as references, 
            so the original and copied objects share the same referenced objects.

            Deep Copy: Creates a new object and independent copies of its referenced objects.

            Shallow Copy: Useful when sharing referenced objects is acceptable or when the object contains only value types
            and immutable references.

            Deep Copy: Useful when the copy must be fully independent from the original.
            */
            #endregion

            #region part1 Q4
            /*
            the output is:
                       Dev - Testing
                       QA - Testing
            MemberwiseClone() creates a shallow copy. The Title field is a string reference that is reassigned independently 
            when e2.Title = "QA" is executed. However, e1.Dept and e2.Dept refer to the same Department object.
            Therefore, changing e2.Dept.Name to "Testing" also changes the department name observed through e1.


            */
            #endregion
        }
    }
}
