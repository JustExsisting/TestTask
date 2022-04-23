using System;
using System.Linq;
using System.Windows.Forms;

namespace TestTask
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void SortByName_Click(object sender, EventArgs e)
        {
            Program.list = Program.list.OrderByDescending(s => s.ResPerson).ToList();
            Program.typeOfSort = "по алфавиту";
            Close();
        }

        private void SortByRKK_Click(object sender, EventArgs e)
        {
            Program.list = Program.list.OrderByDescending(s => s.RKKs).ThenByDescending(s => s.Appeals).ToList();
            Program.typeOfSort = "Количество неисполненных входящих документов";
            Close();
        }

        private void SortByAppeal_Click(object sender, EventArgs e)
        {
            Program.list = Program.list.OrderByDescending(s => s.Appeals).ThenByDescending(s=>s.RKKs).ToList();
            Program.typeOfSort = "по количество неисполненных письменных обращений граждан";
            Close();
        }

        private void SortByTotal_Click(object sender, EventArgs e)
        {
            Program.list = Program.list.OrderByDescending(s => s.Total).ThenByDescending(s=>s.RKKs).ToList();
            Program.typeOfSort = "по общему количеству документов";
            Close();
        }
    }
}
