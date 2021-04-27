using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab10
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            gvProcessor.AutoGenerateColumns = false;
            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Name";
            column.Name = "Модель";
            gvProcessor.Columns.Add(column);
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Country";
            column.Name = "Країна";
            gvProcessor.Columns.Add(column);
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "kernel";
            column.Name = "Ядро";
            gvProcessor.Columns.Add(column);
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "VidCard";
            column.Name = "Відеокарта";
            gvProcessor.Columns.Add(column);
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "TypeMemory";
            column.Name = "Тип пам'яті";
            gvProcessor.Columns.Add(column);
            column = new DataGridViewCheckBoxColumn();
            column.DataPropertyName = "Potoki";
            column.Name = "Потоки";
            gvProcessor.Columns.Add(column);
            EventArgs args = new EventArgs(); OnResize(args);
            ProcessorClass processor = new ProcessorClass(); 
        }
        private void fMain_Resize(object sender, EventArgs e)
        {
            int buttonsSize = 5 * btnAdd.Width + 2 * tsSeparator1.Width + 30; btnExit.Margin = new
             Padding(Width - buttonsSize, 0, 0, 0);
        }
        private void gvProcessor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ProcessorClass processor = new ProcessorClass();
            Form2 form2  = new Form2();
            if (form2.ShowDialog() == DialogResult.OK)
            {
                bindSrcProcessor.Add(processor);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ProcessorClass processor = (ProcessorClass)bindSrcProcessor.List[bindSrcProcessor.Position];
            Form2 form2 = new Form2();
            if (form2.ShowDialog() == DialogResult.OK)
            {
                bindSrcProcessor.List[bindSrcProcessor.Position] = processor;
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Видалити поточний запис?", "Видалення запису",
MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                bindSrcProcessor.RemoveCurrent();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
"Очистити таблицю?\n\nВсі дані будуть втрачені", "Очищення даних",
MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                bindSrcProcessor.Clear();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Закрити застосунок?", "Вихід з програми",
            MessageBoxButtons.OKCancel,
            MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }

        }
    }
}
