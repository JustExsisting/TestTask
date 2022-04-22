using System;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using Word = Microsoft.Office.Interop.Word;
using Microsoft.Office.Interop.Word;
using System.Diagnostics;

namespace TestTask
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            MessageBox.Show("Для начала работы необходимо:\n1)Выбрать Обращения\n2)Выбрать РКК");
            InitializeComponent();
        }
        public void ReadFile(bool type, string fileText)
        {
            var sw = new Stopwatch();
            int cnt;
            sw.Start();
            string[] splitByEnter = fileText.Split('\n');
            for (int i = 0; i < splitByEnter.Length - 1; i++)
            {
                string[] splitByTab = splitByEnter[i].Split('\t');      //разделение строки на лево и право по тобуляции
                string[] splitBySemicolon = splitByTab[1].Split(';');   //разделение правой части строки по точкам с зяпятой, для поиска всех, кто находится в правой части
                cnt = splitBySemicolon.Count();                         //подсчёт количество людей справа
                for (int j = 0; j < splitBySemicolon.Count(); j++)
                {
                    int spaceCNT = 0;
                    for (int k = 0; k < splitBySemicolon[j].Length; k++)
                    {
                        if (splitBySemicolon[j][k] == '(' || splitBySemicolon[j][k] == '\r')
                            splitBySemicolon[j] = splitBySemicolon[j].Remove(k);
                        if (splitBySemicolon[j].Length < k + 1)
                            continue;
                        if (splitBySemicolon[j][k] == ' ')
                        {
                            if (spaceCNT > 0 && j == 0)
                            {
                                splitBySemicolon[j] = splitBySemicolon[j].Remove(k);
                            }
                            else if (spaceCNT > 1 && j > 0)
                            {
                                spaceCNT++;
                            }
                            else
                                spaceCNT++;
                        }
                    }
                }
                if (splitByTab[0] == "Климов Сергей Александрович")
                {
                    if (type)
                        Program.list.Add(new General(splitByTab[0], splitBySemicolon[0], cnt, 0));
                    else
                        Program.list.Add(new General(splitByTab[0], splitBySemicolon[0], Program.list[i].Appeals, cnt));
                }
                else
                {
                    string[] splitBySpace = splitByTab[0].Split(' ');
                    if (type)
                    {
                        Program.list.Add(new General(splitByTab[0], $"{splitBySpace[0]} {splitBySpace[1][0]}.{splitBySpace[2][0]}.", cnt, 0));
                    }
                    else
                    {
                        Program.list.Add(new General(splitByTab[0], $"{splitBySpace[0]} {splitBySpace[1][0]}.{splitBySpace[2][0]}.", 0, cnt));
                    }
                }
            }
            sw.Stop();
            if (type)
            {
                label1.Text += sw.Elapsed.ToString();
            }
            else
            {
                label2.Text+=sw.Elapsed.ToString();
            }
            Program.list.Sort((s1, s2) =>
            {
                return s2.ResPerson.CompareTo(s1.ResPerson);
            });
            Program.typeOfSort = "по алфавиту";
            UnitList();
        }
        static public void UnitList()
        {
            for (int i = 0; i < Program.list.Count; i++)
            {
                for (int j = i + 1; j < Program.list.Count;)
                {
                    if (Program.list[i].ResPerson == Program.list[j].ResPerson)
                    {
                        Program.list[i].Appeals += Program.list[j].Appeals;
                        Program.list[i].RKKs += Program.list[j].RKKs;
                        Program.list[i].Total += Program.list[j].Total; 
                        Program.list.RemoveAt(j);
                    }
                    else break;
                }

            }
        }
        static int selectFileButtonClickCount = 0;
        public void Select_File_button_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            if (selectFileButtonClickCount < 2)
            {
                if (ofd.ShowDialog() == DialogResult.Cancel) 
                    return;
            }
            string fileName = ofd.FileName;
            if (selectFileButtonClickCount == 0)
            {
                ReadFile(true, File.ReadAllText(fileName));
                selectFileButtonClickCount++;
                MessageBox.Show("Теперь выберете файл РКК");
            }
            else if (selectFileButtonClickCount == 1)
            {
                ReadFile(false, File.ReadAllText(fileName));
                selectFileButtonClickCount++;;
                MessageBox.Show("Вы внесли все данные для формирования отчёта :3");
            }
            ListBoxUpdate();
        }
        private void ListBoxUpdate()
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("№\tОтв. исп.\t\tКол-во неисп. вход. док-ов\tКол-во неисп. письм. обращ.\tОбщее кол-во док-ов и обращ.");
            for (int i = 0; i < Program.list.Count; i++)
            {
                listBox1.Items.Add($"{i+1}\t{Program.list[i]}");
            }
            if (Program.typeOfSort == "по количество неисполненных письменных обращений граждан")
            {
                label3.Text = $"Сортировка: по обращениям";
            }
            else if (Program.typeOfSort == "Количество неисполненных входящих документов")
            {
                label3.Text = $"Сортировка: по РКК";

            }
            else if (Program.typeOfSort == "по общему количеству документов")
            {
                label3.Text = $"Сортировка: по всем док-ам";

            }
            else
            {
                label3.Text = $"Сортировка: {Program.typeOfSort}";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
            ListBoxUpdate();
        }

        private void Form_report_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Укажите в какой папке сохарнить отчёт, формат и название");
            int totals = 0;
            int appeals = 0;
            int rkks = 0;
            for (int i = 0; i < Program.list.Count - 1; i++)
            {
                totals += Program.list[i].Total;
                appeals += Program.list[i].Appeals;
                rkks += Program.list[i].RKKs;
            }            
            var app = new Word.Application();
            Document doc = app.Documents.Add(Visible: true);
            Paragraph top = doc.Paragraphs.Add();

            top.Range.Font.Name = "Arial"; top.Range.Font.Size = 14;
            top.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter; 
            top.Range.Bold = 1;
            top.Range.Text = $"Справка о неисполненных документах и обращениях граждан\n";

            Paragraph text = doc.Paragraphs.Add();
            text.Range.Font.Name = "Arial"; text.Range.Font.Size = 10;
            text.Range.Text += $"Не исполнено в срок {totals} документов, из них:\n\n" +
                        $"- количество неисполненных входящих документов: {rkks};\n\n" +
                        $"- количество неисполненных письменных обращений граждан: {appeals}.\n\n" +
                        $"Сортировка: {Program.typeOfSort}.\n\n";

            Paragraph table = doc.Paragraphs.Add();
            Table t = doc.Tables.Add(table.Range, (Program.list.Count + 1), 5);
            t.Borders.Enable = 1;
            foreach (Row row in t.Rows)
            {
                foreach(Cell cell in row.Cells)
                {
                    cell.Range.Font.Name = "Arial"; cell.Range.Font.Size = 10;
                    if (row.IsFirst)
                    {
                        cell.Range.Bold = 1;
                        cell.VerticalAlignment = WdCellVerticalAlignment.wdCellAlignVerticalCenter; cell.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                        if (cell.ColumnIndex == 1)
                        {
                            cell.Range.Text = "№ п.п.";
                        }
                        else if (cell.ColumnIndex == 2)
                        {
                            cell.Range.Text = "Ответственный исполнитель";
                        }
                        else if (cell.ColumnIndex == 3)
                        {
                            cell.Range.Text = "Количество неисполненных входящих документов";
                        }
                        else if (cell.ColumnIndex == 4)
                        {
                            cell.Range.Text = "Количество неисполненных письменных обращений граждан";
                        }
                        else if (cell.ColumnIndex == 5)
                        {
                            cell.Range.Text = "Общее количество документов и обращений";
                        }
                    }
                    else
                    {
                        if (cell.ColumnIndex == 1) //номер
                        {
                            cell.VerticalAlignment = WdCellVerticalAlignment.wdCellAlignVerticalCenter; cell.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                            cell.Range.Text = (cell.RowIndex - 1).ToString();
                        }
                        else if (cell.ColumnIndex == 2) //Ответственный исполнитель
                        {
                            cell.Range.Text = (Program.list[row.Index - 2].ResPerson).ToString();
                        }
                        else if (cell.ColumnIndex == 3) //Количество неисполненных входящих документов
                        {
                            cell.VerticalAlignment = WdCellVerticalAlignment.wdCellAlignVerticalCenter; cell.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                            cell.Range.Text = (Program.list[row.Index - 2].RKKs).ToString();
                        }
                        else if (cell.ColumnIndex == 4) //Количество неисполненных письменных обращений граждан
                        {
                            cell.VerticalAlignment = WdCellVerticalAlignment.wdCellAlignVerticalCenter; cell.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                            cell.Range.Text = (Program.list[row.Index - 2].Appeals).ToString();
                        }
                        else if (cell.ColumnIndex == 5) //Общее количество документов и обращений
                        {
                            cell.VerticalAlignment = WdCellVerticalAlignment.wdCellAlignVerticalCenter; cell.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                            cell.Range.Text = (Program.list[row.Index - 2].Total).ToString();
                        }
                    }

                }
            }
            table.Range.Text += "\n\n";

            Paragraph footer = doc.Paragraphs.Add();
            footer.Range.Text = $"Дата составления справки:\t{Program.startTime.ToShortDateString()}";
            footer.Range.Font.Name = "Arial"; footer.Range.Font.Size = 10;
            try
            {            
                doc.Save();
                doc.Close();
                app.Quit();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
} 
