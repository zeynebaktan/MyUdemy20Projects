Console.WriteLine("Api Consume İşlemine Hoş Geldiniz");
Console.WriteLine();
Console.WriteLine("### Yapmak İstediğiniz İşlemi Seçin ###");
Console.WriteLine();
Console.WriteLine("1- Şehir Listeleme");
Console.WriteLine("2- Yeni Şehir Ekleme");
Console.WriteLine("3- Şehir Silme");
Console.WriteLine("4- Şehir Güncelleme");
Console.WriteLine("5- ID'ye Göre Şehir Getirme");
Console.WriteLine();

string number;

Console.WriteLine("Tercihiniz:  ");
number = Console.ReadLine();

if (number == "1")
{
    Console.WriteLine("Şehir Listesi Buraya Gelecek");
}
if (number == "2")
{
    Console.WriteLine("Yeni Şehir Ekleme ALanı");
}
if (number == "3") 
{
    Console.WriteLine("Şehir Silme ALnaı");
}

Console.WriteLine(); 
Console.WriteLine(); 
