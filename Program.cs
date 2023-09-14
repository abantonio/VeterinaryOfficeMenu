// See https://aka.ms/new-console-template for more information
using System.Threading.Tasks;
using System.Collections.Generic;
namespace VeterinaryOffice{
    
    class Program{
        static void Main(string[] args){
            //Get the user's name to be polite
            Console.Write("Please enter your name: ");
            var name = Console.ReadLine();
            Console.WriteLine($"\nGreetings {name}!\n\nWelcome to Veterinary Menu vBETA");

            //Pause to separate beginning of program
            for(int i = 0; i < 2; i++){
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine(".");
            }

            //Get the name of the veterinary office
            Console.Write("Please enter the name of the vet: ");
            var vetName = Console.ReadLine();
            
            //Validate entry
            while(vetName == null || vetName == ""){
                Console.Write("Invalid name\nPlease enter the name of the Vet: ");
                vetName = Console.ReadLine();
            }

            //Initialize VetOffice object and set the name
            VetOffice myVetOffice = new VetOffice();
            myVetOffice.Name = vetName;
            
            //Pause to simulate loading
            for(int i = 0; i < 3; i++){
                System.Threading.Thread.Sleep(500);
                Console.Write(".");
            }
            Console.WriteLine();

            //Menu system loop until user exits
            bool go = true;
            while(go){
                Console.WriteLine($"{vetName}\'s Main Menu:\n");
                Console.WriteLine("1. Add Customer");
                Console.WriteLine("2. Customer Lookup");
                Console.WriteLine("3. View Animals due for yearly shot");
                Console.WriteLine("0. Quit Program");
                Console.Write("\nChoose action: ");
                var choiceMainMenu = Console.ReadLine();
                // while(choiceMainMenu == null || choiceMainMenu == ""){
                //     Console.Write("Invalid input\nChoose an action: ");
                //     choiceMainMenu = Console.ReadLine();
                // }

                switch(choiceMainMenu){
                    case "1":
                        Console.WriteLine("Add customer");
                        addCustomer(myVetOffice);
                        break;
                    case "2":
                        Console.WriteLine("Customer lookup");
                        customerLookup();
                        break;
                    case "3":
                        Console.WriteLine("View Animals shots due");
                        break;
                    case "0":
                        Console.WriteLine($"Thank you for using the application!\nGood bye {name}!");
                        break;
                    default:
                        Console.WriteLine("\nInvalid choice\n");
                        System.Threading.Thread.Sleep(750);
                        break;
                }
                
                go = !(choiceMainMenu == "0");
            }
            
        }

        private static string ValidateStringInput(){
            var input = Console.ReadLine();
            while(input == null || input == ""){
                Console.Write("Input cannot be blank or null\nPlease try again: ");
                input = Console.ReadLine();
            }
            return input;
        }

        private static void addCustomer(VetOffice myVetOffice){
            string ownerName;
            string ownerAddress;
            string newPetName;
            string newPetType;
            Console.WriteLine("Please choose:");
            Console.WriteLine("1. Add new owner and pet");
            Console.WriteLine("2. Add pet to existing owner");
            Console.WriteLine("\n0. Return to Main Menu");
            Console.Write("Choice: ");
            var choiceAddMenu = Console.ReadLine();
            while(choiceAddMenu == null || choiceAddMenu == ""){
                Console.Write("Invalid input\nChoice: ");
                choiceAddMenu = Console.ReadLine();
            }

            switch(choiceAddMenu){
                case "1":
                    Console.Write("Enter owner name: ");
                    ownerName = ValidateStringInput();
                    Console.Write("Enter owner address: ");
                    ownerAddress = ValidateStringInput();
                    Owner newOwner = new Owner(ownerName, ownerAddress);
                    Console.Write("Enter pet name: ");
                    newPetName = ValidateStringInput();
                    Console.Write("Enter pet type: ");
                    newPetType = ValidateStringInput();
                    Pet newPet = new Pet(newPetName, newPetType);
                    myVetOffice.AddCustomer(newOwner, newPet);
                    break;
                case "2":
                    Console.WriteLine("Choice under development");
                    //Console.Write("Enter owner name: ");
                    break;
                default:
                    Console.WriteLine("Choice under development");
                    break;
            }
            return;
        }

        private static void customerLookup(){
            Console.WriteLine("What information would you like to view");
            Console.WriteLine("1. View All Customer Information");
            Console.WriteLine("2. View All Owners");
            Console.WriteLine("3. View All Animals");
            Console.WriteLine("\n0. Return to Main Menu");
            Console.Write("Choice: ");
            var choiceLookupMenu = Console.ReadLine();
            while(choiceLookupMenu == null || choiceLookupMenu == ""){
                Console.Write("Invalid input\nChoice: ");
                choiceLookupMenu = Console.ReadLine();
            }
            return;
        }
    }
}