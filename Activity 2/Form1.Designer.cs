namespace Activity_2
{
    partial class Activity2
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
            this.InputWeightTB = new System.Windows.Forms.TextBox();
            this.InputWeightLB = new System.Windows.Forms.Label();
            this.OutputWeightLB = new System.Windows.Forms.Label();
            this.OutputWeightTB = new System.Windows.Forms.TextBox();
            this.CloseButton = new System.Windows.Forms.Button();
            this.ConvertButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InputWeightTB
            // 
            this.InputWeightTB.Location = new System.Drawing.Point(264, 24);
            this.InputWeightTB.Name = "InputWeightTB";
            this.InputWeightTB.Size = new System.Drawing.Size(100, 20);
            this.InputWeightTB.TabIndex = 1;
            // 
            // InputWeightLB
            // 
            this.InputWeightLB.AutoSize = true;
            this.InputWeightLB.Location = new System.Drawing.Point(119, 27);
            this.InputWeightLB.Name = "InputWeightLB";
            this.InputWeightLB.Size = new System.Drawing.Size(138, 13);
            this.InputWeightLB.TabIndex = 2;
            this.InputWeightLB.Text = "Enter your weight in pounds";
            // 
            // OutputWeightLB
            // 
            this.OutputWeightLB.AutoSize = true;
            this.OutputWeightLB.Location = new System.Drawing.Point(25, 69);
            this.OutputWeightLB.Name = "OutputWeightLB";
            this.OutputWeightLB.Size = new System.Drawing.Size(232, 13);
            this.OutputWeightLB.TabIndex = 3;
            this.OutputWeightLB.Text = "Your wieght in .44 Magnum Desert Eagle pistols";
            // 
            // OutputWeightTB
            // 
            this.OutputWeightTB.Location = new System.Drawing.Point(264, 69);
            this.OutputWeightTB.Name = "OutputWeightTB";
            this.OutputWeightTB.ReadOnly = true;
            this.OutputWeightTB.Size = new System.Drawing.Size(100, 20);
            this.OutputWeightTB.TabIndex = 4;
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(72, 106);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 5;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // ConvertButton
            // 
            this.ConvertButton.Location = new System.Drawing.Point(264, 106);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(75, 23);
            this.ConvertButton.TabIndex = 6;
            this.ConvertButton.Text = "Convert";
            this.ConvertButton.UseVisualStyleBackColor = true;
            this.ConvertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // Activity2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 158);
            this.Controls.Add(this.ConvertButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.OutputWeightTB);
            this.Controls.Add(this.OutputWeightLB);
            this.Controls.Add(this.InputWeightLB);
            this.Controls.Add(this.InputWeightTB);
            this.Name = "Activity2";
            this.Text = "Activity 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputWeightTB;
        private System.Windows.Forms.Label InputWeightLB;
        private System.Windows.Forms.Label OutputWeightLB;
        private System.Windows.Forms.TextBox OutputWeightTB;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button ConvertButton;
    }
}

