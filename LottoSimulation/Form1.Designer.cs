namespace LottoSimulation
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
            panel = new Panel();
            btnSorsol = new Button();
            btnBezar = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // panel
            // 
            panel.Location = new Point(17, 16);
            panel.Name = "panel";
            panel.Size = new Size(560, 500);
            panel.TabIndex = 0;
            // 
            // btnSorsol
            // 
            btnSorsol.Location = new Point(609, 16);
            btnSorsol.Name = "btnSorsol";
            btnSorsol.Size = new Size(75, 23);
            btnSorsol.TabIndex = 1;
            btnSorsol.Text = "Sorsolás";
            btnSorsol.UseVisualStyleBackColor = true;
            btnSorsol.Click += btnSorsol_Click;
            // 
            // btnBezar
            // 
            btnBezar.Location = new Point(609, 55);
            btnBezar.Name = "btnBezar";
            btnBezar.Size = new Size(75, 23);
            btnBezar.TabIndex = 2;
            btnBezar.Text = "Bezár";
            btnBezar.UseVisualStyleBackColor = true;
            btnBezar.Click += btnBezar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(609, 96);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 3;
            label1.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnBezar);
            Controls.Add(btnSorsol);
            Controls.Add(panel);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel;
        private Button btnSorsol;
        private Button btnBezar;
        private Label label1;
    }
}