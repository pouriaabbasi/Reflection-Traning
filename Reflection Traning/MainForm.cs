using System;
using System.Collections.Generic;
using ReflectionTraining.Model;
using ReflectionTraning.Base;

namespace ReflectionTraning
{
    public partial class MainForm : BaseForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnFirstSimpleForm_Click(object sender, EventArgs e)
        {
            OpenFormShowDialog(typeof(FirstSampleForm), new List<object> { "Pouria Abbasi" });
        }

        private void btnFirstComplexForm_Click(object sender, EventArgs e)
        {
            OpenFormShowDialog(typeof(FirstComplexForm), new List<object>
            {
                new PersonModel
                {
                    FirstName = "Pouria",
                    LastName = "Abbasi",
                    FatherName = "Abbas"
                }
            });
        }

        private void btnSecondComplexForm_Click(object sender, EventArgs e)
        {
            OpenFormShowDialog(typeof(SecondComplexForm), new List<object>
            {
                "Pouria Abbasi",
                new PersonModel
                {
                    FirstName = "Pouria",
                    LastName = "Abbasi",
                    FatherName = "Abbas"
                }
            });
        }
    }
}
