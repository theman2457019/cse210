class Address
{
    private string _houseNumber;
    private string _street;
    private string _city;
    private string _state;
    private string _zip;
    private string _country;

    public Address()
    {
        _houseNumber = "Unknown";
        _street = "Unknown";
        _city = "Unknown";
        _state = "Unknown";
        _zip = "Unknown";
        _country = "Unknown";
    }

    public Address(string houseNumber, string street, string city, string state, string zip, string country)
    {
        _houseNumber = houseNumber;
        _street = street;
        _city = city;
        _state = state;
        _zip = zip;
        _country = country;
    }

    public bool IsUSA()
    {
        return _country.ToUpper() == "USA";
    }

    public string GetAddress()
    {
        return $"{_houseNumber}, {_street}\n{_city}, {_state} {_zip}\n{_country}";
    }
}