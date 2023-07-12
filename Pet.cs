namespace VeterinaryOffice;

public class Pet{
    public string? Name { get; set; }
    public string? Type { get; set; }
    public int Weight { get; set; }
    public Pet() {}
    public Pet(string? name, string type, int weight){
        this.Name = name;
        this.Type = type;
        this.Weight = weight;
    }
    public Pet(string? name, string? type){
        this.Name = name;
        this.Type = type;
    }
}