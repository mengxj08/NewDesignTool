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
            /*
            if (NewDesignTool.MainWindow.modeType == NewDesignTool.MODE.NewItem)
            { 
            }
             * */
        }
    }
}
