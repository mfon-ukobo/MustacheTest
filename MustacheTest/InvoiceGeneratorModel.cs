using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MustacheTest;
public class InvoiceGeneratorModel
{
	public required Invoice Invoice { get; set; }
	public required Company Company { get; set; }
}


public class Invoice
{
	public IEnumerable<InvoiceItem> Items { get; set; } = Enumerable.Empty<InvoiceItem>();
}

public class InvoiceItem
{
    [SetsRequiredMembers]
    public InvoiceItem(string description, decimal amount)
    {
        Description = description;
        Amount = amount;
    }

    public required string Description { get; set; }
	public decimal Amount { get; set; } = 0;
}

public class Company(string name)
{
    public string Name { get; set; } = name;
}