using NDDD.Domain.Entities;
using System.Collections.Generic;

namespace NDDD.Domain.Repositories
{
    /// <summary>
    /// 計測リポジトリ
    /// </summary>
    public interface IMeasureRepository
    {
        /// <summary>
        /// 直近値の取得
        /// </summary>
        /// <returns></returns>
        MeasureEntity GetLatest();

        /// <summary>
        /// エリアごとの直近値を取得
        /// </summary>
        /// <returns></returns>
        IReadOnlyList<MeasureEntity> GetLatests();
    }
}
