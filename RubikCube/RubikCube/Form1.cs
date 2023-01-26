using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RubikCube
{
    public partial class Form1 : Form
    {
        Cube RubikCube2 = new Cube();
        public Form1()
        {
            InitializeComponent();
           // loadColors();
        }
        private void loadColors()
        {
            ColorBox11.BackColor = ColorTranslator.FromHtml(RubikCube2.getColor(0, 0));
            ColorBox12.BackColor = ColorTranslator.FromHtml(RubikCube2.getColor(0, 1));
            ColorBox13.BackColor = ColorTranslator.FromHtml(RubikCube2.getColor(0, 2));
            ColorBox21.BackColor = ColorTranslator.FromHtml(RubikCube2.getColor(1, 0));
            ColorBox22.BackColor = ColorTranslator.FromHtml(RubikCube2.getColor(1, 1));
            ColorBox23.BackColor = ColorTranslator.FromHtml(RubikCube2.getColor(1, 2));
            ColorBox31.BackColor = ColorTranslator.FromHtml(RubikCube2.getColor(2, 0));
            ColorBox32.BackColor = ColorTranslator.FromHtml(RubikCube2.getColor(2, 1));
            ColorBox33.BackColor = ColorTranslator.FromHtml(RubikCube2.getColor(2, 2));
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            //RubikCube2.ReadCube("CubeData.txt");
            RubikCube2.defaultCube();
            loadColors();

        }

        private void upArrowLeft_Click(object sender, EventArgs e)
        {
            RubikCube2.turnColumn("Left", "Up");
            loadColors();
        }

        private void upArrowMiddle_Click(object sender, EventArgs e)
        {
            RubikCube2.turnColumn("Middle", "Up");
            loadColors();
        }

        private void upArrowRight_Click(object sender, EventArgs e)
        {
            RubikCube2.turnColumn("Right", "Up");
            loadColors();
        }

        private void rightArrowUp_Click(object sender, EventArgs e)
        {
            RubikCube2.turnRow("Top", "Right");
            loadColors();
        }

        private void rightArrowMiddle_Click(object sender, EventArgs e)
        {
            RubikCube2.turnRow("Middle", "Right");
            loadColors();
        }

        private void rightArrowDown_Click(object sender, EventArgs e)
        {
            RubikCube2.turnRow("Bottom", "Right");
            loadColors();
        }

        private void downArrowRight_Click(object sender, EventArgs e)
        {
            RubikCube2.turnColumn("Right", "Down");
            loadColors();
        }

        private void downArrowMiddle_Click(object sender, EventArgs e)
        {
            RubikCube2.turnColumn("Middle", "Down");
            loadColors();
        }

        private void downArrowLeft_Click(object sender, EventArgs e)
        {
            RubikCube2.turnColumn("Left", "Down");
            loadColors();
        }

        private void leftArrowDown_Click(object sender, EventArgs e)
        {
            RubikCube2.turnRow("Bottom", "Left");
            loadColors();
        }

        private void leftArrowMiddle_Click(object sender, EventArgs e)
        {
            RubikCube2.turnRow("Middle", "Left");
            loadColors();
        }

        private void leftArrowUp_Click(object sender, EventArgs e)
        {
            RubikCube2.turnRow("Top", "Left");
            loadColors();
        }
    }
}
