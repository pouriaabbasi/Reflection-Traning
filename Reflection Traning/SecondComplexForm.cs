using ReflectionTraining.Model;
using ReflectionTraning.Base;

namespace ReflectionTraning
{
    public partial class SecondComplexForm : BaseForm
    {
        private PersonModel Model { get; set; }

        private string FullName { get; set; }

        public SecondComplexForm(string fullName, PersonModel model)
        {
            InitializeComponent();
            FullName = fullName;
            Model = model;
        }

        private void SecondComplexForm_Load(object sender, System.EventArgs e)
        {
            txtFullName.Text = FullName;
            txtFirstName.Text = Model.FirstName;
            txtLastName.Text = Model.LastName;
            txtFatherName.Text = Model.FatherName;
        }
    }
}
