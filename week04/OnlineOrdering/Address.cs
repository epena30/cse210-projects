using System;
using System.Collections.Generic;


public class Address
{
    public string _Street;
    public string _City;
    public string _StateOrProvince;
    public string _ZipCode;
    public string _Country;


    public Address(string street, string city, string stateOrProvince, string zipCode, string country)
    {
        _Street = street;
        _City = city;
        _StateOrProvince = stateOrProvince;
        _ZipCode = zipCode;
        _Country = country;
    }
    public String GetFullAddress()
    {
        return $"{_Street}, {_City}, {_StateOrProvince} {_ZipCode}, {_Country}";
    }
}