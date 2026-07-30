#region Menü_Başlangıcı

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text;

Console.WriteLine("Api Consume İşlemine Hoş Geldiniz");
Console.WriteLine();
Console.WriteLine("### Yapmak İstediğiniz İşlemi Seçin ###");
Console.WriteLine();
Console.WriteLine("1- Şehir Listeleme");
Console.WriteLine("2- Şehir ve Hava Durumu Listeleme");
Console.WriteLine("3- Yeni Şehir Ekleme");
Console.WriteLine("4- Şehir Silme");
Console.WriteLine("5- Şehir Güncelleme");
Console.WriteLine("6- ID'ye Göre Şehir Getirme");
Console.WriteLine();

#endregion

string number;

Console.WriteLine("Tercihiniz:  ");
number = Console.ReadLine();
Console.WriteLine();

if (number == "1")
{
    string url = "https://localhost:7156/api/Weathers";
    using (HttpClient client = new HttpClient())
    {
        HttpResponseMessage response = await client.GetAsync(url);
        string responseBody = await response.Content.ReadAsStringAsync();
        JArray jArray = JArray.Parse(responseBody);
        foreach (var item in jArray)
        {
            string cityName = item["cityName"].ToString();
            Console.WriteLine($"Şehir:  {cityName}");
        }
    }
}
if (number == "2")
{
    string url = "https://localhost:7156/api/Weathers";
    using (HttpClient client = new HttpClient())
    {
        HttpResponseMessage response = await client.GetAsync(url);
        string responseBody = await response.Content.ReadAsStringAsync();
        JArray jArray = JArray.Parse(responseBody);
        foreach (var item in jArray)
        {
            string cityName = item["cityName"].ToString();
            string temp = item["temp"].ToString();
            string country = item["country"].ToString();
            Console.WriteLine(cityName + " - " + country + " - " + temp + " Derece");
            Console.WriteLine("----------------------------------------------------------");
        }
    }
}
if (number == "3") 
{
    Console.WriteLine("### Yeni Veri Girişi ###");
    Console.WriteLine();
    string cityName, country, detail;
    decimal temp;

    Console.Write("Şehir Adı: ");
    cityName = Console.ReadLine();

    Console.Write("Ülke Adı: ");
    country = Console.ReadLine();

    Console.Write("Hava Durumu Detayı: ");
    detail = Console.ReadLine();

    Console.Write("Sıcaklık: ");
    temp = decimal.Parse(Console.ReadLine());

    string url = "https://localhost:7156/api/Weathers";
    var newWeatherCity = new
    {
        CityName = cityName,
        Country = country,
        Detail = detail,
        Temp = temp
    };

    using (HttpClient client = new HttpClient())
    {
        string json = JsonConvert.SerializeObject(newWeatherCity);
        StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
        HttpResponseMessage response = await client.PostAsync(url, content);
        response.EnsureSuccessStatusCode();
    }
}
if (number == "4")
{ 

}

Console.Read();