using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;




namespace HackATL_EEVM
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Agenda : TabbedPage
    {
        public Agenda()
        {
            InitializeComponent();
            tabPage.CurrentPageChanged += TabPage_CurrentPageChanged;
           
        }
        private void TabPage_CurrentPageChanged(object sender, EventArgs e)
        {
            var tabbedPage = (TabbedPage)sender;
            if (tabPage.CurrentPage.TabIndex == 0)
            {
                tabPage.CurrentPage.IconImageSource = ImageSource.FromResource("AgendaSelected.png");
                var page = tabPage.Children.Where(X => X.TabIndex != 1).ToArray();
                page[0].IconImageSource = ImageSource.FromResource("AgendaNotSelected.png");
            }
            else
            {
                tabPage.CurrentPage.IconImageSource = ImageSource.FromResource("AgendaNotSelected.png");
                var page = tabPage.Children.Where(x => x.TabIndex != 1).ToArray();
                page[0].IconImageSource = ImageSource.FromResource("AgendaSelected.png");
            }
        }
    }
}