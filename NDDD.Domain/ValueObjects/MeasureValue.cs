using DDD.Domain.ValueObjects;
using NDDD.Domain.Helpers;

namespace NDDD.Domain.ValueObjects
{
    /// <summary>
    /// 計測値
    /// </summary>
    public sealed class MeasureValue : ValueObject<MeasureValue>
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="value"></param>
        public MeasureValue(float value)
        {
            Value = value;
        }
        /// <summary>
        /// 値
        /// </summary>
        public float Value { get; }

        //public string DisplayValue => Math.Round(Value, 2) + "℃";
        /// <summary>
        /// 表示する値
        /// </summary>
        public string DisplayValue => Value.RoundString(4) + "℃";

        /// <summary>
        /// EqualsCore
        /// </summary>
        /// <param name="other">比較する値</param>
        /// <returns>同じときTrue</returns>
        protected override bool EqualsCore(MeasureValue other)
        {
            return this.Value == other.Value;
        }
    }
}
