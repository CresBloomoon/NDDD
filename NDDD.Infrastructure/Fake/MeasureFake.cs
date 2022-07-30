using NDDD.Domain.Entities;
using NDDD.Domain.Repositories;
using System;

namespace NDDD.Infrastructure.Fake
{
    internal sealed class MeasureFake : IMeasureRepository
    {
        internal const string FakePath = @"C:\NDDDFake\";
        public MeasureEntity GetLatest()
        {
            try
            {
                var lines = System.IO.File.ReadAllLines(FakePath + "MeasureFake.csv");
                var value = lines[0].Split(',');
                return new MeasureEntity(
                    Convert.ToInt32(value[0]),
                    Convert.ToDateTime(value[1]),
                    Convert.ToSingle(value[2]));
            }
            catch
            {
                return new MeasureEntity(
                    10,
                    Convert.ToDateTime("2020/12/12 12:34:56"),
                    123.341f);
            }


        }
    }
}
