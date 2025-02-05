public class ExampleClass
{
    private int _myField;

    public int MyProperty
    {
        get { return _myField; }
        set
        {
            // Add any validation or logic here
            if (value >= 0) 
            {
                _myField = value;
            }
            else
            {
                // Handle negative values appropriately
                _myField = 0;  
            }
        }
    }

    public void MyMethod()
    {
        // Accessing property consistently
        MyProperty = 10; 
        MyProperty = 20;
    }
}