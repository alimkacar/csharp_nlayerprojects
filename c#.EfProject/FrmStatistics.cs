using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace c_.EfProject
{
    public partial class FrmStatistics : Form
    {
        public FrmStatistics()
        {
            InitializeComponent();
        }
        TravelDbEntities Db= new TravelDbEntities();   
        private void FrmStatistics_Load(object sender, EventArgs e)
        {
            label2.Text = Db.Location.Count().ToString();
            label5.Text = Db.Location.Sum(x => x.LocationCapacity).ToString();
            label7.Text = Db.Guide.Count().ToString();
            label9.Text = Db.Location.Average(x => x.LocationCapacity).ToString();
            label19.Text= Db.Location.Average(x => x.LocationPrice).ToString();
            int lastcountryid =Db.Location.Max(x => x.LocationId);
            label15.Text = Db.Location.Where(x => x.LocationId == lastcountryid).Select(x => x.LocationCountry).FirstOrDefault();
            label13.Text = Db.Location.Where(x => x.LocationCity == "Kapadokya").Sum(x => x.LocationCapacity).ToString();
            label11.Text = Db.Location.Where(x => x.LocationCountry == "Türkiye").Average(x => x.LocationCapacity).ToString();
            int romaguideid = Db.Location.Where(x => x.LocationCity == "Roma").Select(x => x.GuideId).FirstOrDefault();
            label29.Text = Db.Guide.Where(x => x.GuideId == romaguideid).Select(x => x.GuideName + " " + x.GuideSurname).FirstOrDefault();
            int highestcapacity = (int)Db.Location.Max(x => x.LocationCapacity);
            label25.Text = Db.Location.Where(x => x.LocationCapacity == highestcapacity).Select(x => x.LocationCity).FirstOrDefault();
            int mostexpensive = (int)Db.Location.Max(x => x.LocationPrice);
            label23.Text = Db.Location.Where(x => x.LocationPrice == mostexpensive).Select(x => x.LocationCity).FirstOrDefault();
            int aysegulcinarid= Db.Guide.Where(x => x.GuideName == "Ayşegül" && x.GuideSurname == "Çınar").Select(x => x.GuideId).FirstOrDefault(); 
            label21.Text = Db.Location.Where(x => x.GuideId == aysegulcinarid).Count().ToString();

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }
    }
}