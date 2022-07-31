using System.Threading;

namespace NDDD.WinForm.BackgroundWorkers
{
    internal static class LatestTimer
    {
        private static Timer _timer;
        private static bool _isWork = false;

        static LatestTimer()
        {
            //CallbackとはTimerが動作開始したときに実行する処理のこと
            _timer = new Timer(Callback);
        }

        internal static void Start()
        {
            _timer.Change(10000, 10000);
        }

        internal static void Stop()
        {
            _timer.Change(Timeout.Infinite, Timeout.Infinite);
        }

        private static void Callback(object o)
        {
            if (_isWork) return;
            try
            {
                _isWork = true;
            }
            finally
            {
                _isWork = false;
            }
        }
    }
}
