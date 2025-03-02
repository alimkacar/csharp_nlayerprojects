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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }



        TravelDbEntities Db = new TravelDbEntities();

        private void Form2_Load(object sender, EventArgs e)
        {
            var values = Db.Guide.Select(x => new {
                GuideId = x.GuideId,
                FullName = x.GuideName + " " + x.GuideSurname
            }).ToList();
            cmbGuide.DisplayMember = "FullName";
            cmbGuide.ValueMember = "GuideId";
            cmbGuide.DataSource = values;
        }

        
        private void BtnList_Click(object sender, EventArgs e)

        {
            var values = Db.Location.ToList();
            dataGridView1.DataSource = values;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Location location = new Location();
           
            location.LocationCity = txtCity.Text;
            location.LocationCountry = txtCountry.Text;
            location.LocationCapacity = byte.Parse(textCapacity.Text);
            location.LocationPrice = decimal.Parse(textPrice.Text);



            location.DayNight = textDayNight.Text;

            location.GuideId= int.Parse(cmbGuide.SelectedValue.ToString());
            

            

            Db.Location.Add(location);
            Db.SaveChanges();
            MessageBox.Show("Lokasyon Eklendi");



        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text.ToString());
            var deletedvalue = Db.Location.Find(id);
            Db.Location.Remove(deletedvalue);
            Db.SaveChanges();
            MessageBox.Show("Silme işlemi başarılı");
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text.ToString());
            var updatedvalue = Db.Location.Find(id);
            updatedvalue.LocationCity = txtCity.Text;
            updatedvalue.LocationCountry = txtCountry.Text;
            updatedvalue.LocationPrice = int.Parse(textPrice.Text.ToString());
            updatedvalue.LocationCapacity = byte.Parse(textCapacity.Text.ToString());
            updatedvalue.DayNight = textDayNight.Text;
            updatedvalue.GuideId = int.Parse(cmbGuide.SelectedValue.ToString());
            Db.SaveChanges();
            MessageBox.Show("Güncelleme işlemi başarılı");
        }
    }
}
