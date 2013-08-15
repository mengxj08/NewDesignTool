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
