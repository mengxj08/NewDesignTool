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
        public DV()
        {
            InitializeComponent();
            //Dependent
            NewDesignTool.DependentVariable temp1 = new NewDesignTool.DependentVariable();
            temp1.name = "time cost";
            NewDesignTool.DependentVariable temp2 = new NewDesignTool.DependentVariable();
            temp2.name = "money cost";
            NewDesignTool.MainWindow.datas.dependentVariables.Add(temp1);
            NewDesignTool.MainWindow.datas.dependentVariables.Add(temp2);
            bindingProcess();
        }
        private void bindingProcess()
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
    }
}
