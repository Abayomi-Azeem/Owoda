namespace Assignment1
{
    
    internal class TollCalc
    {
        public TollCalc()
        {
        }  

        private bool Member(string isMem)
        {
            if (isMem.ToLower() == "y" )
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private enum VTypePrice
        {
            motorcycle = 1,
            tricycle = 2,
            minibus = 3,
            bus = 4,
        }
        private int TollPrice(int vtype)
        {
            if (vtype == (int)VTypePrice.motorcycle)
            {
                return 100;
            }else if (vtype == (int)VTypePrice.tricycle)
            {
                return 150;
            }else if (vtype == (int)VTypePrice.minibus)
            {
                return 180;
            }else if (vtype == (int)VTypePrice.bus)
            {
                return 200;
            }
            else { return 0; }
        }

        public double TollAmount(int vehicleType, int noOfTrips, string isMember)
        {
            var toll = new TollCalc();
            double baseAmount = toll.TollPrice(vehicleType);
            if (toll.Member(isMember))
            {
                baseAmount = baseAmount * 0.7;
            }
            return (baseAmount * noOfTrips);
        }

    }
    internal class Owoda
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to OWO DA APPLICATION");
            Console.WriteLine();    
            Console.WriteLine("Vehicle types are -- Motorcycle, Tricycle, Minibuses, Buses\n");
           
            double total = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("\nFor Motorcycle -- 1");
                Console.WriteLine("For Tricycle -- 2");
                Console.WriteLine("For Minibus -- 3");
                Console.WriteLine("For Bus -- 4\n");
                Console.WriteLine("What type of Vehicle ?");
                int vehicleType = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("How many trips has it gone? ");
                int noOfTrips = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Is the driver a N.U.R.T.W member?  y/n");
                var isMember = Console.ReadLine();
                if (isMember == null)
                {
                    isMember = "n";
                }

                var toll = new TollCalc();
                double tollCalc = toll.TollAmount(vehicleType, noOfTrips, isMember);
                total += tollCalc;
                Console.WriteLine("Your Toll Amount is " + Math.Round(tollCalc,2));

            }
            Console.WriteLine("Total Amount Collected for 5 random drivers is "+ Math.Round(total));
        }
    }
}