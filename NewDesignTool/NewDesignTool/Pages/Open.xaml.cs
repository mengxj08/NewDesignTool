using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NewDesignTool.Pages
{
    /// <summary>
    /// Interaction logic for Open.xaml
    /// </summary>
    public partial class Open : System.Windows.Controls.UserControl
    {
        private OpenFileDialog dialog;

        public Open()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            dialog = new OpenFileDialog();

            dialog.Filter = "XML Files (.xml)|*.xml";
            dialog.RestoreDirectory = true;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    NewDesignTool.MainWindow.datas = new DataStructure(dialog.FileName);
                    //Log.getLogInstance().writeLog(dialog.FileName);
                }
                catch (Exception ex)
                {
                    Log.getLogInstance().writeLog("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }
    }
}
