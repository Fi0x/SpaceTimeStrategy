using System.Collections.Generic;
using STSLogic.ControllableObjects;

namespace STSLogic
{
    public class Player
    {
        private readonly string _playerId;
        private readonly List<IBuilding> _buildings;
        private readonly List<IUnit> _units;
        
        public Player(string id)
        {
            _playerId = id;
            _buildings = new List<IBuilding>();
            _units = new List<IUnit>();
        }
        
        public string PlayerID
        {
            get => _playerId;
        }
        public List<IBuilding> Buildings
        {
            get => _buildings;
        }

        public List<IUnit> Units
        {
            get => _units;
        }
        public long CurrentTime { get; set; }
    }
}