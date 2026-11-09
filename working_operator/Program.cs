using System.Text;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine(">>> Hello, перегрузка операторів World!");

//Device s25 = new Phone(manufacturer: "Samsung", 
//    model: "Galaxy S25", 
//    price: 999.99m, 
//    processor: "Exynos 2200", 
//    ramGb: 8, 
//    storageGb: 256, 
//    simCount: 2, 
//    cameraMegapixels: 108);
//Console.WriteLine(s25);

List<Device> devices = new List<Device>();

Device s25 = new Phone(manufacturer: "Samsung",
    model: "Galaxy S25",
    price: 999.99m,
    processor: "Exynos 2200",
    ramGb: 8,
    storageGb: 256,
    simCount: 2,
    cameraMegapixels: 108);
devices.Add(s25);

Device motorola = new Phone(manufacturer: "Motorola",
    model: "Moto Signature 16/512 MartiniOlive",
    price: 799.99m,
    processor: "Snapdragon 888",
    ramGb: 16,
    storageGb: 512,
    simCount: 2,
    cameraMegapixels: 64);
devices.Add(motorola);

Device dell = new Laptop(manufacturer: "Dell",
    model: "Pro 16",
    price: 1499.99m,
    processor: "Intel Core i7-1165G7",
    ramGb: 16,
    storageGb: 512,
    screenSizeInches: 16.0);
devices.Add(dell);

Device asus = new Laptop(manufacturer: "ASUS",
    model: "Vivobook S16",
    price: 1399.99m,
    processor: "AMD Ryzen 7 5800H",
    ramGb: 16,
    storageGb: 512,
    screenSizeInches: 16.0);
devices.Add(asus);

Console.WriteLine("\nСписок пристроїв: ");
foreach (Device dev in devices)
{
    if(dev is Phone) // перевірка типу об'єкта
    {
        Console.WriteLine($"\n>>> Телефон: ");
        Phone? phone = dev as Phone; // приведення типу
        Console.WriteLine(phone);

    }
    if (dev is Laptop)
    {
        Console.WriteLine($"\n>>> Ноутбук: ");
        Laptop? laptop = (Laptop)dev; // приведення типу
        Console.WriteLine(laptop);
    }
    
    // те саме можна записати так:
    // Console.WriteLine(s25);
    // Console.WriteLine(motorola);
    // Console.WriteLine(dell);
    // Console.WriteLine(asus);
}
