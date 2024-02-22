namespace ElectricityBillManagement;

public class Vietnamese : Customer
{
    public string customerType { get; set; }
    public double dinhMuc { get; set; }
    public double newUnitPrice { get; set; }
    public override double CalculateTotal()
    {
        if (quatityKW <= dinhMuc)
        {
            return quatityKW * unitPrice;
        }
        else
        {
            return unitPrice * dinhMuc + (quatityKW - dinhMuc) * newUnitPrice;
        }
            

    }
}