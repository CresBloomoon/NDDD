using System;
using System.Linq;

namespace NDDD.Domain.Helpers
{
    public static class FloatHelper
    {
        /// <summary>
        /// decimalPointで指定した小数までを0で埋める
        /// 例）decimalPointが3なら、1.2を1.200にする
        /// </summary>
        /// <param name="value"></param>
        /// <param name="decimalPoint"></param>
        /// <returns></returns>
        public static string RoundString(this float value,
            int decimalPoint)
        {
            value = Convert.ToSingle(Math.Round(value, decimalPoint));
            return value.ToString(decimalPoint == 0 ?
                String.Empty : "." +
                String.Concat(Enumerable.Repeat("0", decimalPoint)));
        }
    }
}
