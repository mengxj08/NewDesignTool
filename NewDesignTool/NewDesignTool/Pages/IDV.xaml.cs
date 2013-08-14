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

            NewDesignTool.MainWindow.datas.independentVariables[0].name = "Factor1";
            NewDesignTool.MainWindow.datas.independentVariables[1].name = "Factor2";
            NewDesignTool.MainWindow.datas.independentVariables[2].name = "Factor3";

            NewDesignTool.MainWindow.datas.independentVariables[0].subjectDesign = SUBJECTDESIGN.Between;
            NewDesignTool.MainWindow.datas.independentVariables[1].subjectDesign = SUBJECTDESIGN.Between;
            NewDesignTool.MainWindow.datas.independentVariables[2].subjectDesign = SUBJECTDESIGN.Between;

            NewDesignTool.MainWindow.datas.independentVariables[0].counterBalance = COUNTERBALANCE.LatinSquare;
            NewDesignTool.MainWindow.datas.independentVariables[1].counterBalance = COUNTERBALANCE.LatinSquare;
            NewDesignTool.MainWindow.datas.independentVariables[2].counterBalance = COUNTERBALANCE.LatinSquare;

            NewDesignTool.MainWindow.datas.independentVariables[0].levels.Add(new NewDesignTool.IndependentVariable.Level());
            NewDesignTool.MainWindow.datas.independentVariables[0].levels.Add(new NewDesignTool.IndependentVariable.Level());
            NewDesignTool.MainWindow.datas.independentVariables[0].levels.Add(new NewDesignTool.IndependentVariable.Level());
            NewDesignTool.MainWindow.datas.independentVariables[1].levels.Add(new NewDesignTool.IndependentVariable.Level());
            NewDesignTool.MainWindow.datas.independentVariables[1].levels.Add(new NewDesignTool.IndependentVariable.Level());
            NewDesignTool.MainWindow.datas.independentVariables[1].levels.Add(new NewDesignTool.IndependentVariable.Level());
            NewDesignTool.MainWindow.datas.independentVariables[2].levels.Add(new NewDesignTool.IndependentVariable.Level());
            NewDesignTool.MainWindow.datas.independentVariables[2].levels.Add(new NewDesignTool.IndependentVariable.Level());
            NewDesignTool.MainWindow.datas.independentVariables[2].levels.Add(new NewDesignTool.IndependentVariable.Level());

            NewDesignTool.MainWindow.datas.independentVariables[0].levels[0].name = "Factor1_1";
            NewDesignTool.MainWindow.datas.independentVariables[0].levels[1].name = "Factor1_2";
            NewDesignTool.MainWindow.datas.independentVariables[0].levels[2].name = "Factor1_3";
            //ewDesignTool.MainWindow.datas.independentVariables[0].levels[1].value = NewDesignTool.MainWindow.datas.researchQuestion.hypothesis.compareSolutions[0];

            //NewDesignTool.MainWindow.datas.independentVariables[1].levels[0].value = NewDesignTool.MainWindow.datas.researchQuestion.hypothesis.context;
            NewDesignTool.MainWindow.datas.independentVariables[1].levels[0].name = "Quiet environment";
            NewDesignTool.MainWindow.datas.independentVariables[1].levels[1].name = "Noisy environment"; 
            NewDesignTool.MainWindow.datas.independentVariables[1].levels[2].name = "Random";
            //NewDesignTool.MainWindow.datas.independentVariables[2].levels[0].value = NewDesignTool.MainWindow.datas.researchQuestion.hypothesis.tasks[0];
            NewDesignTool.MainWindow.datas.independentVariables[2].levels[0].name = "Multi Tasks";
            NewDesignTool.MainWindow.datas.independentVariables[2].levels[1].name = "Single Tasks";
            NewDesignTool.MainWindow.datas.independentVariables[2].levels[2].name = "No Tasks";
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
