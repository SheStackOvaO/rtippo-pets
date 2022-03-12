using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    public partial class Form1 : Form
    {
        public bool skrito = false;
        public Form1()
        {
            InitializeComponent();
            var dateApplication = new DataGridViewTextBoxColumn();
            dateApplication.HeaderText = "Дата подачи заявки";
            dateApplication.Name = "dateApplication";

            var locality = new DataGridViewTextBoxColumn();
            locality.HeaderText = "Населенный пункт";
            locality.Name = "locality";

            var animalHabitat = new DataGridViewTextBoxColumn();
            animalHabitat.HeaderText = "Место обитания животного";
            animalHabitat.Name = "animalHabitat";

            var captureOrganization = new DataGridViewTextBoxColumn();
            captureOrganization.HeaderText = "Организация по отлову";
            captureOrganization.Name = "captureOrganization";

            var currentAplicationStatus = new DataGridViewTextBoxColumn();
            currentAplicationStatus.HeaderText = "Текущий статус заявки";
            currentAplicationStatus.Name = "currentAplicationStatus";

            var dateStatusSet = new DataGridViewTextBoxColumn();
            dateStatusSet.HeaderText = "Дата установки статуса";
            dateStatusSet.Name = "dateStatusSet";

            var attribute = new DataGridViewTextBoxColumn();
            attribute.HeaderText = "Признак";
            attribute.Name = "attribute";

            dataGridView1.Columns.AddRange(new DataGridViewColumn[] {dateApplication,
                locality,
                animalHabitat,
                captureOrganization,
                currentAplicationStatus,
                dateStatusSet,
                attribute
            });
        }

        private void button4_Click(object sender, EventArgs e)
        {

            
            if (skrito)
            {
                skrito = false;
                button4.Text = "Скрыть";
            }
            else
            {
                skrito = true;
                button4.Text = "Вернуть";
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void dataGridView1_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }
    }
}
