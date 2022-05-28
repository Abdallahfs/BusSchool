using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusSchool.Classes;
using BusSchool.Properties;

namespace BusSchool
{
    public partial class Form11 : Form
    {
        
       
        
        public Form11()
        {
            DateTimePicker dateTimePicker1 = new DateTimePicker();
            InitializeComponent();
           
          foreach(History r in Game.H)
            {
                dataGridView1.Rows.Add(r.profile_name, r.date.ToShortDateString(), r.duration+"S", r.score, r.level);
            }
          
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Form11_Click(object sender, EventArgs e)
        {
           
            

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dataGridView1.CurrentCell.RowIndex;
            
                if (dataGridView2.Visible == true)
                {
                    dataGridView2.Rows.Clear();
                    dataGridView2.Visible = false;
                }
                else
                {
                    int counter = 1;
                    foreach(Steps s in Game.H[row].StepsList1)
                    {
                        string side="";
                        if (s.Right)
                        {
                            side = "Right";
                        }
                        if (s.Left)
                        {
                            side = "Left";
                        }
                        if (s.Up)
                        {
                            side = "Up";
                        }
                        if (s.Down)
                        {
                            side = "Down";
                        }
                   
                        dataGridView2.Rows.Add(counter, side,s.time2-s.time+" ms");
                        counter++;
                   
                       
                    
                    }
                dataGridView2.Visible = true;
                }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            this.Hide();
        }

        
    }
}
