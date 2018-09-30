using System;
using System.Windows.Forms;
using ModuleStandart;

namespace WinFormsApp
{
    /// <summary>
    /// Greeting form.
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// Initialize a new instance of the <see cref="Form1"/> class.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handler click to hello button.
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">event args</param>
        private void button_hello_click(object sender, EventArgs e)
        {
            var name = this.textBox1.Text;
            var result = Greeting.GetGreeting(name);

            MessageBox.Show(result);
        }
    }
}
