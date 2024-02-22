namespace ElectricityBillManagement;

public class Customer
{
    public string customerID { get; set; }
    public string name { get; set; }
    public DateTime invoiceDate { get; set; }
    public double quatityKW { get; set; }
    public double unitPrice { get; set; }

    public virtual double calculateTotal()
    {
        return quatityKW * unitPrice;
    }
}