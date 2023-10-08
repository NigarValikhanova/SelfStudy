using System.CodeDom;

namespace Lesson19_winform
{
    public partial class Form1 : Form
    {
        List<Person> persons = new List<Person>();
        public Form1()
        {
            Person person1 = new Person("Sam", "Winchester");
            Person person2 = new Person("Dean", "Winchester");
            Person person3 = new Person("Stefan", "Salvatore");
            Person person4 = new Person("Damon", "Salvatore");
            persons.Add(person1);
            persons.Add(person2);
            persons.Add(person3);
            persons.Add(person4);
            InitializeComponent();
        }
        public void UpdateDtgw()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = persons;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = persons;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Person person = new Person(txtName.Text, txtSurname.Text);
            if (checkBox1.Checked)
            {
                persons.Add(person);
                MessageBox.Show($"{person.Name} adli user add olundu");
                UpdateDtgw();
            }
            else
            {
                MessageBox.Show("Hey! Be careful! Click the check box");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
            Form1 form1 = new Form1();
            form1.Close();
        }
    }
    class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public Person(string nm, string srnm)
        {
            Name = nm;
            Surname = srnm;
        }
    }
}