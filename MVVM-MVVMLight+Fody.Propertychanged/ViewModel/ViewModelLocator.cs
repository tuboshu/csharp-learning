using CommonServiceLocator;
using GalaSoft.MvvmLight.Ioc;

namespace WpfApp1.ViewModel
{
    public class ViewModelLocator
    {

        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
            SimpleIoc.Default.Register<MainViewModel>();
        }

        public MainViewModel Main => ServiceLocator.Current.GetInstance<MainViewModel>();
        
        
        public static void Cleanup()
        {
            // TODO Clear the ViewModels
        }
    }
}