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
    /// Interaction logic for Estimate.xaml
    /// </summary>
    public partial class Estimate : UserControl
    {
        public static bool ESTIMATE_PAGE_FLAG = false;

        public Estimate()
        {
            InitializeComponent();

            BindingProcess();
        }
        private void BindingProcess()
        {
            trial.DataContext = NewDesignTool.MainWindow.datas.arrangement;
            block.DataContext = NewDesignTool.MainWindow.datas.arrangement;
            timePerTrial.DataContext = NewDesignTool.MainWindow.datas.arrangement;
            minNum.DataContext = NewDesignTool.MainWindow.datas.arrangement;
            actualNum.DataContext = NewDesignTool.MainWindow.datas.arrangement;
            feePerParticipant.DataContext = NewDesignTool.MainWindow.datas.arrangement;
            totalpayment.DataContext = NewDesignTool.MainWindow.datas.arrangement;
            totaltimecost.DataContext = NewDesignTool.MainWindow.datas.arrangement;
        }

        private void EstimateWindow_Loaded(object sender, RoutedEventArgs e)
        {
            if (ESTIMATE_PAGE_FLAG)
            {
                BindingProcess();
                ESTIMATE_PAGE_FLAG = false;
            }
        }
    }
}
