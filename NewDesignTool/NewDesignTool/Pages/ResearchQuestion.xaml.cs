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
    /// Interaction logic for ResearchQuestion.xaml
    /// </summary>
    public partial class ResearchQuestion : UserControl
    {
        public ResearchQuestion()
        {
            InitializeComponent();

            //NewDesignTool.MainWindow.datas.researchQuestion.experimentTitle = "Ipod and Earpod";
            //NewDesignTool.MainWindow.datas.researchQuestion.experimentConductor = "Sam";
            //NewDesignTool.MainWindow.datas.researchQuestion.experimentDescription = "This is an experiment to compare different technologies.";
            BindingProcess();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
        }
        private void BindingProcess()
        {
        }
    }
}
