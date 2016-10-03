using System.Windows.Input;
using MvvmCross.Core.ViewModels;

namespace SunCorp.IRecover.ViewModels.Drawer
{
    public class MenuViewModel : MvxViewModel
    {
        #region private fields
        
        private ICommand mHeaderClickedCommand;

        #endregion

        public MenuViewModel() : base()
        {
        }

       

        #region private methods
        
        #endregion
      

        #region public methods

        public void GoToNewClaim()
        {
            ShowViewModel<NewClaimViewModel>();
        }

        public void GoToProfile()
        {
            ShowViewModel<ProfileViewModel>();
        }

        public void GoToContactUs()
        {
            ShowViewModel<ContactUsViewModel>();
        }
        #endregion

        #region private methods

        #endregion


    }
}