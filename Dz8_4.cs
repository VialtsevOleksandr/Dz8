namespace Dz8_4;

interface IDiscountable
{
    void ApplyDiscount(String discount);
    void ApplyPromocode(String promocode);
}
interface IColoredAndSized
{
    void SetColor(byte color);
    void SetSize(byte size);
}
interface IPriced
{
    void SetPrice(double price);
}
class Book : IDiscountable, IPriced
{
    private double price;
    private string discount;
    private string promocode;

    public void ApplyDiscount(String discount)
    {
        this.discount = discount;
        Console.WriteLine($"Знижка {discount} застосована до книги.");
    }

    public void ApplyPromocode(String promocode)
    {
        this.promocode = promocode;
        Console.WriteLine($"Промокод {promocode} застосований до книги.");
    }

    public void SetPrice(double price)
    {
        this.price = price;
        Console.WriteLine($"Ціна книги встановлена на {price} гривень.");
    }
}
class Clothing : IDiscountable, IColoredAndSized, IPriced
{
    private double price;
    private string discount;
    private string promocode;
    private byte color;
    private byte size;
    public void ApplyDiscount(String discount)
    {
        this.discount = discount;
        Console.WriteLine($"Знижка {discount} застосована до одягу.");
    }

    public void ApplyPromocode(String promocode)
    {
        this.promocode = promocode;
        Console.WriteLine($"Промокод {promocode} застосований до одягу.");
    }

    public void SetColor(byte color)
    {
        this.color = color;
        Console.WriteLine($"Колір одягу встановлено на {color}.");
    }

    public void SetSize(byte size)
    {
        this.size = size;
        Console.WriteLine($"Розмір одягу встановлено на {size}.");
    }

    public void SetPrice(double price)
    {
        this.price = price;
        Console.WriteLine($"Ціна одягу встановлена на {price} гривень.");
    }
}