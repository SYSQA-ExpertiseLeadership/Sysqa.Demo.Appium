using System.Collections.Generic;

namespace Sysqa.Demo.SkyPoints.Utilities
{
    public static class TestLogger
    {
        private static List<string> _log;
        public static List<string> Log { get { return _log; } }
        public static void AddToLog(string x)
        {
            if (_log == null)
            {
                _log = new List<string>();
            }
            _log.Add(x);
        }
    }
}
