using NDDD.Domain.Entities;
using NDDD.Domain.Repositories;
using NDDD.Infrastructure;
using System;

namespace NDDD.WinForm.ViewModels
{
    public sealed class LatestViewModel : ViewModelBase
    {
        private IMeasureRepository _measureRepository;

        private string _areaIdText = string.Empty;
        private string _measureDateText = string.Empty;
        private string _measureValueText = string.Empty;

        public LatestViewModel()
            :this(Factories.CreateMeasure())
        {

        }
        public LatestViewModel(IMeasureRepository measureRepository)
        {
            _measureRepository = measureRepository;
        }
        public string AreaIdText
        {
            get { return _areaIdText; }
            set { SetProperty(ref _areaIdText, value); }
        }
        public string MeasureDateText
        {
            get { return _measureDateText; }
            set { SetProperty(ref _measureDateText, value); }
        }
        public string MeasureValueText
        {
            get { return _measureValueText; }
            set { SetProperty(ref _measureValueText, value); }
        }

        public void Search()
        {
            //Search()が呼ばれたら、MeasureEntityをフィールドにて保持する
            var measure = _measureRepository.GetLatest();
            AreaIdText = measure.AreaId.DisplayValue;
            MeasureDateText = measure.MeasureDate.ToString("yyyy/MM/dd HH:mm:ss");
            MeasureValueText = Math.Round(measure.MeasureValue, 2) + "℃";
        }
    }
}
