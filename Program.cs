using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{//EDNA LYNN LAXA 
 //PROGRAMMING III
 //APRIL 22, 2023 
 //INHERITANCE 
    internal class Program
    {
        static List<Vehicle> vehicles = new List<Vehicle>(); // CREATING VEHICLE CLASS AS A LIST 
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle("Royal Peach"); // ACCESSING CLASS & PROVIDING REQUESTED PAREMETER INFO 
            Air air = new Air("Royal Forest"); // ACCESSING CLASS & PROVIDING REQUESTED PAREMETER INFO 
            Sea sea = new Sea("Royal Green", Sea.typeOfseamobile.submarine); // ACCESSING CLASS & PROVIDING REQUESTED PAREMETER INFO 
            Plane plane = new Plane("Royal Mint", 6); // ACCESSING CLASS & PROVIDING REQUESTED PAREMETER INFO 
            Helicopter helicopter = new Helicopter("Royal Lavender", 8); // ACCESSING CLASS & PROVIDING REQUESTED PAREMETER INFO 
            Land land = new Land("Royal Navy", 4); // ACCESSING CLASS & PROVIDING REQUESTED PAREMETER INFO 

            //ADDING vehicles 
            vehicles.Add(vehicle);  
            vehicles.Add(air);
            vehicles.Add(sea);
            vehicles.Add(plane);
            vehicles.Add(helicopter);
            vehicles.Add(land);

            // USING FOREACH to access the collectiong of VEHICLE 
            foreach (Vehicle v in vehicles)
            {
                Console.WriteLine(v);
            }
            Console.WriteLine();
        }
    }
}
