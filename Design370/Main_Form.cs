﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design370
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();

            tabControl1.DrawItem += new DrawItemEventHandler(tabControl1_DrawItem);
        }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)

        {

            Graphics g = e.Graphics;
            Brush _textBrush;

            // Get the item from the collection.
            TabPage _tabPage = tabControl1.TabPages[e.Index];

            // Get the real bounds for the tab rectangle.
            Rectangle _tabBounds = tabControl1.GetTabRect(e.Index);

            // Use our own font.
            Font _tabFont = new Font("Bahnschrift Light", (float)15.0, FontStyle.Regular, GraphicsUnit.Pixel);

            if (e.State == DrawItemState.Selected)
            {
                _tabFont = new Font("Bahnschrift Light", (float)15.0, FontStyle.Bold, GraphicsUnit.Pixel);

                // Draw a different background color, and don't paint a focus rectangle.
                _textBrush = new SolidBrush(Color.Gold);
                g.FillRectangle(Brushes.CornflowerBlue, e.Bounds);
            }
            else
            {
                _textBrush = new System.Drawing.SolidBrush(e.ForeColor);
                e.DrawBackground();
            }

            // Draw string. Center the text.
            StringFormat _stringFlags = new StringFormat();

            _stringFlags.Alignment = StringAlignment.Center;

            _stringFlags.LineAlignment = StringAlignment.Center;

            g.DrawString(_tabPage.Text, _tabFont, _textBrush, _tabBounds, new StringFormat(_stringFlags));



        }

        private void button1_Click(object sender, EventArgs e)
        {
            Customer_Add customerAdd= new Customer_Add();
            customerAdd.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Service_Add service_Add = new Service_Add();
            service_Add.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Photoshoot_Package_Add photoshootPackageAdd = new Photoshoot_Package_Add();
            photoshootPackageAdd.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(e.RowIndex.ToString() + " " + e.ColumnIndex.ToString());   //stefan het homself bekak toe ek dit vir hom wys

            Customer_View customerView = new Customer_View();
            switch (e.ColumnIndex)
            {
                
                case 3:
                    Customer_View.edit = false;
                    customerView.Show();
                    break;
                case 4:
                    Customer_View.edit = true;
                    customerView.Show();
                    break;
                case 5:
                    DialogResult delete = MessageBox.Show("Do you really want to delete this entry?", "Delete", MessageBoxButtons.YesNo);
                    if (delete == DialogResult.Yes)
                    {
                        //do shit
                    } else
                    {
                        //dont do shit
                    }
                    break;
                default:
                    break;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Event_Package_Add eventPackageAdd = new Event_Package_Add();
            eventPackageAdd.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Event_Types eventTypes = new Event_Types();
            eventTypes.Show();
        }

        private void Button20_Click(object sender, EventArgs e)
        {
            Booking_Dialog booking_Dialog = new Booking_Dialog();
            booking_Dialog.Show();
        }

        private void Main_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult exit = MessageBox.Show("Do you really want to exit?", "Exit confirmation", MessageBoxButtons.YesNo);
            e.Cancel = exit == DialogResult.Yes ? false : true;
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            Employee_Add employee_Add = new Employee_Add();
            employee_Add.Show();
        }

        private void Button16_Click(object sender, EventArgs e)
        {

        }

        private void DataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Employee_View employeeView = new Employee_View();
            switch (e.ColumnIndex)
            {

                case 4:
                    Employee_View.edit = false;
                    employeeView.Show();
                    break;
                case 5:
                    Employee_View.edit = true;
                    employeeView.Show();
                    break;
                case 6:
                    DialogResult delete = MessageBox.Show("Do you really want to delete this entry?", "Delete", MessageBoxButtons.YesNo);
                    if (delete == DialogResult.Yes)
                    {
                        //do shit
                    }
                    else
                    {
                        //dont do shit
                    }
                    break;
                default:
                    break;
            }
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            Employee_Types EmployeeTypes = new Employee_Types();
            EmployeeTypes.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Service_Types service_Types = new Service_Types();
            service_Types.Show();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Product_Add product_Add = new Product_Add();
            product_Add.Show();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Product_Types product_Types = new Product_Types();
            product_Types.Show();
        }

        private void Button24_Click(object sender, EventArgs e)
        {
            Supplier_Add supplier_Add = new Supplier_Add();
            supplier_Add.Show();
        }

        private void Button22_Click(object sender, EventArgs e)
        {
            Supplier_Orders supplier_Orders = new Supplier_Orders();
            supplier_Orders.Show();
        }

        private void DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Service_View service_View = new Service_View();
            switch (e.ColumnIndex)
            {

                case 3:
                    Service_View.edit = false;
                    service_View.Show();
                    break;
                case 4:
                    Service_View.edit = true;
                    service_View.Show();
                    break;
                case 5:
                    DialogResult delete = MessageBox.Show("Do you really want to delete this entry?", "Delete", MessageBoxButtons.YesNo);
                    if (delete == DialogResult.Yes)
                    {
                        //do shit
                    }
                    else
                    {
                        //dont do shit
                    }
                    break;
                default:
                    break;
            }
        }

        private void DataGridView6_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PhotoshootPackage_View photoshootPackage_View = new PhotoshootPackage_View();
            switch (e.ColumnIndex)
            {

                case 3:
                    PhotoshootPackage_View.edit = false;
                    photoshootPackage_View.Show();
                    break;
                case 4:
                    PhotoshootPackage_View.edit = true;
                    photoshootPackage_View.Show();
                    break;
                case 5:
                    DialogResult delete = MessageBox.Show("Do you really want to delete this entry?", "Delete", MessageBoxButtons.YesNo);
                    if (delete == DialogResult.Yes)
                    {
                        //do shit
                    }
                    else
                    {
                        //dont do shit
                    }
                    break;
                default:
                    break;
            }
        }

        private void DataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Product_View product_View = new Product_View();
            switch (e.ColumnIndex)
            {

                case 3:
                    Product_View.edit = false;
                    product_View.Show();
                    break;
                case 4:
                    Product_View.edit = true;
                    product_View.Show();
                    break;
                case 5:
                    DialogResult delete = MessageBox.Show("Do you really want to delete this entry?", "Delete", MessageBoxButtons.YesNo);
                    if (delete == DialogResult.Yes)
                    {
                        //do shit
                    }
                    else
                    {
                        //dont do shit
                    }
                    break;
                default:
                    break;
            }
        }

        private void DataGridView7_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EventPackage_View eventPackage_View = new EventPackage_View();
            switch (e.ColumnIndex)
            {

                case 3:
                    EventPackage_View.edit = false;
                    eventPackage_View.Show();
                    break;
                case 4:
                    EventPackage_View.edit = true;
                    eventPackage_View.Show();
                    break;
                case 5:
                    DialogResult delete = MessageBox.Show("Do you really want to delete this entry?", "Delete", MessageBoxButtons.YesNo);
                    if (delete == DialogResult.Yes)
                    {
                        //do shit
                    }
                    else
                    {
                        //dont do shit
                    }
                    break;
                default:
                    break;
            }
        }

        private void DataGridView10_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Supplier_View supplier_View = new Supplier_View();
            switch (e.ColumnIndex)
            {

                case 2:
                    Supplier_View.edit = false;
                    supplier_View.Show();
                    break;
                case 3:
                    Supplier_View.edit = true;
                    supplier_View.Show();
                    break;
                case 4:
                    DialogResult delete = MessageBox.Show("Do you really want to delete this entry?", "Delete", MessageBoxButtons.YesNo);
                    if (delete == DialogResult.Yes)
                    {
                        //do shit
                    }
                    else
                    {
                        //dont do shit
                    }
                    break;
                default:
                    break;
            }
        }
    }
}