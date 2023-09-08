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

    // Constructor
    public Product(string name, string description, float price, int vat)
    {
        code = GenerateProductCode();
        Name = name;
        Description = description;
        Price = price;
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

    public void GetVatPrice()
    {
        float vatPrice = (Price * (float)Vat) / 100f + Price;
        double roundedVatPrice = Math.Round(vatPrice, 2);
        string stringRoundedVatPrice = roundedVatPrice.ToString();
        Console.WriteLine($"{Name} product vat price is {stringRoundedVatPrice} €");
    }
}

