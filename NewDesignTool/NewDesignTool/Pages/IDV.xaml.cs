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
    /// Interaction logic for IDV.xaml
    /// </summary>
    public partial class IDV : UserControl
    {
        public IDV()
        {
            InitializeComponent();
            
            BindingProcess();
        }
        private void BindingProcess()
        {
            this.tv.DataContext = NewDesignTool.MainWindow.datas.independentVariables;
        }
        private void IDV_PageLoaded(object sender, RoutedEventArgs e)
        {

        }
        private void del_item(object sender, RoutedEventArgs e)
        {
            if (tv.SelectedItem != null)
            {
                //Log.getLogInstance().writeLog((tv.Items.IndexOf(tv.SelectedItem)).ToString());
               
                if (tv.Items.IndexOf(tv.SelectedItem) != -1)
                {
                    NewDesignTool.MainWindow.datas.independentVariables.RemoveAt(tv.Items.IndexOf(tv.SelectedItem));
                    return;
                }
                else
                {
                    NewDesignTool.IndependentVariable.Level selectedLevel = (NewDesignTool.IndependentVariable.Level) tv.SelectedItem;
                    foreach(NewDesignTool.IndependentVariable IDV in NewDesignTool.MainWindow.datas.independentVariables)
                    {
                        if (IDV.levels.Contains(selectedLevel))
                        {
                            //Log.getLogInstance().writeLog("second");
                            IDV.levels.Remove(selectedLevel);
                        }
                        
                    }
                    
                }
            }
        }
        private void add_item(object sender,RoutedEventArgs e)
        {
            if (addItemText.Text != "")
            {
                if (tv.SelectedItem == null)
                {
                    NewDesignTool.IndependentVariable idv = new NewDesignTool.IndependentVariable();
                    idv.name = addItemText.Text;
                    NewDesignTool.MainWindow.datas.independentVariables.Add(idv);
                }
                else if (tv.Items.IndexOf(tv.SelectedItem) != -1)
                {
                    NewDesignTool.IndependentVariable selectedIDV = (NewDesignTool.IndependentVariable)tv.SelectedItem;
                    NewDesignTool.IndependentVariable.Level level = new NewDesignTool.IndependentVariable.Level();
                    level.name = addItemText.Text;
                    selectedIDV.levels.Add(level);
                }
                else 
                { 
                }
            }
        }

    }
}
