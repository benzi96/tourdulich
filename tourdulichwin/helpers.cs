using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tourdulichwin
{
    public class helpers
    {
        public static void successorerror(bool b)
        {
            if (b)
                MessageBox.Show("Thành công");
            else
                MessageBox.Show("Lỗi");
        }

        public static void ClearTextBoxes(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }

                if (c.HasChildren)
                {
                    ClearTextBoxes(c);
                }

                if (c is CheckBox)
                {

                    ((CheckBox)c).Checked = false;
                }

                if (c is RadioButton)
                {
                    ((RadioButton)c).Checked = false;
                }

                if (c is PictureBox)
                    ((PictureBox)c).Image = null;
            }
        }

        public static void ClearOnlyTextBoxes(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }
                if (c.HasChildren)
                {
                    ClearOnlyTextBoxes(c);
                }

            }
        }
    }
}
