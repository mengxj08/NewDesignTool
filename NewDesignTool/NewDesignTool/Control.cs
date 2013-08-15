using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewDesignTool
{
    class Control
    {
        private static Control control;
        private Boolean FLAG = true;
        private Control()
        {
           
        }
        public static Control getControlInstance()
        {
            if (control == null)
            {
                control = new Control();
            }
            return control;
        }
        public void RQContributeToVariable()
        {
            //global::NewDesignTool.MODE NewDesignTool.MainWindow.modeTyp;
            if (NewDesignTool.MainWindow.modeType == NewDesignTool.MODE.NewItem && FLAG)
            {
                FLAG = false;

                NewDesignTool.IndependentVariable suggest1 = new NewDesignTool.IndependentVariable("Technology");

                suggest1.levels.Add(new NewDesignTool.IndependentVariable.Level(NewDesignTool.MainWindow.datas.researchQuestion.hypothesis.mainSolution));
                foreach(string temp in NewDesignTool.MainWindow.datas.researchQuestion.hypothesis.compareSolutions)
                {
                    suggest1.levels.Add(new NewDesignTool.IndependentVariable.Level(temp));
                }
                NewDesignTool.MainWindow.datas.independentVariables.Add(suggest1);

                NewDesignTool.IndependentVariable suggest2 = new NewDesignTool.IndependentVariable("Tasks");
                foreach (string temp in NewDesignTool.MainWindow.datas.researchQuestion.hypothesis.tasks)
                {
                    suggest2.levels.Add(new NewDesignTool.IndependentVariable.Level(temp));
                }
                NewDesignTool.MainWindow.datas.independentVariables.Add(suggest2);

                foreach (string temp in NewDesignTool.MainWindow.datas.researchQuestion.hypothesis.measures)
                {
                    NewDesignTool.MainWindow.datas.dependentVariables.Add(new NewDesignTool.DependentVariable(temp));
                }
            }
            
        }
    }
}
