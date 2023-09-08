// Product class definition
public class Product
{
    // Attributes
    private string code;
    private string name;
    private string description;
    private float price;
    private int vat;

    // Constructor
    public Product(string name, string description, float price, int vat)
    {
        code = GenerateProductCode();
        this.name = name;
        this.description = description;
        this.price = price;
        this.vat = vat;
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