using System.Net.Sockets;

public class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;

    public Address(string street, string city, string state, string country)
    {
        _streetAddress = street;
        _city = city;
        _state = state;
        _country = country;
    }
    public bool USACitizen()
    {
        return _country.ToLower() == "USA";
    }

    public string GetAddress()
    {
        return $"Address:{_streetAddress}\n{_city},\n{_state} {_country}";
    }
}