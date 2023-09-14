namespace VeterinaryOffice;

public class Owner{
    public string Name { get; set; } = "";
    public string Address { get; set; } = "";
    public int PetsOwned { get; set; } = 0;
    public Dictionary<string, int> PetReference { get; } = new Dictionary<string, int>();
    public List<Pet> PetList{ get; } = new List<Pet>();
    public Owner() {}
    public Owner(string name, string address){
        this.Name = name;
        this.Address = address;
    }

    public bool HasPet(Pet animal){
        return PetReference.ContainsKey(animal.Name);
    }
    public bool AddPet(Pet animal){
        if(!this.HasPet(animal)){
            PetReference.Add(animal.Name, PetsOwned);
            PetList.Add(animal);
            PetsOwned++;
            Console.WriteLine("Pet added to owner");
            return true;
        }
        else{
            Console.WriteLine("Pet already attributed to owner");
            return false;
        }
    }
}