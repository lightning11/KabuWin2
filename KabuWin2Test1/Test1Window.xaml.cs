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
using KabuWin2Dao;

namespace KabuWin2Test1
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class Test1Window : Window
    {
        public Test1Window()
        {
            InitializeComponent();
        }


        private void SearchClicked(object sender, RoutedEventArgs e)
        {

            using (var context = new KabuContext())
            {
                // 検索
                var list = from u in context.TKabuZandakas
                           //where u.ShoukenKouzaCd == "02"
                           select u;

                List<TKabuZandaka> dataSource = new List<TKabuZandaka> { };

                foreach (var l in list)
                {
                    Console.Out.WriteLine(l.MeigaraCd);

                    dataSource.Add(new TKabuZandaka
                    {
                        Id = l.Id
                        ,
                        ShoukenKouzaCd = l.ShoukenKouzaCd
                        ,
                        MeigaraCd = l.MeigaraCd
                        ,
                        KabuSu = l.KabuSu
                    });

                }

            }
        }

        private void UpdateClicked(object sender, RoutedEventArgs e)
        {
            using (var context = new KabuContext())
            {

                var zandaka = context.TKabuZandakas.Single(x => x.Id == 3);

                zandaka.MeigaraCd = "1234";

                context.SaveChanges();
            }
        }



    }
}
