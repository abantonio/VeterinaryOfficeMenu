namespace VeterinaryOffice;

public class Owner{
    public string? Name { get; set; }
    public string? Address { get; set; }
    public Owner() {}
    public Owner(string? name, string? address){
        this.Name = name;
        this.Address = address;
    }
}