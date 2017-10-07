using ReflectionTraning.Base;

namespace ReflectionTraning
{
    public partial class FirstSampleForm : BaseForm
    {

        public FirstSampleForm()
        {
            InitializeComponent();
        }

        public FirstSampleForm(string fullName)
        {
            InitializeComponent();
            txtFullName.Text = fullName;
        }
    }
}
