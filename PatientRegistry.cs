namespace VeterinaryOffice;

public class PatientRegistry{
    private int TotalPatients { get; set; } = 0;
    private int TotalOwners { get; set; } = 0;
    private int TotalPets { get; set; } = 0;
    private Dictionary<string, int> OwnerRegistry { get; } = new Dictionary<string, int>();
    private List<Owner> OwnerList{ get; } = new List<Owner>();
    public PatientRegistry(){}

    public int GetOwnerIndex (Owner person){
        int ownerIndex = -1;
        if(OwnerRegistry.ContainsKey(person.Name)){
            ownerIndex = OwnerRegistry[person.Name];
        }
        return ownerIndex;
    }
    public bool AddOwner (Owner person){
        int valOwnerIndex = GetOwnerIndex(person);
        //Add owner if it was not found in Registry
        if(valOwnerIndex < 0){
            OwnerList.Add(person);
            OwnerRegistry.Add(person.Name, TotalOwners);
            TotalOwners++;
            Console.WriteLine("New owner added to registry");
            return true;
        }
        else{
            Console.WriteLine("Owner already exists in registry");
        }
        return false;
    }
    public bool AddPatient (Owner person, Pet animal){
        /*
        * First > Check this.OwnerRegistry for Owner
        *       If does not exist, add owner using Total Owner count as refence value and last name as Key > Increase Owner count > add Owner to appropriate list
        *       Else grab the reference value > lookup Owner in appropriate list
        * Next  > Using Owner, check for Pet's existence
        *       If does not exist, add Pet to Owner Pet Dictionary using TotalPets as reference value and Name as Key > Increase Pet count > add Pet to appropriate list
        *       Else, tell user it exists/ return false
        */
        int valOwnerIndex = GetOwnerIndex(person);
        //if(TotalPatients == 0 && TotalOwners == 0){
        if(valOwnerIndex < 0){
            OwnerList.Add(person);
            OwnerRegistry.Add(person.Name, TotalOwners);
            valOwnerIndex = TotalOwners;
            TotalOwners++;
            Console.WriteLine("New owner added to registry");
        }
        if(OwnerList[valOwnerIndex].AddPet(animal)){
            TotalPets++;
            return true;
        }
        return false;
    }
}