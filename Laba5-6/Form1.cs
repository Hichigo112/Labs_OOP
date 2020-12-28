using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba56
{

    public partial class Form1 : Form
    {
        private List<Shape> _cases = new List<Shape>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Triangle_CheckedChanged(object sender, EventArgs e)
        {
            if (Triangle.Checked)
            {
                xBox1.Enabled = true;
                yBox1.Enabled = true;
                xBox2.Enabled = true;
                yBox2.Enabled = true;
                xBox3.Enabled = true;
                yBox3.Enabled = true;
                xBox4.Enabled = false;
                yBox4.Enabled = false;
                xBox4.Text = "";
                yBox4.Text = "";
            }
        }

        private void Rectangle_CheckedChanged(object sender, EventArgs e)
        {
            if (Rectangle.Checked)
            {
                xBox1.Enabled = true;
                yBox1.Enabled = true;
                xBox2.Enabled = true;
                yBox2.Enabled = true;
                xBox3.Enabled = true;
                yBox3.Enabled = true;
                xBox4.Enabled = true;
                yBox4.Enabled = true;
            }
        }

        private void xBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != '-')
            {
                e.Handled = true;
            }
        }

        private void yBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != '-')
            {
                e.Handled = true;
            }
        }

        private void xBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != '-')
            {
                e.Handled = true;
            }
        }

        private void yBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != '-')
            {
                e.Handled = true;
            }
        }

        private void xBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != '-')
            {
                e.Handled = true;
            }
        }

        private void yBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != '-')
            {
                e.Handled = true;
            }
        }

        private void xBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != '-')
            {
                e.Handled = true;
            }
        }

        private void yBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != '-')
            {
                e.Handled = true;
            }
        }

        private void moveBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != '-')
            {
                e.Handled = true;
            }
        }

        private void moveBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != '-')
            {
                e.Handled = true;
            }
        }

        private void rotateBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != '-')
            {
                e.Handled = true;
            }
        }

        private void Create_Click(object sender, EventArgs e)
        {
            CreateShape();
            nameBox1.Text = "";
        }

        private void CreateShape()
        {
            int countVertex = 0;
            if (Triangle.Checked)
            {
                if (xBox1.TextLength == 0 || yBox1.TextLength == 0 || xBox2.TextLength == 0 || yBox2.TextLength == 0 || xBox3.TextLength == 0 || yBox3.TextLength == 0 || nameBox1.TextLength == 0)
                {
                    MessageBox.Show("Enter all 3 cords or name");
                    return;
                }
                countVertex = 3;
            }
            else if (Rectangle.Checked)
            {
                if (xBox1.TextLength == 0 || yBox1.TextLength == 0 || xBox2.TextLength == 0 || yBox2.TextLength == 0 || xBox3.TextLength == 0 || yBox3.TextLength == 0 || xBox4.TextLength == 0 || yBox4.TextLength == 0 || nameBox1.TextLength == 0)
                {
                    MessageBox.Show("Enter all 4 cords or name");
                    return;
                }
                countVertex = 4;
            }

            Point[] dots = new Point[countVertex];
            TextBox[] arrX = new TextBox[4] { xBox1, xBox2, xBox3, xBox4 };
            TextBox[] arrY = new TextBox[4] { yBox1, yBox2, yBox3, yBox4 };

            for (int i = 0; i < countVertex; i++)
            {
                dots[i].x = Convert.ToInt32(arrX[i].Text);
                dots[i].y = Convert.ToInt32(arrY[i].Text);
            }

            Shape shape = null;
            Factory factory = new Factory();
            try
            {
                shape = factory.createShape(dots, countVertex);
                _cases.Add(shape);
                richTextBox1.Text = "Add completed.\n" + shape.GetString();
            }
            catch (ArgumentOutOfRangeException err)
            {
                MessageBox.Show(err.Message);
            }

            for (int i = 0; i < countVertex; i++)
            {
                arrX[i].Text = "";
                arrY[i].Text = "";
            }

            operationBox.Items.Add(nameBox1.Text);
            checkBox1.Items.Add(nameBox1.Text);
            checkBox2.Items.Add(nameBox1.Text);
        }

        private void PrintShape()
        {
            if (operationBox.Items.Count != 0 && operationBox.SelectedIndex != -1)
            {
                richTextBox1.Text = operationBox.SelectedItem + " is\n" + _cases[operationBox.SelectedIndex].GetString();
            }
            else
            {
                MessageBox.Show("Choose something");
            }
        }

        private void Print_Click(object sender, EventArgs e)
        {
            PrintShape();
        }

        private void CenterOfGravity_Click(object sender, EventArgs e)
        {
            CenterOfGravityShape();
        }
        private void CenterOfGravityShape()
        {
            if (operationBox.Items.Count != 0 && operationBox.SelectedIndex != -1)
            {
               
                richTextBox1.Text = "Center of Gravity of " + operationBox.SelectedItem + " equal\n" + _cases[operationBox.SelectedIndex].CenterOfGravity().GetString();
            }
            else
            {
                MessageBox.Show("Choose something");
            }
        }

        private void Move_Click(object sender, EventArgs e)
        {
            MoveShape();
        }

        private void MoveShape()
        {
            if (operationBox.Items.Count != 0 && operationBox.SelectedIndex != -1 && moveBox1.TextLength != 0 && moveBox2.TextLength != 0)
            {
                _cases[operationBox.SelectedIndex].Move(Convert.ToInt32(moveBox1.Text), Convert.ToInt32(moveBox2.Text));
                PrintShape();
            }
            else
            {
                MessageBox.Show("Choose something");
            }
        }

        private void DeleteShape()
        {
            if (operationBox.Items.Count != 0 && operationBox.SelectedIndex != -1)
            {
                _cases.RemoveAt(operationBox.SelectedIndex);
                checkBox1.Items.RemoveAt(operationBox.SelectedIndex);
                checkBox2.Items.RemoveAt(operationBox.SelectedIndex);
                operationBox.Items.RemoveAt(operationBox.SelectedIndex);
                operationBox.Text = "";
                checkBox1.Text = "";
                checkBox2.Text = "";

            }
            else
            {
                MessageBox.Show("Choose something");
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            DeleteShape();
        }

        private void RotateShape()
        {
            if (operationBox.Items.Count != 0 && operationBox.SelectedIndex != -1 && rotateBox.TextLength != 0)
            {
                _cases[operationBox.SelectedIndex].Rotate(Convert.ToInt32(rotateBox.Text));
                PrintShape();
            }
            else
            {
                MessageBox.Show("Choose something or Angle");
            }
        }

        private void Rotate_Click(object sender, EventArgs e)
        {
            RotateShape();
        }

        private void IsIntersect_Click(object sender, EventArgs e)
        {
            IsIntersectShapes();
        }

        private void IsIntersectShapes()
        {
            Operation operation = new Operation();
            if (checkBox1.Items.Count != 0 && checkBox2.Items.Count != 0 && checkBox1.SelectedIndex != -1 && checkBox2.SelectedIndex != -1)
            {
                if (operation.IsIntersect(_cases[checkBox1.SelectedIndex], _cases[checkBox2.SelectedIndex]))
                {
                    richTextBox1.Text = "yes";
                }
                else
                {
                    richTextBox1.Text = "no";
                }

                 
            }
            else
            {
                
                    MessageBox.Show("Choose check box1 and check box 2");
            }
        }

        private void IsIncludeShape()
        {
            Operation operation = new Operation();
            if (checkBox1.Items.Count != 0 && checkBox2.Items.Count != 0 && checkBox1.SelectedIndex != -1 && checkBox2.SelectedIndex != -1)
            {
                if (operation.IsInclude(_cases[checkBox1.SelectedIndex], _cases[checkBox2.SelectedIndex]))
                {
                    richTextBox1.Text = "yes";
                }
                else
                {
                    richTextBox1.Text = "no";
                }
            }
            else
            {

                MessageBox.Show("Choose check box1 and check box 2");
            }
        }

        private void InClude_Click(object sender, EventArgs e)
        {
            IsIncludeShape();
        }

        private void CompareShapes()
        {
            Operation operation = new Operation();
            if (checkBox1.Items.Count != 0 && checkBox2.Items.Count != 0 && checkBox1.SelectedIndex != -1 && checkBox2.SelectedIndex != -1)
            {
                if (operation.Compare(_cases[checkBox2.SelectedIndex], _cases[checkBox1.SelectedIndex]) == 1)
                {
                    richTextBox1.Text = "First shape larger than second";
                }
                else if (operation.Compare(_cases[checkBox2.SelectedIndex], _cases[checkBox1.SelectedIndex]) == -1)
                {
                    richTextBox1.Text = "Second shape larger than first";
                }
                else
                {
                    richTextBox1.Text = "Shapes have the same area";
                }
            }
            else
            {

                MessageBox.Show("Choose check box1 and check box 2");
            }
        }

        private void Compare_Click(object sender, EventArgs e)
        {
            CompareShapes();
        }
    }
}
