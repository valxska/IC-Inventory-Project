using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QRbackend
{
    public partial class AddDeviceForm : Form
    {
        private string codigoQr;
        private int idBorrowPerson;
        private BD bd;

        public AddDeviceForm(String codigoQr, int idBorrowPerson)
        {
            InitializeComponent();
            this.idBorrowPerson = idBorrowPerson;
            this.codigoQr = codigoQr;
            bd = new BD();

            //SE DEBEN AÑADIR LAS OPCIONES DE AMBOS COMBOBOX (BRAND Y CATEGORY)

            categorybox.Items.Add("Categoria1");   // 1
            categorybox.Items.Add("Categoria2");    // 2
            categorybox.Items.Add("Categoria3");    // 3

            brandbox.Items.Add("brand1");    // 2
            brandbox.Items.Add("brand2");    // 3

            estatebox.Items.Add("estate1");    // 2
            estatebox.Items.Add("estate2");    // 3

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void qrButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            GeneratorForm fm = new GeneratorForm(idBorrowPerson);
            fm.Show();
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
           GeneratorForm fm = new GeneratorForm(idBorrowPerson);
            fm.Show();
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            qrText.Text = codigoQr;
            String name = namebox.Text;
            String category = categorybox.SelectedItem.ToString();
            String description = descriptionbox.Text;
            String serialcode = serialbox.Text;
            float price = float.Parse(pricebox.Text);
            String brand = brandbox.SelectedItem.ToString();
            String estate = estatebox.SelectedItem.ToString();
            int idDevice = bd.VerifyDevice(codigoQr);
            int idCategory = bd.VerifyCategory(category);
            int idBrand = bd.VerifyBrand(brand);
            //if(name==String.Empty || category )
            bd.AddDevice(codigoQr,serialcode,price,description,brand,estate,category);

        }

        private void qrText_Click(object sender, EventArgs e)
        {
            
        }

        private void AddDeviceForm_Load(object sender, EventArgs e)
        {

        }
    }
}
