using System;
using System.Collections.Generic;

namespace AddressBook.Models
{
  public class Contact
  {
    private string _name;
    private string _address;
    private string _phone;

    public Contact (string name, string address, string phone)
    {
      _name = name;
      _address = address;
      _phone = phone;
    }

    public string GetName()
    {
      return _name;
    }

    public void SetName(string newName)
    {
      _name = newName;
    }

    public string GetAddress()
    {
      return _address;
    }

    public void SetAddress(string newAddress)
    {
      _address = newAddress;
    }

    public string GetPhone()
    {
      return _phone;
    }

    public void SetPhone(string newPhone)
    {
      _phone = newPhone;
    }

  }
}
