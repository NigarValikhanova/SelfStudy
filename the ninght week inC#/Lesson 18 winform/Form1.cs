namespace Lesson_18_winform
{
    public partial class Form1 : Form
    {
        List<Person> persons = new List<Person>();

        public Form1()
        {
            Person person1 = new Person("Eli", "Eliyev11111");
            Person person2 = new Person("Veli", "Eliyev22222");
            Person person3 = new Person("Pirveli", "Eliyev33333");
            persons.Add(person1);
            persons.Add(person2);
            persons.Add(person3);

            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            // Person person = new Person(txtName.Text); bele de yazmaq olar
            Person person = new Person(name, "Velixanova");
            if (checkBox1.Checked)
            {
                persons.Add(person);
                MessageBox.Show($"{person.Name} adli user add olundu");
                Form2 form2 = new Form2();
                form2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Razilasmani qebul edin");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = persons;
        }

        private void onebtn_Click(object sender, EventArgs e)
        {
            txtName.Text = onebtn.Text;
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