using DDD.Domain.ValueObjects;
using System;

namespace NDDD.Domain.ValueObjects
{
    public sealed class MeasureValue : ValueObject<MeasureValue>
    {
        public MeasureValue(float value)
        {
            Value = value;
        }
        public float Value { get; }

        public string DisplayValue => Math.Round(Value, 2) + "℃";

        protected override bool EqualsCore(MeasureValue other)
        {
            return this.Value == other.Value;
        }
    }
}
