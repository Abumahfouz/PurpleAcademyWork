namespace Owoda
{
    /*
    public class VehicleDescription
    {
        private double tricycle;
        private double motorcycles;
        private double miniBus;
        private double brtBus;
        public double Tricycle
        {
            get { return tricycle; }
            set { tricycle = value; }
        }
        public double Motorcycle
        {
            get { return motorcycles; }
            set { motorcycles = value; }
        }
        public double MiniBus
        {
            get { return miniBus; }
            set { miniBus = value; }
        }
        public double BrtBus
        {
            get { return brtBus; }
            set { brtBus = value; }
        }
    } */
    public class Driver
    {
        public bool checkRegistration() //Ask driver to input reg number and return true or false depending on entry
        {
            string userID;
            Console.WriteLine("Please Enter your ID: ");
            userID = Console.ReadLine();      
            if (userID == null || userID == " ")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
    public class Calculator
    {
        public double tollCalculator()
        {
            int numOfTrips;
            Driver thisDriver = new Driver();
            Console.WriteLine("How many trips have driver taken?: ");
            numOfTrips = Convert.ToInt32(Console.ReadLine());
            bool regStatus;
            double tollFee;
            double discount;
            double discountedTollFee;
            double charge;
            regStatus = thisDriver.checkRegistration();
            Console.WriteLine("Enter vehicle type: (Motorcycle or Tricycle or Minibus or BRT");
         //   VehicleDescription newDriver = new VehicleDescription();
            string newVehicle = Console.ReadLine();
            string newNewVehicle = newVehicle.ToLower();
            if (newNewVehicle == "tricycle")
            {
                charge = 80;
            }
            else if (newNewVehicle == "motorcycle")
            {
                charge = 50;
            }
            else if ( newNewVehicle == "minibus")
            {
                charge = 100;
            }
            else if (newNewVehicle == "brt")
            {
                charge = 150;
            }
            else
            {
             Console.WriteLine("Enter valid vehicle type");
                charge = 0;
            }
            
            
            tollFee = numOfTrips * charge;
            if (regStatus == true)
            {
                discount = 0.3 * tollFee;
            }
            else
            {
                discount = 0;
            }
            discountedTollFee = (numOfTrips * charge) - discount;
            return discountedTollFee;
        }
    }

    internal class MyMoney
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 10; i++)
			{
                Calculator newFee = new Calculator();
                double myFee = newFee.tollCalculator();
                Console.WriteLine("Enter New User Name");
                string driverName = Console.ReadLine();
                Console.WriteLine("Hi "+ driverName + "! Your toll fee is " + myFee);
            }
            

        }

    }
}