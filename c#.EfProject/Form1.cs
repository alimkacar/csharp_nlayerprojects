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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        TravelDbEntities Db = new TravelDbEntities();

        private void BtnList_Click(object sender, EventArgs e)
        {
            
            var values = Db.Guide.ToList();
            dataGridView1.DataSource = values;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Guide guide = new Guide(); 
            guide.GuideName=txtName.Text;
            guide.GuideSurname=txtSuranme.Text;
            Db.Guide.Add(guide);
            Db.SaveChanges();
            MessageBox.Show("Rehber Başarıyla eklendi");
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var removevalue = Db.Guide.Find(id);
            Db.Guide.Remove(removevalue);
            Db.SaveChanges();
            MessageBox.Show("Rehber Başarıyla Silimiştir");
            
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var updatevalue = Db.Guide.Find(id);
            updatevalue.GuideName = txtName.Text;
            updatevalue.GuideSurname = txtSuranme.Text;
            Db.SaveChanges();
            MessageBox.Show("Rehber Başarıyla Güncellenmiştir");
        }

        private void BtnGetById_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var values = Db.Guide.Where(x => x.GuideId == id).ToList();
            dataGridView1.DataSource = values;
        }
    }
}
