// Product class definition
public class Product
{
    // Attributes
    private string code;

    // Properties
    public string Name { get; set; }
    public string Description { get; set; }
    public float Price { get; set; }
    public int Vat { get; set; }

    List<float> priceHistory = new List<float>();

    // Constructor
    public Product(string name, string description, float price, int vat)
    {
        code = GenerateProductCode();
        Name = name;
        Description = description;
        Price = price;
        priceHistory.Add(price);
        Vat = vat;
    }

    // Methods
    private string GenerateProductCode()
    {
        Random rnd = new Random();
        return code = rnd.Next(00000000, 99999999).ToString();
    }

    public void GetProductCode()
    {
        Console.WriteLine($"{Name} product code is {code}");
    }

    public void GetNoVatPrice()
    {
        Console.WriteLine($"{Name} product no vat price is {Price} €");
    }

    public void GetExtendedName()
    {
        Console.WriteLine($"Extended name: {Name} - {code}");
    }

    public float GetVatPrice()
    {
        return calculateVatPrice(Price, Vat);
    }

    public void GetProductInfo()
    {
        Console.WriteLine($@"
                            PRODUCT INFO
                            - Product name: {Name}
                            - Product code: {code}
                            - Product description: {Description}
                            - Product price(no vat): {Price}€
                            - Product final price: {GetVatPrice()}€
                            ");
    }

    public void discountProduct(int discountAmount)
    {
        float discountedPrice = Price - ((Price * discountAmount) / 100f);
        float roundedDiscountedPrice = (float)Math.Round(discountedPrice, 2);
        Price = roundedDiscountedPrice;

        float previousPrice = priceHistory.Last();

        priceHistory.Add(roundedDiscountedPrice);

        Console.WriteLine($"The {discountAmount}% offer of the week is '{Name}'! Previous price was {calculateVatPrice(previousPrice, Vat)}€, Discounted price is {GetVatPrice()}€");
    }

    public void showPriceHistory()
    {
        Console.Write($"{Name} price history: ");
        foreach (float price in priceHistory)
        {
            Console.Write($"{calculateVatPrice(price, Vat)}€ - ");
        }

        Console.WriteLine();
    }

    public float calculateVatPrice(float price, int vat)
    {
        float vatPrice = (price * vat) / 100f + price;
        return (float)Math.Round(vatPrice, 2);
    }
}

