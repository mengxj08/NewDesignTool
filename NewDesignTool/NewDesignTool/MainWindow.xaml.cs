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
    public enum MODE { NewItem, CopyItem };
   
    public partial class MainWindow : ModernWindow
    {
        static public DataStructure datas = new DataStructure();
        private MODE modeType;
        private Boolean FLAG = true;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
           modeType = MODE.NewItem;

           //Indpedent variables
           datas.independentVariables.Add(new IndependentVariable());
           datas.independentVariables.Add(new IndependentVariable());
           datas.independentVariables.Add(new IndependentVariable());

           datas.independentVariables[0].subjectDesign = SUBJECTDESIGN.Between;
           datas.independentVariables[1].subjectDesign = SUBJECTDESIGN.Between;
           datas.independentVariables[2].subjectDesign = SUBJECTDESIGN.Between;

           datas.independentVariables[0].counterBalance = COUNTERBALANCE.LatinSquare;
           datas.independentVariables[1].counterBalance = COUNTERBALANCE.LatinSquare;
           datas.independentVariables[2].counterBalance = COUNTERBALANCE.LatinSquare;

           datas.independentVariables[0].levels.Add(new IndependentVariable.Level());
           datas.independentVariables[0].levels.Add(new IndependentVariable.Level());
           datas.independentVariables[0].levels.Add(new IndependentVariable.Level());
           datas.independentVariables[0].levels.Add(new IndependentVariable.Level());
           datas.independentVariables[1].levels.Add(new IndependentVariable.Level());
           datas.independentVariables[1].levels.Add(new IndependentVariable.Level());
           datas.independentVariables[1].levels.Add(new IndependentVariable.Level());
           datas.independentVariables[1].levels.Add(new IndependentVariable.Level());
           datas.independentVariables[2].levels.Add(new IndependentVariable.Level());
           datas.independentVariables[2].levels.Add(new IndependentVariable.Level());
           datas.independentVariables[2].levels.Add(new IndependentVariable.Level());
           datas.independentVariables[2].levels.Add(new IndependentVariable.Level());

           datas.independentVariables[0].levels[0].value = datas.researchQuestion.hypothesis.mainSolution;
           datas.independentVariables[0].levels[1].value = datas.researchQuestion.hypothesis.compareSolutions[0];

           datas.independentVariables[1].levels[0].value = datas.researchQuestion.hypothesis.context;
           datas.independentVariables[1].levels[1].value = "Quiet environment";

           datas.independentVariables[2].levels[0].value = datas.researchQuestion.hypothesis.tasks[0];
           datas.independentVariables[2].levels[1].value = "Multi Tasks";

            //Dependent
           datas.dependentVariables.Add(new DependentVariable());
           datas.dependentVariables.Add(new DependentVariable());
           datas.dependentVariables.Add(new DependentVariable());
           datas.dependentVariables[0].name = datas.researchQuestion.hypothesis.measures[0];

           //arrangement
           datas.arrangement.minNum = 8;
           datas.arrangement.actualNum = 12;
           datas.arrangement.trial = 3;
           datas.arrangement.block = 2;
           datas.arrangement.timePerTrial = 30;
           datas.arrangement.feePerParticipant = 10;

           BindingProcess();   
        }
        private void BindingProcess()
        { 
        }
    }
}
