
//organizing unit which contains named items eg classes

using System; //System is the library that has classes like namespace and Console or functions in it
namespace Calenders // namspace is basically like packages in Java, identifies and encapsulates thr your code
{
    internal class Program //entry point, in java your main class must be named Main but here name whatever
    {
        

        static void Main(string[] args) // this is entry point of method and it will be called first before anything
        {
            Console.WriteLine("Hello, World!");
            Date birthdate = new Date(2016, 2, 29);
            Child schoolchild = new Child("Santona", birthdate);
            Console.WriteLine(schoolchild); // prints the data because the ToString method is modified
        }
    }
}
