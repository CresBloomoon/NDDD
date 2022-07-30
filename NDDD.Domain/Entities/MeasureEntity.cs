using System;

namespace NDDD.Domain.Entities
{
    public sealed class MeasureEntity
    {
        public MeasureEntity(
            int areaId,
            DateTime measureDate,
            float measureValue)
        {
            AreaId = areaId;
            MeasureDate = measureDate;
            MeasureValue = measureValue;
        }

        public int AreaId { get; }
        public DateTime MeasureDate { get; }
        public float MeasureValue { get; }
    }
}
