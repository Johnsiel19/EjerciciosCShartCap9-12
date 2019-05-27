namespace EjercicosCap9_12.cap10
{
    partial class Ejercicio2Cap10
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AgregarButton = new System.Windows.Forms.Button();
            this.PadreTextBox = new System.Windows.Forms.TextBox();
            this.MadreTextBox = new System.Windows.Forms.TextBox();
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AgregarButton
            // 
            this.AgregarButton.Location = new System.Drawing.Point(170, 151);
            this.AgregarButton.Margin = new System.Windows.Forms.Padding(4);
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.Size = new System.Drawing.Size(100, 28);
            this.AgregarButton.TabIndex = 19;
            this.AgregarButton.Text = "Agregar";
            this.AgregarButton.UseVisualStyleBackColor = true;
            this.AgregarButton.Click += new System.EventHandler(this.AgregarButton_Click_1);
            // 
            // PadreTextBox
            // 
            this.PadreTextBox.Location = new System.Drawing.Point(119, 64);
            this.PadreTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.PadreTextBox.Name = "PadreTextBox";
            this.PadreTextBox.Size = new System.Drawing.Size(177, 22);
            this.PadreTextBox.TabIndex = 17;
            // 
            // MadreTextBox
            // 
            this.MadreTextBox.Location = new System.Drawing.Point(119, 103);
            this.MadreTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.MadreTextBox.Name = "MadreTextBox";
            this.MadreTextBox.Size = new System.Drawing.Size(177, 22);
            this.MadreTextBox.TabIndex = 16;
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Location = new System.Drawing.Point(119, 24);
            this.NombreTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(177, 22);
            this.NombreTextBox.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 64);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Padre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 106);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Madre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nombre ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(54, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 28);
            this.button1.TabIndex = 23;
            this.button1.Text = "Nuevo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Ejercicio2Cap10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 198);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AgregarButton);
            this.Controls.Add(this.PadreTextBox);
            this.Controls.Add(this.MadreTextBox);
            this.Controls.Add(this.NombreTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Ejercicio2Cap10";
            this.Text = "Ejercicio2Cap10";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AgregarButton;
        private System.Windows.Forms.TextBox PadreTextBox;
        private System.Windows.Forms.TextBox MadreTextBox;
        private System.Windows.Forms.TextBox NombreTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}