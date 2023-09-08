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
        Console.WriteLine(code);
    }
}