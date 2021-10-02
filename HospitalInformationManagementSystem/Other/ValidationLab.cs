using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace HospitalInformationManagementSystem.Other
{
    class ValidationLab
    {
        public static bool TextBoxValidation(TextBox textBox,ErrorProvider errorProvider,string regx = null)
        {
            if (string.IsNullOrEmpty(textBox.Text))
            {
                errorProvider.SetError(textBox, "Please Fill the Field...!");
                textBox.Focus();
                return false;
            }
            else
            {
                if (regx != null)
                {
                    Regex reg = new Regex(@""+regx);

                    bool result = reg.IsMatch(textBox.Text.Trim());

                    if (result)
                    {
                        errorProvider.Clear();
                        return true;
                    }
                    else
                    {
                        errorProvider.SetError(textBox, "This is invalid...!");
                        textBox.Focus();
                        return false;
                    }
                }
                else
                {
                    return true;
                }
            }
        }

        public static bool ComboBoxValidation(ComboBox comboBox, ErrorProvider errorProvider)
        {
            if (comboBox.SelectedItem == null)
            {
                errorProvider.SetError(comboBox, "Please Fill the Field...!");
                comboBox.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool CheckBoxValidation(CheckBox checkBox, ErrorProvider errorProvider)
        {
            if (comboBox.Checked == null)
            {
                errorProvider.SetError(comboBox, "Please Fill the Field...!");
                comboBox.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool CheckListBoxValidation(CheckedListBox checkedListBox, ErrorProvider errorProvider)
        {
            if (checkedListBox.CheckedItems == null)
            {
                errorProvider.SetError(checkedListBox, "Please Fill the Field...!");
                checkedListBox.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
