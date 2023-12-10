using System;

public class City
{
    public string CityName = string.Empty;
    public string RegionName = string.Empty;
    public string CountryName = string.Empty;
    public int Population = 0;
    public string PostalCode = string.Empty;
    public string PhoneCode = string.Empty;

    public City(string cityName, string regionName, string countryName, int population, string postalCode, string phoneCode)
    {
        this.CityName = cityName;
        this.RegionName = regionName;
        this.CountryName = countryName;
        this.Population = population;
        this.PostalCode = postalCode;
        this.PhoneCode = phoneCode;
    }

    public void ShowCityInfo()
    {
        Console.WriteLine($"Назва мста: {CityName}");
        Console.WriteLine($"Назва региону: {RegionName}");
        Console.WriteLine($"Назва краини: {CountryName}");
        Console.WriteLine($"Килькисть жителив: {Population}");
        Console.WriteLine($"Поштовий индекс: {PostalCode}");
        Console.WriteLine($"Телефонний код: {PhoneCode}");
    }
}

class Program
{
    static void Main()
    {
        // Приклад використання класу "Місто"
        City myCity = new City("Киев", "Киевська область", "Украина", 2800000, "01001", "+380");

        // Виведення інформації про місто
        myCity.ShowCityInfo();
    }
}
