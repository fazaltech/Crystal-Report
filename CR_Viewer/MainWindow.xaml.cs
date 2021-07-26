using CR_Viewer.Model;
using CrystalDecisions.CrystalReports.Engine;
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

namespace CR_Viewer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        cr_dataEntities db = new cr_dataEntities();
        List<bio_info> bb = new List<bio_info>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

           // var abc = from c in db.bio_info select new { c.id,c.name, c.father_name, c.address,c.phone,c.dob,c.doa };

            var abc = db.bio_info.Select(x=>new  {x.name,x.father_name,x.address }).ToList();


            ReportDocument report = new ReportDocument();
            report.Load("../../CrystalReport1.rpt");
            report.SetDataSource(abc);
            crystalReportsViewer1.ViewerCore.ReportSource = report;
            //   var abc = from c in db.bio_info select new { c.name, c.father_name, c.address };

        }
    }
}
