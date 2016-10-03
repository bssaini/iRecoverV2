using MvvmCross.Core.ViewModels;

namespace SunCorp.IRecover.Data
{
    public class ClaimModel :MvxViewModel
    {
        private string mName;
        private bool mIsResolved;

        public string Name
        {
            get { return mName; }
            set
            {
                mName = value;
                RaisePropertyChanged(() => Name);
            }
        }
        public bool IsResolved
        {
            get { return mIsResolved; }
            set
            {
                mIsResolved = value;
                RaisePropertyChanged(() => IsResolved);
            }
        }
    }
}
