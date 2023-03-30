using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolutionSepet.MyLib
{
    public static class Validations
    {
        
            public static bool IsNullOrEmpty(this Control control)
            {
                // Kontrolü kontrol edin.
                if (control == null)
                {
                    throw new ArgumentNullException(nameof(control));
                }

                // Kontrolün türünü kontrol edin.
                if (control is TextBox textBox)
                {
                    return string.IsNullOrEmpty(textBox.Text);
                }
                else if (control is ComboBox comboBox)
                {
                    return comboBox.SelectedIndex == -1;
                }
                else if (control is NumericUpDown numericUpDown)
                {
                    return numericUpDown.Value == 0;
                }
                else
                {
                    throw new ArgumentException("Control türü desteklenmiyor.", nameof(control));
                }
            }
        }

    
}
