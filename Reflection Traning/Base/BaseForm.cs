using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ReflectionTraning.Base
{
    public partial class BaseForm : Form
    {
        protected BaseForm()
        {
            InitializeComponent();
        }

        protected DialogResult OpenFormShowDialog(Type formType, List<object> parameters)
        {
            var ctor = formType.GetConstructor(parameters.Select(parameter => parameter.GetType()).ToArray());

            if (ctor == null)
                throw new TypeAccessException();

            using (var form = (Form)ctor.Invoke(parameters.ToArray()))
            {
                return form.ShowDialog();
            }
        }
    }
}
