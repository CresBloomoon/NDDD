using NDDD.Domain.StaticValues;
using NDDD.Infrastructure;
using System.Threading;

namespace NDDD.WinForm.BackgroundWorkers
{
    /// <summary>
    /// 直近値のタイマー
    /// </summary>
    internal static class LatestTimer
    {
        /// <summary>
        /// タイマー
        /// </summary>
        private static Timer _timer;
        /// <summary>
        /// 処理中の時True
        /// </summary>
        private static bool _isWork = false;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        static LatestTimer()
        {
            //CallbackとはTimerが動作開始したときに実行する処理のこと
            _timer = new Timer(Callback);
        }

        /// <summary>
        /// スタート
        /// </summary>
        internal static void Start()
        {
            _timer.Change(0, 10000);
        }

        /// <summary>
        /// ストップ
        /// </summary>
        internal static void Stop()
        {
            _timer.Change(Timeout.Infinite, Timeout.Infinite);
        }

        /// <summary>
        /// コールバック
        /// </summary>
        /// <param name="o">オブジェクト</param>
        private static void Callback(object o)
        {
            if (_isWork) return;
            try
            {
                _isWork = true;
                Measures.Create(Factories.CreateMeasure());
            }
            finally
            {
                _isWork = false;
            }
        }
    }
}
