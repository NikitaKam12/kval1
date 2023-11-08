using NewWpf1.Models;
using NewWpf1.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NewWpf1.Views
{
    /// <summary>
    /// Логика взаимодействия для StudentsPage.xaml
    /// </summary>
    public partial class StudentsPage : Page
    {

        private StudentRepository _studentRepository;
        public StudentsPage()
        {
            _studentRepository = new StudentRepository("C:\\Users\\danil\\source\\repos\\NewWpf1\\NewWpf1\\Students.txt");
            InitializeComponent();
            LoadStudents();
        }

        public void LoadStudents()
        {
            var students = _studentRepository.GetStudents();
            DGridStudents.ItemsSource = students;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("ahahahahah");
        }
    }
}
