using System;

namespace NDDD.WinForm.ViewModels
{
    public sealed class LatestViewModel : ViewModelBase
    {
        public string AreaIdText { get; set; }
        public object MeasureDateText { get; set; }
        public object MeasureValueText { get; set; }

        public void Search()
        {
            throw new NotImplementedException();
        }
    }
}
