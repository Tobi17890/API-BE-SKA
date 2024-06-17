namespace MyApiProject.Models
{
    public class CountryInfo
{
    public required string Name { get; set; }
    public required string Alpha2Code { get; set; }
    public required string Capital { get; set; }
    public List<string> CallingCodes { get; set; }
    public string FlagUrl { get; set; }
    public required List<string> Timezones { get; set; }
}
}