using System.Collections.Generic;

namespace STSLogic.ControllableObjects
{
    public interface IUnit
    {
        public UnitType GetUnitType();
        public List<Location> GetUnitLocations();
    }
    
    public enum UnitType
    {
        TimeMage,
        SpaceMage
    }
}