using System;

class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;


    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public bool LivesUsa()
    {
        bool American;

        if (_country == "USA" || _country == "United States" || _country == "united states")
        {
            American = true;
        }
        else
        {
            American = false;
        }
        return American;
    }

    public string GetValues()
    {
        string allText;

        allText = $"{_street}\n{_city}\n{_state}\n{_country}.";

        return allText;
    }



}