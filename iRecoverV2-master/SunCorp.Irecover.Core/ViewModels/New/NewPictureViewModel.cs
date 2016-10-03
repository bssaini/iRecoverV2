using System.Collections.ObjectModel;
using SunCorp.IRecover.ViewModels.Add;

namespace SunCorp.IRecover.ViewModels.New
{
    public class NewPictureViewModel : NewItemViewModel
    {
        public override void SaveAction()
        {
            Close(this);
        }
    }
}
