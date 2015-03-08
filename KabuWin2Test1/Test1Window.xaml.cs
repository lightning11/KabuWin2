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

            //var zandaka1 = new TKabuZandaka { ShoukenKouzaCd = "02", MeigaraCd = "1002", KabuSu = 1 };

            //using (var context = new KabuContext())
            //{
            //    context.TKabuZandakas.Add(zandaka1);

            //    // 保存
            //    context.SaveChanges();
            //    Console.Out.WriteLine("追加しました");
            //}
        
        }


        private void MeigaraAddClicked(object sender, RoutedEventArgs e)
        {

            try { 
                //var meigara = new MMeigara { MeigaraCd = "0011", MeigaraMei="123", KikanStartDate=System.DateTime.Now };

                var meigara = new MMeigara();
                //meigara.Id = 1;
                meigara.MeigaraCd = "0012";
                meigara.MeigaraMei = "銘柄テスト";
                meigara.TangenKabuSu = 10;
                meigara.ReitFlag = 0;
                meigara.KikanStartDate = System.DateTime.Parse("2015/01/01");
                meigara.KikanEndDate = System.DateTime.Parse("2099/12/31");
                meigara.SakuseiDateTime = System.DateTime.Now;
                meigara.KoushinDateTime = System.DateTime.Now;


                using (var context = new KabuContext())
                {
                    context.MMeigaras.Add(meigara);

                    // 保存
                    context.SaveChanges();
                    Console.Out.WriteLine("追加しました");
                }
            }
            catch (Exception ex)
            {
                Console.Out.WriteLine( ex.ToString() );
                
            }

        }

        private void DialogClicked(object sender, RoutedEventArgs e)
        {
            Test2Window dialog = new Test2Window();
            dialog.targetId = 1;

            dialog.showDataSet();


            bool? dialogResult = dialog.ShowDialog();
            //switch (dialogResult)
            //{
            //    case true:
            //        textBlock.Text = "OKボタンが押されました。";
            //        break;
            //    case false:
            //        textBlock.Text = "Cancelボタンが押されました。";
            //        break;
            //}

        }


    }
}
