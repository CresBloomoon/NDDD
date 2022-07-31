using NDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDDD.Domain.Repositories
{
    /// <summary>
    /// 計測リポジトリ
    /// </summary>
    public sealed class MeasureRepository
    {
        /// <summary>
        /// 計測リポジトリ
        /// </summary>
        private IMeasureRepository _repository;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="repository">計測リポジトリ</param>
        public MeasureRepository(IMeasureRepository repository)
        {
            _repository = repository;
        }

        /// <summary>
        /// 直近値の取得
        /// 3回計測した平均を返却する
        /// </summary>
        /// <returns>平均値</returns>
        /// <exception cref="DataMisalignedException"></exception>
        public MeasureEntity GetLatest()
        {
            var val1 = _repository.GetLatest();
            if (val1 == null) throw new DataMisalignedException();
            System.Threading.Thread.Sleep(1000);
            var val2 = _repository.GetLatest();
            System.Threading.Thread.Sleep(1000);
            var val3 = _repository.GetLatest();
            System.Threading.Thread.Sleep(1000);

            var sum =
                val1.MeasureValue.Value +
                val2.MeasureValue.Value +
                val3.MeasureValue.Value;

            var ave = sum / 3f;
            return new MeasureEntity(
                val3.AreaId.Value,
                val3.MeasureDate.Value,
                ave);
        }
    }
}
