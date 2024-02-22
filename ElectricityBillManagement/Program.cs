namespace ElectricityBillManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> listCustomer = new List<Customer>();
            
            Vietnamese vietnameseCustomer = new Vietnamese
            {
                customerID = "VN001",
                name = "Nguyen Van A",
                invoiceDate = new DateTime(2024, 2, 22),
                customerType = "sinh hoạt",
                quatityKW = 150,
                unitPrice = 1500,
                dinhMuc = 100,
                newUnitPrice = 2000
            };
            Vietnamese vietnameseCustomer2 = new Vietnamese
            {
                customerID = "VN002",
                name = "Nguyen Van B",
                invoiceDate = new DateTime(2024, 3, 22),
                customerType = "sinh hoạt",
                quatityKW = 150,
                unitPrice = 1200,
                dinhMuc = 50,
                newUnitPrice = 2000
            };
            Vietnamese vietnameseCustomer3 = new Vietnamese
            {
                customerID = "VN003",
                name = "Nguyen Van C",
                invoiceDate = new DateTime(2024, 4, 22),
                customerType = "sinh hoạt",
                quatityKW = 150,
                unitPrice = 2000,
                dinhMuc = 200,
                newUnitPrice = 2000
            };
            listCustomer.Add(vietnameseCustomer);
            listCustomer.Add(vietnameseCustomer2);
            listCustomer.Add(vietnameseCustomer3);

            ForeignCustomer foreignCustomer = new ForeignCustomer
            {
                customerID = "FR001",
                name = "John Doe",
                invoiceDate = new DateTime(2024, 2, 22),
                nationality = "USA",
                quatityKW = 150,
                unitPrice = 2000
            };
            listCustomer.Add(foreignCustomer);
            foreach (Customer customer in listCustomer)
            {
                Console.WriteLine($"Customer: {customer.name}, Total: {customer.CalculateTotal()}");
            }

            
        }
    }
}
