namespace ConvertorTemperaturas
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
            groupBox1 = new GroupBox();
            calcularButton = new Button();
            label2 = new Label();
            temperatureTextBox = new TextBox();
            convertionTextBox = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(calcularButton);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(temperatureTextBox);
            groupBox1.Controls.Add(convertionTextBox);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(282, 69);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(435, 290);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Calculadora de grados";
            // 
            // calcularButton
            // 
            calcularButton.Location = new Point(151, 220);
            calcularButton.Name = "calcularButton";
            calcularButton.Size = new Size(94, 29);
            calcularButton.TabIndex = 4;
            calcularButton.Text = "Calcular";
            calcularButton.UseVisualStyleBackColor = true;
            calcularButton.Click += calcularButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(136, 122);
            label2.Name = "label2";
            label2.Size = new Size(131, 20);
            label2.TabIndex = 3;
            label2.Text = "Escribe el numero ";
            // 
            // temperatureTextBox
            // 
            temperatureTextBox.Location = new Point(136, 158);
            temperatureTextBox.Name = "temperatureTextBox";
            temperatureTextBox.Size = new Size(125, 27);
            temperatureTextBox.TabIndex = 2;
            // 
            // convertionTextBox
            // 
            convertionTextBox.Location = new Point(87, 83);
            convertionTextBox.Name = "convertionTextBox";
            convertionTextBox.Size = new Size(283, 27);
            convertionTextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 43);
            label1.Name = "label1";
            label1.Size = new Size(321, 20);
            label1.TabIndex = 0;
            label1.Text = "Ingrese el valor que le gustaria convertir (F o C)";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 518);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox convertionTextBox;
        private Label label2;
        private TextBox temperatureTextBox;
        private Button calcularButton;
    }
}
