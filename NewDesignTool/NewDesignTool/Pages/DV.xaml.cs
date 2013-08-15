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
    /// Interaction logic for DV.xaml
    /// </summary>
    public partial class DV : UserControl
    {
        public static bool DV_PAGE_FLAG = false;

        public DV()
        {
            InitializeComponent();

            BindingProcess();
        }
        private void BindingProcess()
        {
            tv.DataContext = NewDesignTool.MainWindow.datas.dependentVariables;
        }
        private void add_item(object sender, RoutedEventArgs e)
        {
            if (addItemText.Text != "")
            {
                NewDesignTool.DependentVariable dv = new NewDesignTool.DependentVariable();
                dv.name = addItemText.Text;
                NewDesignTool.MainWindow.datas.dependentVariables.Add(dv);
            }
        }
        private void del_item(object sender, RoutedEventArgs e)
        {
            if (tv.SelectedItem != null)
            {
                NewDesignTool.DependentVariable dv = (NewDesignTool.DependentVariable) tv.SelectedItem;
                NewDesignTool.MainWindow.datas.dependentVariables.Remove(dv);
            }
        }

        private void DVWindow_Loaded(object sender, RoutedEventArgs e)
        {
            if (DV_PAGE_FLAG)
            {
                BindingProcess();
                DV_PAGE_FLAG = false;
            }
        }
    }
}
