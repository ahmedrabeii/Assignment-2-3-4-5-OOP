namespace Assignments_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01 — Theoretical Questions
            #region Questions 01 Object Copying
            //a:When one object variable is assigned to another, both variables refer to the same object in memory.

            //b:No. Assigning one object variable to another does not create a new object. It copies the reference, so both variables refer to the same object.

            //c:
            //Copying a reference means that two variables refer to the same object.
            //Copying an object means creating a separate object with copied data, so the two objects are independent.

            #endregion

            #region Questions 02 Shallow Copy vs Deep Copy
            //a:A Shallow Copy creates a new object and copies the values of its members. For reference-type members, it copies the references, not the referenced objects.

            //b:A Deep Copy creates a new object and also creates independent copies of the referenced objects, so the copied object does not share reference-type members with the original.

            //c:In a Shallow Copy, reference-type members are copied as references, so the original and copied objects share the same referenced objects.

            //d:In a Deep Copy, reference-type members are also copied into new independent objects, so the original and copied objects do not share them.

            //e:Deep Copy would be safer when copying an object that contains reference-type members and the copied object needs to be modified independently without affecting the original object.

            #endregion

            #region Questions 03 Static Members
            //a:
            //A static field belongs to the class itself and is shared by all objects of the class.
            //An instance field belongs to each object, so every object has its own copy.

            //b:
            //A static method belongs to the class rather than a specific object.
            //A static method cannot directly access instance members because instance members belong to a specific object.

            //c:A static constructor is used to initialize static members of a class. It is executed automatically once, before the class is first used.

            //d:A static class is a class that cannot be instantiated and is used to contain static members.
            //No, you cannot create an object from a static class.

            #endregion
            #endregion
        }
}
}
