using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NewDesignTool.Pages
{
    /// <summary>
    /// Interaction logic for RQ_list1.xaml
    /// </summary>
    public partial class RQ_list1 : UserControl
    {
        public static bool RQL1_PAGE_FLAG = false;

        public RQ_list1()
        {
            InitializeComponent();
            BindingProcess();
        }
        private void BindingProcess()
        {
            this.YourQuestion.DataContext = NewDesignTool.MainWindow.datas;
        }

        private void RQL1Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (RQL1_PAGE_FLAG)
            {
                BindingProcess();
                RQL1_PAGE_FLAG = false;
            }
        }
    }
}
