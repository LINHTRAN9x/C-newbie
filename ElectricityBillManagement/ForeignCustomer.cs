﻿namespace ElectricityBillManagement;

public class ForeignCustomer : Customer
{
    public string nationality { get; set; }
    
    public override double CalculateTotal() => quatityKW * unitPrice;
}