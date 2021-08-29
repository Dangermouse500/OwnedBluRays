using OwnedBluRays.Repository;
using System.Collections.ObjectModel;

namespace OwnedBluRays.ViewModels
{
    public class ShowOwnedBluRaysVm : BaseViewModel
    {
        private ObservableCollection<BluRay> _bluRays;

        public ObservableCollection<BluRay> BluRays
        {
            get => _bluRays;
            set
            {
                _bluRays = value;
                OnPropertyChanged("BluRays");
            }
        }

        public ShowOwnedBluRaysVm()
        {
            BluRays = new ObservableCollection<BluRay>(BluRayRepository.);
        }
    }
}