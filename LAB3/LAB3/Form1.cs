using System.ComponentModel;

namespace LAB3
{
    public partial class Form1 : Form
    {
        //array <-> List
        List<Student> _students = new List<Student>();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //get value from textbox
            String name = this.textBoxName.Text;
            String year = this.textBoxBirthYear.Text;
            //convert string to in
            int iYear = Int32.Parse(year);
            

            //create obj from Student
            Student newStudent = new Student(name, iYear);
            //Add new student to list
            this._students.Add(newStudent);

            //clear textbox
            this.textBoxName.Text = "";
            this.textBoxBirthYear.Text = "";

            // add data to DataGridView
            BindingSource source = new BindingSource();
            source.DataSource = this._students;            
            this.dataGridView1.DataSource = source;
                
        }
    }
}