public class Customer
{
    //private fields.
    private string _name;
    private Address _address;

    // constructor.
    public Customer(string name,Address address)
    {
        _name = name;
        _address = address;
    }

    // checks if the customer lives in Nigeria.
    public bool LivesInUSA()
    {
        return _address.IsInUSA();
    }
    // return customer's name.
    public string GetName()
    {
        return _name;
    }
    // return customer's address.
    public Address GetAddress()
    {
        return _address;
    }
}