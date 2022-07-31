using NDDD.Domain;
using NDDD.Domain.Entities;
using NDDD.Domain.Exceptions;
using NDDD.Domain.Repositories;
using System;

namespace NDDD.Infrastructure.Fake
{
    internal sealed class MeasureFake : IMeasureRepository
    {
        public MeasureEntity GetLatest()
        {
            try
            {
                var lines = System.IO.File.ReadAllLines(
                    Shared.FakePath + "MeasureFake.csv");
                var value = lines[0].Split(',');
                return new MeasureEntity(
                    Convert.ToInt32(value[0]),
                    Convert.ToDateTime(value[1]),
                    Convert.ToSingle(value[2]));
            }
            catch(Exception ex)
            {
                throw new FakeException(
                    "MeasureFakeの取得に失敗しました",
                    ex);
                //return new MeasureEntity(
                //    10,
                //    Convert.ToDateTime("2020/12/12 12:34:56"),
                //    123.341f);
            }


        }
    }
}
