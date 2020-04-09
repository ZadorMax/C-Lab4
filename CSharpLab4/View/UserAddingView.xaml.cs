using CSharpLab4.Navigation;
using CSharpLab4.ViewModel;
using System.Windows.Controls;

namespace CSharpLab4.View
{
    public partial class UserAddingView : UserControl, INavigatable
    {
        public UserAddingView()
        {
            DataContext = new UserAddingViewModel();
            InitializeComponent();
        }
    }
}
