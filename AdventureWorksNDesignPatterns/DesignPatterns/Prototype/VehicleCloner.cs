using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Prototype
{
    public enum VehicleType
    {
        Bike,
        Bus,
        Car
    };

    /// <summary>
    /// This class will be the for creating new instances 
    /// by creating the copies of existing
    /// </summary>
    public class VehicleCloner
    {
        private IDictionary<VehicleType, Vehicle> vehicleDictionary;

        private static VehicleCloner vehicleCloner;

        /// <summary>
        /// Private Constructor
        /// </summary>
        private VehicleCloner()
        {
            vehicleDictionary = new Dictionary<VehicleType, Vehicle>();
            vehicleDictionary[VehicleType.Bike] = new Bike();
            vehicleDictionary[VehicleType.Bus] = new Bus();
            vehicleDictionary[VehicleType.Car] = new Car();
        }

        public static VehicleCloner Instance
        {
            get
            {
                //Note: Not Threadsafe Singleton
                if(vehicleCloner==null)
                {
                    vehicleCloner = new VehicleCloner();
                }
                return vehicleCloner;
            }
        }

        /// <summary>
        /// This 
        /// </summary>
        /// <param name="vehicleType"></param>
        /// <returns></returns>
        public Vehicle CreatePrototype(VehicleType vehicleType)
        {
            return vehicleDictionary[vehicleType].Clone();
        }
    }
}
