using System.Collections.Generic;

namespace STSLogic.ControllableObjects
{
    public interface IBuilding
    {
        public BuildingType GetBuildingType();
        public List<Location> GetBuildingLocations();
        public List<Upgrade> GetUpgrades();
    }

    public enum BuildingType
    {
        Base,
        Tower,
        Wall
    }
}