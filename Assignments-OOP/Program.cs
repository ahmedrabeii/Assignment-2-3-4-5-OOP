namespace Assignments_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01 — Theoretical Questions
            #region Question 1
            //a:
            //Method Overloading: It occurs when multiple methods have the same name but different parameters in the same class.
            //Method Overriding: It occurs when a derived class provides a new implementation for a method inherited from the base class.
            //b:
            //Static Binding: The method call is resolved at compile time. It is commonly associated with method overloading.
            //Dynamic Binding: The method call is resolved at runtime.It is commonly associated with method overriding and virtual methods.


            #endregion

            #region Question 2
            //a:The sealed keyword applied to a class prevents other classes from inheriting from it.

            //b:
            //A sealed class prevents other classes from inheriting from it.
            //A sealed method prevents further derived classes from overriding that method.

            //c:No, a sealed method cannot be overridden because the `sealed` keyword prevents further overriding of that method in derived classes.
            #endregion
            #endregion
        }
    }
}
