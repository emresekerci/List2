//  Bir liste oluşturuyoruz
List<string> kahveler = new List<string>();

//  Kullanıcıdan 5 kahve ismi alıyoruz ve listeye ekliyoruz
for (int i = 1; i <= 5; i++)
{
    Console.Write($"Kahve {i}: ");
    string kahve = Console.ReadLine();
    kahveler.Add(kahve);
}

// Listeyi foreach döngüsüyle ekrana yazdırma
Console.WriteLine("\nKahve Listesi:");
int index = 1;
foreach (string kahve in kahveler)
{
    Console.WriteLine($"Kahve {index}: {kahve}");
    index++;
}