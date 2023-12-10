using System;

public class Country
{
    //строки класса
    public string CountryName = string.Empty;
    public string ContinentName = string.Empty;
    public int VillegerC = 0;
    public string NumberCountry = string.Empty;
    public string CapitalName = string.Empty;
    public string CityCountryName = string.Empty;

    //конструктор класса
    public Country(string countryName, string continentName, int villegerC, string numberCountry, string capitalName, string cityCountryName)
    {
        CountryName = countryName;
        ContinentName = continentName;
        VillegerC = villegerC;
        NumberCountry = numberCountry;
        CapitalName = capitalName;
        CityCountryName = cityCountryName;
    }

    public void ShowInfo()// метод для вывода инфы про страну
    {
        Console.WriteLine($"Название страны: {CountryName}");
        Console.WriteLine($"Название континента: {ContinentName}");
        Console.WriteLine($"Количество жителей: {VillegerC}");
        Console.WriteLine($"Телефонный код страны: {NumberCountry}");
        Console.WriteLine($"Название столицы: {CapitalName}");
        Console.WriteLine($"Название городов в стране: {CityCountryName}");
    }
}

class Program
{
    static void Main()
    {
        Country myCountry = new Country("Украина", "Европа", 4379000, "+380", "Киев", "Кривой рог, Харьков, Одесса, Львов, Днепр и так далее");
        myCountry.ShowInfo();//показываем инфу про страну
    }
}
