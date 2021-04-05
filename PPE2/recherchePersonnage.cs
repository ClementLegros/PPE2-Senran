using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPE2
{
    public partial class recherchePersonnage : Form
    {
        public recherchePersonnage()
        {
            InitializeComponent();
        }

        private void checkBoxBleu_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxBleu.Checked)
            {
                checkBoxRouge.Enabled = false;
                checkBoxJaune.Enabled = false;
                checkBoxViolet.Enabled = false;
                checkBoxVert.Enabled = false;
            }
            else
            {
                checkBoxRouge.Enabled = true;
                checkBoxJaune.Enabled = true;
                checkBoxViolet.Enabled = true;
                checkBoxVert.Enabled = true;
            }
        }

        private void checkBoxRouge_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRouge.Checked)
            {
                checkBoxBleu.Enabled = false;
                checkBoxJaune.Enabled = false;
                checkBoxViolet.Enabled = false;
                checkBoxVert.Enabled = false;
            }
            else
            {
                checkBoxBleu.Enabled = true;
                checkBoxJaune.Enabled = true;
                checkBoxViolet.Enabled = true;
                checkBoxVert.Enabled = true;
            }
        }

        private void checkBoxJaune_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxJaune.Checked)
            {
                checkBoxBleu.Enabled = false;
                checkBoxRouge.Enabled = false;
                checkBoxViolet.Enabled = false;
                checkBoxVert.Enabled = false;
            }
            else
            {
                checkBoxBleu.Enabled = true;
                checkBoxRouge.Enabled = true;
                checkBoxViolet.Enabled = true;
                checkBoxVert.Enabled = true;
            }
        }

        private void checkBoxViolet_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxViolet.Checked)
            {
                checkBoxBleu.Enabled = false;
                checkBoxRouge.Enabled = false;
                checkBoxJaune.Enabled = false;
                checkBoxVert.Enabled = false;
            }
            else
            {
                checkBoxBleu.Enabled = true;
                checkBoxRouge.Enabled = true;
                checkBoxJaune.Enabled = true;
                checkBoxVert.Enabled = true;
            }
        }

        private void checkBoxVert_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxVert.Checked)
            {
                checkBoxBleu.Enabled = false;
                checkBoxRouge.Enabled = false;
                checkBoxJaune.Enabled = false;
                checkBoxViolet.Enabled = false;
            }
            else
            {
                checkBoxBleu.Enabled = true;
                checkBoxRouge.Enabled = true;
                checkBoxJaune.Enabled = true;
                checkBoxViolet.Enabled = true;
            }
        }

        private void checkBoxGood_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxGood.Checked)
            {
                checkBoxEvil.Enabled = false;
                checkBoxUnaligned.Enabled = false;

                checkBoxCrimsonSquad.Enabled = false;
                checkBoxHebijo.Enabled = false;
                checkBoxMikaruga.Enabled = false;
            }
            else
            {
                checkBoxEvil.Enabled = true;
                checkBoxUnaligned.Enabled = true;

                checkBoxCrimsonSquad.Enabled = true;
                checkBoxHebijo.Enabled = true;
                checkBoxMikaruga.Enabled = true;
            }
        }

        private void checkBoxEvil_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxEvil.Checked)
            {
                checkBoxGood.Enabled = false;
                checkBoxUnaligned.Enabled = false;

                checkBoxHanzo.Enabled = false;
                checkBoxGessen.Enabled = false;
                checkBoxMikaruga.Enabled = false;
            }
            else
            {
                checkBoxGood.Enabled = true;
                checkBoxUnaligned.Enabled = true;

                checkBoxHanzo.Enabled = true;
                checkBoxGessen.Enabled = true;
                checkBoxMikaruga.Enabled = true;
            }
        }

        private void checkBoxUnaligned_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxUnaligned.Checked)
            {
                checkBoxGood.Enabled = false;
                checkBoxEvil.Enabled = false;

                checkBoxHanzo.Enabled = false;
                checkBoxCrimsonSquad.Enabled = false;
                checkBoxGessen.Enabled = false;
                checkBoxHebijo.Enabled = false;
                checkBoxNewWave.Enabled = false;

            }
            else
            {
                checkBoxGood.Enabled = true;
                checkBoxEvil.Enabled = true;

                checkBoxHanzo.Enabled = true;
                checkBoxCrimsonSquad.Enabled = true;
                checkBoxGessen.Enabled = true;
                checkBoxHebijo.Enabled = true;
                checkBoxNewWave.Enabled = true;

            }

        }


        private void checkBoxHanzo_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxHanzo.Checked)
            {
                checkBoxCrimsonSquad.Enabled = false;
                checkBoxGessen.Enabled = false;
                checkBoxHebijo.Enabled = false;
                checkBoxMikaruga.Enabled = false;
                checkBoxNewWave.Enabled = false;
            }
            else
            {
                checkBoxCrimsonSquad.Enabled = true;
                checkBoxGessen.Enabled = true;
                checkBoxHebijo.Enabled = true;
                checkBoxMikaruga.Enabled = true;
                checkBoxNewWave.Enabled = true;
            }
        }

        private void checkBoxCrimsonSquad_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxCrimsonSquad.Checked)
            {
                checkBoxHanzo.Enabled = false;
                checkBoxGessen.Enabled = false;
                checkBoxHebijo.Enabled = false;
                checkBoxMikaruga.Enabled = false;
                checkBoxNewWave.Enabled = false;
            }
            else
            {
                checkBoxHanzo.Enabled = true;
                checkBoxGessen.Enabled = true;
                checkBoxHebijo.Enabled = true;
                checkBoxMikaruga.Enabled = true;
                checkBoxNewWave.Enabled = true;
            }
        }

        private void checkBoxGessen_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxGessen.Checked)
            {
                checkBoxHanzo.Enabled = false;
                checkBoxCrimsonSquad.Enabled = false;
                checkBoxHebijo.Enabled = false;
                checkBoxMikaruga.Enabled = false;
                checkBoxNewWave.Enabled = false;
            }
            else
            {
                checkBoxHanzo.Enabled = true;
                checkBoxCrimsonSquad.Enabled = true;
                checkBoxHebijo.Enabled = true;
                checkBoxMikaruga.Enabled = true;
                checkBoxNewWave.Enabled = true;
            }
        }

        private void checkBoxHebijo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxHebijo.Checked)
            {
                checkBoxHanzo.Enabled = false;
                checkBoxCrimsonSquad.Enabled = false;
                checkBoxGessen.Enabled = false;
                checkBoxMikaruga.Enabled = false;
                checkBoxNewWave.Enabled = false;
            }
            else
            {
                checkBoxHanzo.Enabled = true;
                checkBoxCrimsonSquad.Enabled = true;
                checkBoxGessen.Enabled = true;
                checkBoxMikaruga.Enabled = true;
                checkBoxNewWave.Enabled = true;
            }
        }

        private void checkBoxMikaruga_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMikaruga.Checked)
            {
                checkBoxHanzo.Enabled = false;
                checkBoxCrimsonSquad.Enabled = false;
                checkBoxGessen.Enabled = false;
                checkBoxHebijo.Enabled = false;
                checkBoxNewWave.Enabled = false;
            }
            else
            {
                checkBoxHanzo.Enabled = true;
                checkBoxCrimsonSquad.Enabled = true;
                checkBoxGessen.Enabled = true;
                checkBoxHebijo.Enabled = true;
                checkBoxNewWave.Enabled = true;
            }
        }

        private void checkBoxNewWave_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxNewWave.Checked)
            {
                checkBoxHanzo.Enabled = false;
                checkBoxCrimsonSquad.Enabled = false;
                checkBoxGessen.Enabled = false;
                checkBoxHebijo.Enabled = false;
                checkBoxMikaruga.Enabled = false;
            }
            else
            {
                checkBoxHanzo.Enabled = true;
                checkBoxCrimsonSquad.Enabled = true;
                checkBoxGessen.Enabled = true;
                checkBoxHebijo.Enabled = true;
                checkBoxMikaruga.Enabled = true;
            }
        }
    }
}
