using System;
using System.ComponentModel;
using System.Windows.Forms;
using StudentApp.Models;

namespace StudentApp
{
    public partial class FormMain : Form
    {
        // Наш список студентов
        private BindingList<Student> _students = new BindingList<Student>();

        public FormMain()
        {
            // Здесь должна быть инициализация (настраивается в дизайнере)
            this.Text = "Учет студентов";
            this.Width = 600;
            this.Height = 400;
        }

        // Метод для кнопки "Добавить"
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Пример простейшей валидации
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Заполните ФИО!");
                return;
            }

            _students.Add(new Student {
                FullName = txtName.Text,
                Group = cmbGroup.Text,
                AvgGrade = numGrade.Value,
                HasScholarship = chkScholarship.Checked
            });
        }
    }
}
