namespace TDDExampleApp.Models.Response;

public class Item
{
    public string ProductId { get; set; }
    public decimal Quantity { get; set; }
    public bool Available { get; set; }

    public Item(string productId, decimal quantity)
    {
        ProductId = productId;
        Quantity = quantity;
    }

    public bool AvailableVerify(decimal quantity) => quantity > 0;
}
