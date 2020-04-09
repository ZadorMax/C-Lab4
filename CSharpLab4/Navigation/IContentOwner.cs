using System.Windows.Controls;

namespace CSharpLab4.Navigation
{
    internal interface IContentOwner
    {
        INavigatable Content { get; set; }
    }
}
