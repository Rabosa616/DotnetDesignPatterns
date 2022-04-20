namespace Builder.FacetedBuilder;

public class Person
{
    // Address
    public string StreetAddress { get; set; }

    public string Postcode { get; set; }

    public string City { get; set; }

    // Employment
    public string CompanyName { get; set; }

    public string Position { get; set; }

    public int AnnualIncome { get; set; }

    public override string ToString()
    {
        return $"{StreetAddress}, {Postcode}, {City}, {CompanyName}, {Position}, {AnnualIncome}";
    }
}