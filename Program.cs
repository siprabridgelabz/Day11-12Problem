namespace InventoryManagement
{
    class program
    {
        public static void Main(string[] args)
        {
            string path = "C:\\Users\\Lenovo\\source\\repos\\InventoryManagement\\InventoryManagement\\Inventory.json";
            ReadInventory obj = new ReadInventory();
            InventoryDetails data = obj.Read(path);

            Console.WriteLine("Types of Rice");
            
            for(int i=0;i<data.typesOfRice.Count;i++)
            {

                Console.WriteLine(data.typesOfRice[i].name);
                Console.WriteLine(data.typesOfRice[i].weight);
                Console.WriteLine(data.typesOfRice[i].price);

                int val = data.typesOfRice[i].weight * data.typesOfRice[i].price;

                Console.WriteLine("The price of {0} for {1}kg is {2}rs", data.typesOfRice[i].name, data.typesOfRice[i].weight, val);               
                Console.WriteLine("******************");
            }

            Console.WriteLine("Types of Wheet");

            for (int i = 0; i < data.typesOfWheet.Count; i++)
            {

                Console.WriteLine(data.typesOfWheet[i].name);
                Console.WriteLine(data.typesOfWheet[i].weight);
                Console.WriteLine(data.typesOfWheet[i].price);

                int val = data.typesOfWheet[i].weight * data.typesOfWheet[i].price;

                Console.WriteLine("The price of {0} for {1}kg is {2}rs", data.typesOfWheet[i].name, data.typesOfWheet[i].weight, val);
                Console.WriteLine("******************");
            }

            Console.WriteLine("Types of Pulses");

            for (int i = 0; i < data.typesOfPulses.Count; i++)
            {

                Console.WriteLine(data.typesOfPulses[i].name);
                Console.WriteLine(data.typesOfPulses[i].weight);
                Console.WriteLine(data.typesOfPulses[i].price);

                int val = data.typesOfPulses[i].weight * data.typesOfPulses[i].price;

                Console.WriteLine("The price of {0} for {1}kg is {2}rs", data.typesOfPulses[i].name, data.typesOfPulses[i].weight, val);
                Console.WriteLine("******************");
            }


        }
    }
}
