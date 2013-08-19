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
    /// Interaction logic for RQ_list2.xaml
    /// </summary>
    public partial class RQ_list2 : UserControl
    {

        public RQ_list2()
        {
            InitializeComponent();
            BindingProcess();
        }
        private void BindingProcess()
        {
            this.RQ_experimentConductor.DataContext = NewDesignTool.MainWindow.datas;
            this.RQ_experimentTitle.DataContext = NewDesignTool.MainWindow.datas;
            this.RQ_experimentDescription.DataContext = NewDesignTool.MainWindow.datas;
        }

    }
}
