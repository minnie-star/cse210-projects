using System.Net.Sockets;

public class Address
{
    public string _streetAddress;
    public string _city;
    public string _state;
    public string _country;

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