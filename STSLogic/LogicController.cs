using System.ComponentModel.Design.Serialization;

namespace STSLogic
{
    public class LogicController
    {
        private static LogicController _instance;
        private LogicController()
        {
        }

        public static LogicController GetInstance()
        {
            if (_instance == null) _instance = new LogicController();
            return _instance;
        }
    }
}