using CSharpLab4.Navigation;
using CSharpLab4.ViewModel;
using System.Windows.Controls;


namespace CSharpLab4.View
{
    public partial class UsersTableView : UserControl, INavigatable
    {
        public UsersTableView()
        {
            DataContext = new UsersTableViewModel();
            InitializeComponent();
        }
    }
}
