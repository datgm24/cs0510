namespace cs0510
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
            mybutton = new Button();
            SuspendLayout();
            // 
            // mybutton
            // 
            mybutton.BackColor = Color.FromArgb(255, 255, 192);
            mybutton.Font = new Font("Tw Cen MT Condensed Extra Bold", 32F, FontStyle.Regular, GraphicsUnit.Point);
            mybutton.ForeColor = Color.FromArgb(192, 64, 0);
            mybutton.Location = new Point(63, 75);
            mybutton.Name = "mybutton";
            mybutton.Size = new Size(300, 200);
            mybutton.TabIndex = 0;
            mybutton.Text = "button1";
            mybutton.UseVisualStyleBackColor = false;
            mybutton.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(mybutton);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button mybutton;
    }
}