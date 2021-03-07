using System.ComponentModel.Design.Serialization;

namespace STSLogic
{
    public class LogicController
    {
        private static LogicController _instance;
        private Player _ownPlayer;
        
        private LogicController()
        {
        }
        public static LogicController GetInstance()
        {
            if (_instance == null) _instance = new LogicController();
            return _instance;
        }

        public Player OwnPlayer
        {
            get => _ownPlayer;
            set => _ownPlayer = value;
        }
    }
}