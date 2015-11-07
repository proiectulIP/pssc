using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pssc
{
    public class loginForm:Form
    {
        private RadioButton profRadioButton;
        private RadioButton studRadioButton;
        private RadioButton cazButton;


        public string radioButtonChecked()
        {
            int btn = 0;

            if (ProfRadioButton.Checked)
                btn = 1;
            else if (StudRadioButton.Checked)
                btn = 2;
            else if (CazButton.Checked)
                btn = 3;

            var fret = mapButtonToType(btn);
            return fret;
        }

        private string mapButtonToType(int btn)
        {
            string fret = null;
            switch (btn)
            {
                case 1: { fret = "profesor"; break; }
                case 2: { fret = "student"; break; }
                case 3: { fret = "cazare"; break; }
            }

            return fret;
        }

        public RadioButton ProfRadioButton
        {
            get
            {
                return profRadioButton;
            }

            set
            {
                profRadioButton = value;
            }
        }

        public RadioButton StudRadioButton
        {
            get
            {
                return studRadioButton;
            }

            set
            {
                studRadioButton = value;
            }
        }

        public RadioButton CazButton
        {
            get
            {
                return cazButton;
            }

            set
            {
                cazButton = value;
            }
        }


    }
}
