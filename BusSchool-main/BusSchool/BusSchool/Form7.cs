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

namespace BusSchool
{
    public partial class Form7 : Form
    {
        
        public Form7()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {
                long HighestScore = (from gi in Game.playerList select gi).Max(g => g.Highest_Score);
                long LowestScore = (from gi in Game.playerList select gi).Min(g => g.Lowest_Score);
                long MinimumDuration = (from gi in Game.playerList select gi).Min(g => g.Lowest_Dur);
                long MaximumDuration = (from gi in Game.playerList select gi).Max(g => g.Highest_Dur);
                long TotalDuration = (from gi in Game.playerList select gi).Sum(g => g.Total_Dur);
                dataGridView1.Rows.Add("Number of games", Game.NOG);
                dataGridView1.Rows.Add("Number of profiles", Game.playerList.Count());
                dataGridView1.Rows.Add("Highest score", HighestScore);
                dataGridView1.Rows.Add("Lowest score", LowestScore);
                dataGridView1.Rows.Add("Minimum duration", MinimumDuration+"S");
                dataGridView1.Rows.Add("Maximum duration", MaximumDuration+"S");
                dataGridView1.Rows.Add("Total duration", TotalDuration+"S");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            this.Hide();
        }
    }
}
