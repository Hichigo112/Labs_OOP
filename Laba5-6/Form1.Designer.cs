
namespace Laba56
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Move = new System.Windows.Forms.Button();
            this.Rotate = new System.Windows.Forms.Button();
            this.Print = new System.Windows.Forms.Button();
            this.Triangle = new System.Windows.Forms.RadioButton();
            this.Rectangle = new System.Windows.Forms.RadioButton();
            this.Delete = new System.Windows.Forms.Button();
            this.moveBox1 = new System.Windows.Forms.TextBox();
            this.moveBox2 = new System.Windows.Forms.TextBox();
            this.X = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Angle = new System.Windows.Forms.Label();
            this.rotateBox = new System.Windows.Forms.TextBox();
            this.Create = new System.Windows.Forms.Button();
            this.Compare = new System.Windows.Forms.Button();
            this.InClude = new System.Windows.Forms.Button();
            this.IsIntersect = new System.Windows.Forms.Button();
            this.CenterOfGravity = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.ComboBox();
            this.Y1 = new System.Windows.Forms.Label();
            this.X1 = new System.Windows.Forms.Label();
            this.yBox1 = new System.Windows.Forms.TextBox();
            this.xBox1 = new System.Windows.Forms.TextBox();
            this.Y3 = new System.Windows.Forms.Label();
            this.X3 = new System.Windows.Forms.Label();
            this.yBox3 = new System.Windows.Forms.TextBox();
            this.xBox3 = new System.Windows.Forms.TextBox();
            this.Y2 = new System.Windows.Forms.Label();
            this.X2 = new System.Windows.Forms.Label();
            this.yBox2 = new System.Windows.Forms.TextBox();
            this.xBox2 = new System.Windows.Forms.TextBox();
            this.Y4 = new System.Windows.Forms.Label();
            this.X4 = new System.Windows.Forms.Label();
            this.yBox4 = new System.Windows.Forms.TextBox();
            this.xBox4 = new System.Windows.Forms.TextBox();
            this.operationBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.nameBox1 = new System.Windows.Forms.TextBox();
            this.Name = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Move
            // 
            this.Move.Location = new System.Drawing.Point(131, 79);
            this.Move.Name = "Move";
            this.Move.Size = new System.Drawing.Size(75, 23);
            this.Move.TabIndex = 0;
            this.Move.Text = "Move";
            this.Move.UseVisualStyleBackColor = true;
            this.Move.Click += new System.EventHandler(this.Move_Click);
            // 
            // Rotate
            // 
            this.Rotate.Location = new System.Drawing.Point(241, 79);
            this.Rotate.Name = "Rotate";
            this.Rotate.Size = new System.Drawing.Size(75, 23);
            this.Rotate.TabIndex = 1;
            this.Rotate.Text = "Rotate";
            this.Rotate.UseVisualStyleBackColor = true;
            this.Rotate.Click += new System.EventHandler(this.Rotate_Click);
            // 
            // Print
            // 
            this.Print.Location = new System.Drawing.Point(9, 108);
            this.Print.Name = "Print";
            this.Print.Size = new System.Drawing.Size(104, 23);
            this.Print.TabIndex = 2;
            this.Print.Text = "Print";
            this.Print.UseVisualStyleBackColor = true;
            this.Print.Click += new System.EventHandler(this.Print_Click);
            // 
            // Triangle
            // 
            this.Triangle.AutoSize = true;
            this.Triangle.Location = new System.Drawing.Point(439, 112);
            this.Triangle.Name = "Triangle";
            this.Triangle.Size = new System.Drawing.Size(67, 19);
            this.Triangle.TabIndex = 3;
            this.Triangle.TabStop = true;
            this.Triangle.Text = "Triangle";
            this.Triangle.UseVisualStyleBackColor = true;
            this.Triangle.CheckedChanged += new System.EventHandler(this.Triangle_CheckedChanged);
            // 
            // Rectangle
            // 
            this.Rectangle.AutoSize = true;
            this.Rectangle.Location = new System.Drawing.Point(512, 112);
            this.Rectangle.Name = "Rectangle";
            this.Rectangle.Size = new System.Drawing.Size(77, 19);
            this.Rectangle.TabIndex = 4;
            this.Rectangle.TabStop = true;
            this.Rectangle.Text = "Rectangle";
            this.Rectangle.UseVisualStyleBackColor = true;
            this.Rectangle.CheckedChanged += new System.EventHandler(this.Rectangle_CheckedChanged);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(131, 108);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 5;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // moveBox1
            // 
            this.moveBox1.Location = new System.Drawing.Point(154, 19);
            this.moveBox1.Name = "moveBox1";
            this.moveBox1.Size = new System.Drawing.Size(20, 23);
            this.moveBox1.TabIndex = 6;
            this.moveBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.moveBox1_KeyPress);
            // 
            // moveBox2
            // 
            this.moveBox2.Location = new System.Drawing.Point(194, 19);
            this.moveBox2.Name = "moveBox2";
            this.moveBox2.Size = new System.Drawing.Size(20, 23);
            this.moveBox2.TabIndex = 7;
            this.moveBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.moveBox2_KeyPress);
            // 
            // X
            // 
            this.X.AutoSize = true;
            this.X.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.X.Location = new System.Drawing.Point(134, 22);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(23, 20);
            this.X.TabIndex = 8;
            this.X.Text = "X:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(175, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Y:";
            // 
            // Angle
            // 
            this.Angle.AutoSize = true;
            this.Angle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Angle.Location = new System.Drawing.Point(244, 22);
            this.Angle.Name = "Angle";
            this.Angle.Size = new System.Drawing.Size(50, 20);
            this.Angle.TabIndex = 10;
            this.Angle.Text = "Angle";
            // 
            // rotateBox
            // 
            this.rotateBox.Location = new System.Drawing.Point(293, 19);
            this.rotateBox.Name = "rotateBox";
            this.rotateBox.Size = new System.Drawing.Size(30, 23);
            this.rotateBox.TabIndex = 11;
            this.rotateBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rotateBox_KeyPress);
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(358, 108);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(75, 23);
            this.Create.TabIndex = 12;
            this.Create.Text = "Create";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // Compare
            // 
            this.Compare.Location = new System.Drawing.Point(136, 72);
            this.Compare.Name = "Compare";
            this.Compare.Size = new System.Drawing.Size(75, 23);
            this.Compare.TabIndex = 13;
            this.Compare.Text = "Compare";
            this.Compare.UseVisualStyleBackColor = true;
            this.Compare.Click += new System.EventHandler(this.Compare_Click);
            // 
            // InClude
            // 
            this.InClude.Location = new System.Drawing.Point(37, 72);
            this.InClude.Name = "InClude";
            this.InClude.Size = new System.Drawing.Size(75, 23);
            this.InClude.TabIndex = 14;
            this.InClude.Text = "InClude";
            this.InClude.UseVisualStyleBackColor = true;
            this.InClude.Click += new System.EventHandler(this.InClude_Click);
            // 
            // IsIntersect
            // 
            this.IsIntersect.Location = new System.Drawing.Point(37, 46);
            this.IsIntersect.Name = "IsIntersect";
            this.IsIntersect.Size = new System.Drawing.Size(75, 23);
            this.IsIntersect.TabIndex = 15;
            this.IsIntersect.Text = "IsIntersect";
            this.IsIntersect.UseVisualStyleBackColor = true;
            this.IsIntersect.Click += new System.EventHandler(this.IsIntersect_Click);
            // 
            // CenterOfGravity
            // 
            this.CenterOfGravity.Location = new System.Drawing.Point(9, 79);
            this.CenterOfGravity.Name = "CenterOfGravity";
            this.CenterOfGravity.Size = new System.Drawing.Size(104, 23);
            this.CenterOfGravity.TabIndex = 16;
            this.CenterOfGravity.Text = "CenterOfGravity";
            this.CenterOfGravity.UseVisualStyleBackColor = true;
            this.CenterOfGravity.Click += new System.EventHandler(this.CenterOfGravity_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.FormattingEnabled = true;
            this.checkBox2.Location = new System.Drawing.Point(37, 17);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(88, 23);
            this.checkBox2.TabIndex = 17;
            // 
            // checkBox1
            // 
            this.checkBox1.FormattingEnabled = true;
            this.checkBox1.Location = new System.Drawing.Point(136, 17);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(88, 23);
            this.checkBox1.TabIndex = 18;
            // 
            // Y1
            // 
            this.Y1.AutoSize = true;
            this.Y1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Y1.Location = new System.Drawing.Point(451, 16);
            this.Y1.Name = "Y1";
            this.Y1.Size = new System.Drawing.Size(22, 20);
            this.Y1.TabIndex = 23;
            this.Y1.Text = "Y:";
            // 
            // X1
            // 
            this.X1.AutoSize = true;
            this.X1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.X1.Location = new System.Drawing.Point(410, 16);
            this.X1.Name = "X1";
            this.X1.Size = new System.Drawing.Size(23, 20);
            this.X1.TabIndex = 22;
            this.X1.Text = "X:";
            // 
            // yBox1
            // 
            this.yBox1.Enabled = false;
            this.yBox1.Location = new System.Drawing.Point(470, 13);
            this.yBox1.Name = "yBox1";
            this.yBox1.Size = new System.Drawing.Size(20, 23);
            this.yBox1.TabIndex = 21;
            this.yBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.yBox1_KeyPress);
            // 
            // xBox1
            // 
            this.xBox1.Enabled = false;
            this.xBox1.Location = new System.Drawing.Point(430, 13);
            this.xBox1.Name = "xBox1";
            this.xBox1.Size = new System.Drawing.Size(20, 23);
            this.xBox1.TabIndex = 20;
            this.xBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.xBox1_KeyPress);
            // 
            // Y3
            // 
            this.Y3.AutoSize = true;
            this.Y3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Y3.Location = new System.Drawing.Point(451, 58);
            this.Y3.Name = "Y3";
            this.Y3.Size = new System.Drawing.Size(22, 20);
            this.Y3.TabIndex = 27;
            this.Y3.Text = "Y:";
            // 
            // X3
            // 
            this.X3.AutoSize = true;
            this.X3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.X3.Location = new System.Drawing.Point(410, 58);
            this.X3.Name = "X3";
            this.X3.Size = new System.Drawing.Size(23, 20);
            this.X3.TabIndex = 26;
            this.X3.Text = "X:";
            // 
            // yBox3
            // 
            this.yBox3.Enabled = false;
            this.yBox3.Location = new System.Drawing.Point(470, 55);
            this.yBox3.Name = "yBox3";
            this.yBox3.Size = new System.Drawing.Size(20, 23);
            this.yBox3.TabIndex = 25;
            this.yBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.yBox3_KeyPress);
            // 
            // xBox3
            // 
            this.xBox3.Enabled = false;
            this.xBox3.Location = new System.Drawing.Point(430, 55);
            this.xBox3.Name = "xBox3";
            this.xBox3.Size = new System.Drawing.Size(20, 23);
            this.xBox3.TabIndex = 24;
            this.xBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.xBox3_KeyPress);
            // 
            // Y2
            // 
            this.Y2.AutoSize = true;
            this.Y2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Y2.Location = new System.Drawing.Point(550, 16);
            this.Y2.Name = "Y2";
            this.Y2.Size = new System.Drawing.Size(22, 20);
            this.Y2.TabIndex = 31;
            this.Y2.Text = "Y:";
            // 
            // X2
            // 
            this.X2.AutoSize = true;
            this.X2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.X2.Location = new System.Drawing.Point(509, 16);
            this.X2.Name = "X2";
            this.X2.Size = new System.Drawing.Size(23, 20);
            this.X2.TabIndex = 30;
            this.X2.Text = "X:";
            // 
            // yBox2
            // 
            this.yBox2.Enabled = false;
            this.yBox2.Location = new System.Drawing.Point(569, 13);
            this.yBox2.Name = "yBox2";
            this.yBox2.Size = new System.Drawing.Size(20, 23);
            this.yBox2.TabIndex = 29;
            this.yBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.yBox2_KeyPress);
            // 
            // xBox2
            // 
            this.xBox2.Enabled = false;
            this.xBox2.Location = new System.Drawing.Point(529, 13);
            this.xBox2.Name = "xBox2";
            this.xBox2.Size = new System.Drawing.Size(20, 23);
            this.xBox2.TabIndex = 28;
            this.xBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.xBox2_KeyPress);
            // 
            // Y4
            // 
            this.Y4.AutoSize = true;
            this.Y4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Y4.Location = new System.Drawing.Point(550, 58);
            this.Y4.Name = "Y4";
            this.Y4.Size = new System.Drawing.Size(22, 20);
            this.Y4.TabIndex = 35;
            this.Y4.Text = "Y:";
            // 
            // X4
            // 
            this.X4.AutoSize = true;
            this.X4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.X4.Location = new System.Drawing.Point(509, 58);
            this.X4.Name = "X4";
            this.X4.Size = new System.Drawing.Size(23, 20);
            this.X4.TabIndex = 34;
            this.X4.Text = "X:";
            // 
            // yBox4
            // 
            this.yBox4.Enabled = false;
            this.yBox4.Location = new System.Drawing.Point(569, 55);
            this.yBox4.Name = "yBox4";
            this.yBox4.Size = new System.Drawing.Size(20, 23);
            this.yBox4.TabIndex = 33;
            this.yBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.yBox4_KeyPress);
            // 
            // xBox4
            // 
            this.xBox4.Enabled = false;
            this.xBox4.Location = new System.Drawing.Point(529, 55);
            this.xBox4.Name = "xBox4";
            this.xBox4.Size = new System.Drawing.Size(20, 23);
            this.xBox4.TabIndex = 32;
            this.xBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.xBox4_KeyPress);
            // 
            // operationBox
            // 
            this.operationBox.FormattingEnabled = true;
            this.operationBox.Location = new System.Drawing.Point(12, 19);
            this.operationBox.Name = "operationBox";
            this.operationBox.Size = new System.Drawing.Size(104, 23);
            this.operationBox.TabIndex = 36;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(348, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 148);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add point";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Delete);
            this.groupBox2.Controls.Add(this.Print);
            this.groupBox2.Controls.Add(this.CenterOfGravity);
            this.groupBox2.Controls.Add(this.Move);
            this.groupBox2.Controls.Add(this.Rotate);
            this.groupBox2.Location = new System.Drawing.Point(3, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(326, 148);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operation";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Controls.Add(this.checkBox2);
            this.groupBox3.Controls.Add(this.IsIntersect);
            this.groupBox3.Controls.Add(this.Compare);
            this.groupBox3.Controls.Add(this.InClude);
            this.groupBox3.Location = new System.Drawing.Point(348, 162);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(249, 109);
            this.groupBox3.TabIndex = 39;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Check";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(3, 161);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(326, 110);
            this.richTextBox1.TabIndex = 40;
            this.richTextBox1.Text = "";
            // 
            // nameBox1
            // 
            this.nameBox1.Location = new System.Drawing.Point(439, 84);
            this.nameBox1.Name = "nameBox1";
            this.nameBox1.Size = new System.Drawing.Size(93, 23);
            this.nameBox1.TabIndex = 41;
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name.Location = new System.Drawing.Point(538, 87);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(51, 20);
            this.Name.TabIndex = 42;
            this.Name.Text = "Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 275);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.nameBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.operationBox);
            this.Controls.Add(this.Y4);
            this.Controls.Add(this.X4);
            this.Controls.Add(this.yBox4);
            this.Controls.Add(this.xBox4);
            this.Controls.Add(this.Y2);
            this.Controls.Add(this.X2);
            this.Controls.Add(this.yBox2);
            this.Controls.Add(this.xBox2);
            this.Controls.Add(this.Y3);
            this.Controls.Add(this.X3);
            this.Controls.Add(this.yBox3);
            this.Controls.Add(this.xBox3);
            this.Controls.Add(this.Y1);
            this.Controls.Add(this.X1);
            this.Controls.Add(this.yBox1);
            this.Controls.Add(this.xBox1);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.rotateBox);
            this.Controls.Add(this.Angle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.X);
            this.Controls.Add(this.moveBox2);
            this.Controls.Add(this.moveBox1);
            this.Controls.Add(this.Rectangle);
            this.Controls.Add(this.Triangle);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Move;
        private System.Windows.Forms.Button Rotate;
        private System.Windows.Forms.Button Print;
        private System.Windows.Forms.RadioButton Triangle;
        private System.Windows.Forms.RadioButton Rectangle;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.TextBox moveBox1;
        private System.Windows.Forms.TextBox moveBox2;
        private System.Windows.Forms.Label X;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Angle;
        private System.Windows.Forms.TextBox rotateBox;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Button Compare;
        private System.Windows.Forms.Button InClude;
        private System.Windows.Forms.Button IsIntersect;
        private System.Windows.Forms.Button CenterOfGravity;
        private System.Windows.Forms.ComboBox checkBox2;
        private System.Windows.Forms.ComboBox checkBox1;
        private System.Windows.Forms.Label Y1;
        private System.Windows.Forms.Label X1;
        private System.Windows.Forms.TextBox yBox1;
        private System.Windows.Forms.TextBox xBox1;
        private System.Windows.Forms.Label Y3;
        private System.Windows.Forms.Label X3;
        private System.Windows.Forms.TextBox yBox3;
        private System.Windows.Forms.TextBox xBox3;
        private System.Windows.Forms.Label Y2;
        private System.Windows.Forms.Label X2;
        private System.Windows.Forms.TextBox yBox2;
        private System.Windows.Forms.TextBox xBox2;
        private System.Windows.Forms.Label Y4;
        private System.Windows.Forms.Label X4;
        private System.Windows.Forms.TextBox yBox4;
        private System.Windows.Forms.TextBox xBox4;
        private System.Windows.Forms.ComboBox operationBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox nameBox1;
        private System.Windows.Forms.Label Name;
    }
}

