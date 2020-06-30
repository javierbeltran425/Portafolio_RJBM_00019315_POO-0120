using System;
using System.Windows.Forms;

namespace PreSegundoParcial
{
    public partial class AdminView : Form
    {
        private UserControl current = null;
        private Form1 principal = new Form1();
        public AdminView(Form1 form1)
        {
            InitializeComponent();
            current = userAdd1;
            principal = form1;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            tableLayoutPanel3.Controls.Remove(current);
            current = new UserAdd();
            tableLayoutPanel3.Controls.Add(current, 0, 1);
            tableLayoutPanel3.SetColumnSpan(current, 3);
            ActGrid();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tableLayoutPanel3.Controls.Remove(current);
            current = new ModifyUser();
            tableLayoutPanel3.Controls.Add(current, 0, 1);
            tableLayoutPanel3.SetColumnSpan(current, 3);
            ActGrid();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tableLayoutPanel3.Controls.Remove(current);
            current = new UserDelete();
            tableLayoutPanel3.Controls.Add(current, 0, 1);
            tableLayoutPanel3.SetColumnSpan(current, 3);
            ActGrid();
        }

        private void AdminView_Load(object sender, EventArgs e)
        {
            ActGrid();
            ActGrid2();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tableLayoutPanel6.Controls.Remove(current);
            current = new InventoryAdd();
            tableLayoutPanel6.Controls.Add(current, 0, 1);
            tableLayoutPanel6.SetColumnSpan(current, 3);
            ActGrid2();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tableLayoutPanel6.Controls.Remove(current);
            current = new ModifyInventory();
            tableLayoutPanel6.Controls.Add(current, 0, 1);
            tableLayoutPanel6.SetColumnSpan(current, 3);
            ActGrid2();
        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            tableLayoutPanel6.Controls.Remove(current);
            current = new InventoryDelete();
            tableLayoutPanel6.Controls.Add(current, 0, 1);
            tableLayoutPanel6.SetColumnSpan(current, 3);
            ActGrid2();
        }

        public void ActGrid()
        {
            tableLayoutPanel2.Controls.Remove(dataGridView1);
            var dt = ConexionDB.ExecuteQuery("SELECT idUsuario, nombre, tipo FROM USUARIO");
            dataGridView1.DataSource = dt;
            tableLayoutPanel2.Controls.Add(dataGridView1);
        }

        public void ActGrid2()
        {
            
            tableLayoutPanel5.Controls.Remove(dataGridView2);
            var dt = ConexionDB.ExecuteQuery("SELECT * FROM INVENTARIO");
            dataGridView2.DataSource = dt;
            tableLayoutPanel5.Controls.Add(dataGridView2);
            
        }
        
        private void AdminView_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
            principal.poblarControles();
            principal.Show();
        }
    }
}