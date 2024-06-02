namespace SpaceInvaderTest
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
            btnMulti = new Button();
            txtA = new TextBox();
            txtB = new TextBox();
            lTotal = new Label();
            X = new Label();
            SuspendLayout();
            // 
            // btnMulti
            // 
            btnMulti.Location = new Point(320, 110);
            btnMulti.Name = "btnMulti";
            btnMulti.Size = new Size(114, 23);
            btnMulti.TabIndex = 0;
            btnMulti.Text = "MULTIPLICAR";
            btnMulti.UseVisualStyleBackColor = true;
            btnMulti.Click += btnMulti_Click;
            // 
            // txtA
            // 
            txtA.Location = new Point(252, 151);
            txtA.Name = "txtA";
            txtA.Size = new Size(100, 23);
            txtA.TabIndex = 1;
            // 
            // txtB
            // 
            txtB.Location = new Point(402, 151);
            txtB.Name = "txtB";
            txtB.Size = new Size(100, 23);
            txtB.TabIndex = 2;
            // 
            // lTotal
            // 
            lTotal.AutoSize = true;
            lTotal.Location = new Point(527, 154);
            lTotal.Name = "lTotal";
            lTotal.Size = new Size(38, 15);
            lTotal.TabIndex = 3;
            lTotal.Text = "label1";
            // 
            // X
            // 
            X.AutoSize = true;
            X.Location = new Point(371, 154);
            X.Name = "X";
            X.Size = new Size(14, 15);
            X.TabIndex = 4;
            X.Text = "X";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(X);
            Controls.Add(lTotal);
            Controls.Add(txtB);
            Controls.Add(txtA);
            Controls.Add(btnMulti);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMulti;
        private TextBox txtA;
        private TextBox txtB;
        private Label lTotal;
        private Label X;
    }
}
