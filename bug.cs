public class ExampleClass
{
    private int _myField;

    public int MyProperty
    {
        get { return _myField; }
        set { _myField = value; }
    }

    public void MyMethod()
    {
        // Accessing a field directly
        _myField = 10;
        // Accessing property
        MyProperty = 20; 
    }
}