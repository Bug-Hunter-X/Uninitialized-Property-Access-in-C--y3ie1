public class ExampleClass
{
    public int MyProperty { get; set; }

    // Constructor to initialize the property
    public ExampleClass()
    {
        MyProperty = 10; // Initialize the property
    }

    public void MyMethod()
    {
        Console.WriteLine(MyProperty); // Accessing the property after initialization
    }

    // or assigning value before usage
    public void MyMethod2(){
        MyProperty = 100;
        Console.WriteLine(MyProperty);
    }
}