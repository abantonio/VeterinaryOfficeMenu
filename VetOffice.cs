namespace VeterinaryOffice;

public class VetOffice{
    public string? Name{get; set;}
    public string? Address{get; set;}
    public PatientRegistry Customers { get; set; } = new PatientRegistry();
    public VetOffice(){}
    public VetOffice(string name, string address){
        this.Name = name;
        this.Address = address;
    }

    public void AddCustomer(Owner person, Pet animal){
        if(Customers.AddPatient(person, animal)){
            Console.WriteLine("Customer information added successfully");
        }
        else{
            Console.WriteLine("Customer could not be added");
        }
    }
    public void AddOwner(Owner person){
        if(Customers.AddOwner(person)){
            Console.WriteLine("Owner added successfully");
        }
        else{
            Console.WriteLine("Customer already exists");
        }
    }
}