using System;

namespace SSContainer.Domain.Models.Products
{
  public class Product : Base
  {
    public string Name { get; set; }
    public string BarCode { get; set; }
    public DateTime RegistrationDate { get; set; }

    public Product(string name, string barCode, DateTime registrationDate)
    {
      Name = name;
      BarCode = barCode;
      RegistrationDate = registrationDate;
    }

  }
}