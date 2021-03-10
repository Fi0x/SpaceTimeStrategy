using System.Collections.Generic;

namespace STSLogic.ControllableObjects
{
    public interface IControllable
    {
        public List<Location> GetUnitLocations();
    }
}