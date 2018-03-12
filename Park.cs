using System;
using static System.Console;

namespace National_Parks
{
    class Park
    {
        public String parkName;
        public String location;
        public String parkType;
        public String facilities;
        public int employees;
        public int annualVisitors;
        private double budget;
        private double fee;

        //Constructors
        public Park()
        {

        }

        public Park(String parkName, String location, String facilities)
        {
            this.parkName = parkName;
            this.location = location;
            this.facilities = facilities;
        }

        public Park(String parkName, String location, double Fee)
        {
            this.parkName = parkName;
            this.location = location;
            this.Fee = Fee;
        }


        //Private Field for Budget Getter and Setter
        public double Budget
        {
            get
            {
                return budget;
            }
            set
            {
                budget = value;
            }

        }

        //Private Field for Fee Getter and Setter
        public double Fee
        {
            get
            {
                return fee;
            }
            set
            {
                fee = value;
            }

        }


        //Calculate Price spent on each visitors
        public double PricePerVisitor()
        {
            return Budget / annualVisitors;
        }

        //Calculating Revenue from fees
        public double RevenueFromFees()
        {
            return annualVisitors * Fee;
        }

        //ToString method to print out all of the variables and methods
        public override string ToString()
        {
            return "Park: " + parkName + "\nPark Location: " + location + "\nType of Park: " + parkType
                + "\nFacilities Available: " + facilities + "\nEntrance Fee: " + Fee.ToString("C")
                + "\nNumber of Employees: " + employees.ToString("N0") + "\nNumber of Visitors Last Year: " + annualVisitors.ToString("N0")
                + "\nAnnual Budget: " + Budget.ToString("C") + "\nRevenue From Fees: " + RevenueFromFees().ToString("C")
                + "\nCost Per Visitor: " + PricePerVisitor().ToString("C");
        }
    }
}

