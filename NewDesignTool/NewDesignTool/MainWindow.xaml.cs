using FirstFloor.ModernUI.Windows.Controls;
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

namespace NewDesignTool
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public enum MODE { NewItem, OpenItem };
   
    public partial class MainWindow : ModernWindow
    {
        static public DataStructure datas = new DataStructure();
        static public DataStructure datas;
        private MODE modeType;
        private Boolean FLAG = true;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
           modeType = MODE.NewItem;

           // //Dependent
           //datas.dependentVariables.Add(new DependentVariable());
           //datas.dependentVariables.Add(new DependentVariable());
           //datas.dependentVariables.Add(new DependentVariable());
           //datas.dependentVariables[0].name = datas.researchQuestion.hypothesis.measures[0];

           ////arrangement
           //datas.arrangement.minNum = 8;
           //datas.arrangement.actualNum = 12;
           //datas.arrangement.trial = 3;
           //datas.arrangement.block = 2;
           //datas.arrangement.timePerTrial = 30;
           //datas.arrangement.feePerParticipant = 10;

           BindingProcess();   
        }
        private void BindingProcess()
        { 
        }
    }
}
