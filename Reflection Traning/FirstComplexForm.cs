using ReflectionTraining.Model;
using ReflectionTraning.Base;

namespace ReflectionTraning
{
    public partial class FirstComplexForm : BaseForm
    {
        private PersonModel Model { get; set; }

        public FirstComplexForm(PersonModel model)
        {
            InitializeComponent();
            Model = model;
        }

        private void FirstComplexForm_Load(object sender, System.EventArgs e)
        {
            txtFirstName.Text = Model.FirstName;
            txtLastName.Text = Model.LastName;
            txtFatherName.Text = Model.FatherName;
        }
    }
}
