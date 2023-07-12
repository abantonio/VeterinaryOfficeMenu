namespace VeterinaryOffice;

public class VetOffice{
    public string? Name{get; set;}
    public string? Address{get; set;}
    public VetOffice(){}
    public VetOffice(string name, string address){
        this.Name = name;
        this.Address = address;
    }
}