public class Address
{
    //private fields.
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    // constructor.
    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    //check whether the address in in the nigeria
    public bool IsInUSA()
    {
        return _country.Equals("USA", System.StringComparison.OrdinalIgnoreCase);
    }

    //return the complete address.
    public string GetAddress()
    {
        return $"{_street}\n{_city}, {_state}\n{_country}";
    }
    // getter methods.
    public string GetStreet()
    {
        return _street;
    }
    public string GetCity()
    {
        return _city;
    }
    public string GetState()
    {
        return _state;
    }
    public string GetCountry()
    {
        return _country;
    }

}