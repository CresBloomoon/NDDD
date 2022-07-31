using NDDD.Domain.Entities;
using NDDD.Domain.Repositories;
using NDDD.Domain.StaticValues;
using NDDD.Domain.ValueObjects;
using NDDD.Infrastructure;
using System;
using System.Transactions;

namespace NDDD.WinForm.ViewModels
{
    /// <summary>
    /// 直近値のViewModel
    /// </summary>
    public sealed class LatestViewModel : ViewModelBase
    {
        /// <summary>
        /// 計測リポジトリ
        /// </summary>
        private MeasureRepository _measureRepository;

        /// <summary>
        /// エリアID
        /// </summary>
        private string _areaIdText = string.Empty;
        /// <summary>
        /// 計測日時
        /// </summary>
        private string _measureDateText = string.Empty;
        /// <summary>
        /// 計測値
        /// </summary>
        private string _measureValueText = string.Empty;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public LatestViewModel()
            :this(Factories.CreateMeasure())
        {

        }
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="measureRepository">計測リポジトリ</param>
        public LatestViewModel(IMeasureRepository measureRepository)
        {
            _measureRepository =
                new MeasureRepository(measureRepository);
        }
        /// <summary>
        /// 
        /// </summary>
        public string AreaIdText
        {
            get { return _areaIdText; }
            set { SetProperty(ref _areaIdText, value); }
        }
        /// <summary>
        /// 計測日時
        /// </summary>
        public string MeasureDateText
        {
            get { return _measureDateText; }
            set { SetProperty(ref _measureDateText, value); }
        }
        /// <summary>
        /// 計測値
        /// </summary>
        public string MeasureValueText
        {
            get { return _measureValueText; }
            set { SetProperty(ref _measureValueText, value); }
        }

        /// <summary>
        /// 検索
        /// </summary>
        public void Search()
        {
            //Search()が呼ばれたら、MeasureEntityをフィールドにて保持する
            //var measure = _measureRepository.GetLatest();
            var measure = Measures.GetLatest(new AreaId(10));


            AreaIdText = measure.AreaId.DisplayValue;
            MeasureDateText = measure.MeasureDate.DisplayValue;
            MeasureValueText = measure.MeasureValue.DisplayValue;
        }

        /// <summary>
        /// 保存
        /// </summary>
        public void Save()
        {
            using (var scope = new TransactionScope())
            {

                scope.Complete();
            }
        }
    }
}
