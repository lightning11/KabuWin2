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
using System.Windows.Shapes;

namespace KabuWin2Test1
{

    /// <summary>
    /// Test2Window.xaml の相互作用ロジック
    /// </summary>
    public partial class Test2Window : Window
    {
        public int targetId { get; set; }

        public Test2Window()
        {
            InitializeComponent();
        }

        public void showDataSet()
        {
            Console.Out.WriteLine( targetId.ToString() );
            lblId.Content = targetId.ToString();
        }  


    }
}
