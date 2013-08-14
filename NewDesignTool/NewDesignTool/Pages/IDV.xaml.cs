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
            //Indpedent variables
            NewDesignTool.MainWindow.datas.independentVariables.Add(new IndependentVariable());
            NewDesignTool.MainWindow.datas.independentVariables.Add(new IndependentVariable());
            NewDesignTool.MainWindow.datas.independentVariables.Add(new IndependentVariable());

            NewDesignTool.MainWindow.datas.independentVariables[0].name = "1";
            NewDesignTool.MainWindow.datas.independentVariables[1].name = "2";
            NewDesignTool.MainWindow.datas.independentVariables[2].name = "3";

            NewDesignTool.MainWindow.datas.independentVariables[0].subjectDesign = SUBJECTDESIGN.Between;
            NewDesignTool.MainWindow.datas.independentVariables[1].subjectDesign = SUBJECTDESIGN.Between;
            NewDesignTool.MainWindow.datas.independentVariables[2].subjectDesign = SUBJECTDESIGN.Between;

            NewDesignTool.MainWindow.datas.independentVariables[0].counterBalance = COUNTERBALANCE.LatinSquare;
            NewDesignTool.MainWindow.datas.independentVariables[1].counterBalance = COUNTERBALANCE.LatinSquare;
            NewDesignTool.MainWindow.datas.independentVariables[2].counterBalance = COUNTERBALANCE.LatinSquare;

            NewDesignTool.MainWindow.datas.independentVariables[0].levels.Add(new NewDesignTool.IndependentVariable.Level());
            NewDesignTool.MainWindow.datas.independentVariables[0].levels.Add(new NewDesignTool.IndependentVariable.Level());
            NewDesignTool.MainWindow.datas.independentVariables[0].levels.Add(new NewDesignTool.IndependentVariable.Level());
            NewDesignTool.MainWindow.datas.independentVariables[0].levels.Add(new NewDesignTool.IndependentVariable.Level());
            NewDesignTool.MainWindow.datas.independentVariables[1].levels.Add(new NewDesignTool.IndependentVariable.Level());
            NewDesignTool.MainWindow.datas.independentVariables[1].levels.Add(new NewDesignTool.IndependentVariable.Level());
            NewDesignTool.MainWindow.datas.independentVariables[1].levels.Add(new NewDesignTool.IndependentVariable.Level());
            NewDesignTool.MainWindow.datas.independentVariables[1].levels.Add(new NewDesignTool.IndependentVariable.Level());
            NewDesignTool.MainWindow.datas.independentVariables[2].levels.Add(new NewDesignTool.IndependentVariable.Level());
            NewDesignTool.MainWindow.datas.independentVariables[2].levels.Add(new NewDesignTool.IndependentVariable.Level());
            NewDesignTool.MainWindow.datas.independentVariables[2].levels.Add(new NewDesignTool.IndependentVariable.Level());
            NewDesignTool.MainWindow.datas.independentVariables[2].levels.Add(new NewDesignTool.IndependentVariable.Level());

            NewDesignTool.MainWindow.datas.independentVariables[0].levels[0].name = "0";
            NewDesignTool.MainWindow.datas.independentVariables[0].levels[1].name = "1";
            NewDesignTool.MainWindow.datas.independentVariables[0].levels[2].name = "2";
            //ewDesignTool.MainWindow.datas.independentVariables[0].levels[1].value = NewDesignTool.MainWindow.datas.researchQuestion.hypothesis.compareSolutions[0];

            //NewDesignTool.MainWindow.datas.independentVariables[1].levels[0].value = NewDesignTool.MainWindow.datas.researchQuestion.hypothesis.context;
            NewDesignTool.MainWindow.datas.independentVariables[1].levels[1].name = "Quiet environment";

            //NewDesignTool.MainWindow.datas.independentVariables[2].levels[0].value = NewDesignTool.MainWindow.datas.researchQuestion.hypothesis.tasks[0];
            NewDesignTool.MainWindow.datas.independentVariables[2].levels[1].name = "Multi Tasks";
            bindingPorcess();
        }
        private void bindingPorcess()
        {
            this.tv.DataContext = NewDesignTool.MainWindow.datas.independentVariables;
        }
        private void del_item(object sender, RoutedEventArgs e)
        {
            if (tv.SelectedItem != null)
            {
                Log.getLogInstance().writeLog((tv.Items.IndexOf(tv.SelectedItem)).ToString());
               
                if (tv.Items.IndexOf(tv.SelectedItem) != -1)
                {
                    NewDesignTool.MainWindow.datas.independentVariables.RemoveAt(tv.Items.IndexOf(tv.SelectedItem));
                    return;
                }
                else
                {/*
                    NewDesignTool.IndependentVariable.Level tt = (NewDesignTool.IndependentVariable.Level) tv.SelectedItem;
                    foreach(NewDesignTool.IndependentVariable temp in NewDesignTool.MainWindow.datas.independentVariables)
                    {
                        if (temp.levels.Contains(tt))
                        {
                            Log.getLogInstance().writeLog("second");
                            temp.levels.Remove(tt);
                        }
                        
                    }
                    */
                }
            }
        }
        private void add_item(object sender,RoutedEventArgs e)
        { 

        }

    }
}
