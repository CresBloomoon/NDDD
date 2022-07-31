using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDDD.Domain.Logics
{
    /// <summary>
    /// EntitiesやValueObjectsに入らないような
    /// 共通ビジネスロジック置き場
    /// </summary>
    public static class MeasureAnalysis
    {
        public static float Execute(
            float value1,
            float value2,
            float value3,
            float value4,
            float value5)
        {
            return 999f;
        }
    }
}
