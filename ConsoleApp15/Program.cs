//Объявление перечисления происходит с помощью оператора enum
enum Typeofstore
{
    Food,
    Housewifely,
    Clothes,
    Shoes
}

class Shop : IDisposable
{
    // Поля класса
    private string Name;
    private string Address;
    private Typeofstore Type;

    // Конструктор класса
    public Shop(string name, string address, Typeofstore type)
    {
        this.Name = name;
        this.Address = address;
        this.Type = type;
    }

    // Свойства класса
    public string Name1
    {
        get { return Name; }
        set { Name = value; }
    }

    public string Address1
    {
        get { return Address; }
        set { Address = value; }
    }

    public Typeofstore Type1
    {
        get { return Type; }
        set { Type = value; }
    }

    // Метод для тестирования функциональности класса
    public void Inform()
    {
        Console.WriteLine($"Название: {Name}");
        Console.WriteLine($"Адрес: {Address}");
        Console.WriteLine($"Тип: {Type}");
    }

    // Реализация метода Dispose интерфейса IDisposable
    public void Dispose()
    {
        Console.WriteLine($"Магазин {Name} закрыт.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Создание объекта класса "Магазин"
        Shop shop = new Shop("Продуктовый магазин", "ул. Домашняя 2", Typeofstore.Food);

        // Вывод информации о магазине
        shop.Inform();

        // Вызов метода Dispose явно (может быть опущен, так как метод Dispose будет вызван автоматически при использовании блока using)
        shop.Dispose();

        // Использование блока using для автоматического вызова метода Dispose
        using (Shop shop2 = new Shop("Магазин одежды", "ул. Уходящая 1", Typeofstore.Clothes))
        {
            shop2.Inform();
        }
    }
}
