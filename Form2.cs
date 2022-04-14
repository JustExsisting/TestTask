using System;
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
            Program.list.Sort(delegate (General s1, General s2)
            {
                return s2.ResPerson.CompareTo(s1.ResPerson);
            });
            Program.typeOfSort = "по алфавиту";
            Close();
        }

        private void SortByRKK_Click(object sender, EventArgs e)
        {
            Program.list.Sort(delegate (General s1, General s2)
            {
                return s2.RKKs.CompareTo(s1.RKKs);
            });
            Program.typeOfSort = "по количество неисполненных письменных обращений граждан";
            Close();

        }

        private void SortByAppeal_Click(object sender, EventArgs e)
        {
            Program.list.Sort(delegate (General s1, General s2)
            {
                return s2.Appeals.CompareTo(s1.Appeals);
            });
            Program.typeOfSort = "Количество неисполненных входящих документов";
            Close();
        }

        private void SortByTotal_Click(object sender, EventArgs e)
        {
            Program.list.Sort(delegate (General s1, General s2)
            {
                return s2.Total.CompareTo(s1.Total);
            });
            Program.typeOfSort = "по общему количеству документов";
            Close();
        }
    }
}
