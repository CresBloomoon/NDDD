using NDDD.Domain.ValueObjects;
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
            AreaId = new AreaId(areaId);
            MeasureDate = new MeasureDate(measureDate);
            MeasureValue = new MeasureValue(measureValue);
        }

        public AreaId AreaId { get; }
        public MeasureDate MeasureDate { get; }
        public MeasureValue MeasureValue { get; }
    }
}
