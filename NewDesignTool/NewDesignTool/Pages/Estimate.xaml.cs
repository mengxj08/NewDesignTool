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
        public Estimate()
        {
            InitializeComponent();
            //arrangement
            NewDesignTool.MainWindow.datas.arrangement.minNum = 8;
            NewDesignTool.MainWindow.datas.arrangement.actualNum = 12;
            NewDesignTool.MainWindow.datas.arrangement.trial = 3;
            NewDesignTool.MainWindow.datas.arrangement.block = 2;
            NewDesignTool.MainWindow.datas.arrangement.timePerTrial = 30;
            NewDesignTool.MainWindow.datas.arrangement.feePerParticipant = 10;
            bindingProcess();
        }
        private void bindingProcess()
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
    }
}
