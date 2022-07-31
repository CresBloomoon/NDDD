using NDDD.Domain.Entities;
using System.Collections.Generic;

namespace NDDD.Domain.Repositories
{
    public interface IMeasureRepository
    {
        MeasureEntity GetLatest();

        IReadOnlyList<MeasureEntity> GetLatests();
    }
}
