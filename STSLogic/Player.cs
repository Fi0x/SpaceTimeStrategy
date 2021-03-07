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
            get
            {
                return _playerId;
            }
        }
        public List<IBuilding> Buildings
        {
            get
            {
                return _buildings;
            }
        }

        public List<IUnit> Units
        {
            get
            {
                return _units;
            }
        }
        public long CurrentTime { get; set; }
    }
}