using NDDD.Domain.ValueObjects;
using System;

namespace NDDD.Domain.Entities
{
    /// <summary>
    /// 計測エンティティ
    /// </summary>
    public sealed class MeasureEntity
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="areaId">エリアID</param>
        /// <param name="measureDate">計測日時</param>
        /// <param name="measureValue">計測値</param>
        public MeasureEntity(
            int areaId,
            DateTime measureDate,
            float measureValue)
        {
            AreaId = new AreaId(areaId);
            MeasureDate = new MeasureDate(measureDate);
            MeasureValue = new MeasureValue(measureValue);
        }

        /// <summary>
        /// エリアID
        /// </summary>
        public AreaId AreaId { get; }
        /// <summary>
        /// 計測日時
        /// </summary>
        public MeasureDate MeasureDate { get; }
        /// <summary>
        /// 計測値
        /// </summary>
        public MeasureValue MeasureValue { get; }
    }
}
