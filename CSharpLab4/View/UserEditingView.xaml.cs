
using CSharpLab4.Navigation;
using CSharpLab4.ViewModel;
using System.Windows.Controls;


namespace CSharpLab4.View
{
    public partial class UserEditingView : UserControl, INavigatable
    {
        public UserEditingView()
        {
            DataContext = new UserEditingViewModel();
            InitializeComponent();
        }
    }
}
