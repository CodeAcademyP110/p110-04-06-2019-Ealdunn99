using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public class Category
        {
            public string Name { get; set; }
            public int ID { get; set; }
            public static int CategoryIdCounter = 0;

            public Category()
            {
                CategoryIdCounter++;
                ID = CategoryIdCounter;
            }
            public override string ToString() => Name;
        }

        public class Device
        {
            public string Name { get; set; }
            public string Price { get; set; }
            public string CategoryName { get; set; }
            public int Quantity { get; set; }
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            deviceCount.Value = 1;
            List<Category> categories = new List<Category>();
            categories.Add(new Category
            {
                Name = "Texnologiya"
            });
            categories.Add(new Category
            {
                Name = "Meiset"
            });
            categories.Add(new Category
            {
                Name = "Qida"
            });

            cmbCategories.DataSource = categories;
        }

        List<Device> devices = new List<Device>();
        StringBuilder narr = new StringBuilder("", 50);
        private void Button1_Click_1(object sender, EventArgs e)
        {

            if (txtDeviceName.Text==""||narr.ToString().Contains(txtDeviceName.Text))
            {
                txtDeviceName.Text = "";
                MessageBox.Show("Produkt artiq elave olunub,veya adsizdi", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Device device = new Device
            {
                Name = txtDeviceName.Text,
                Price =devicePrice.Text +" $",
                Quantity = (int)deviceCount.Value,
                CategoryName = cmbCategories.SelectedItem.ToString()

            };
           
            narr.Append(txtDeviceName.Text);
            txtDeviceName.Text = "";
            deviceCount.Value = 1;
            devicePrice.Text = "0";
            devices.Add(device);
            dgwDevices.DataSource = null;
            dgwDevices.DataSource = devices;
            
        }

        
    }
}
