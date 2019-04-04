namespace WhatsTheWeatherDesktopApp
{
    partial class MainWindow
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
            this.enterCityLbl = new System.Windows.Forms.Label();
            this.enterCityTextBox = new System.Windows.Forms.TextBox();
            this.getDataBtn = new System.Windows.Forms.Button();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.helloWorldBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // enterCityLbl
            // 
            this.enterCityLbl.AutoSize = true;
            this.enterCityLbl.Location = new System.Drawing.Point(24, 74);
            this.enterCityLbl.Name = "enterCityLbl";
            this.enterCityLbl.Size = new System.Drawing.Size(110, 17);
            this.enterCityLbl.TabIndex = 0;
            this.enterCityLbl.Text = "Enter City Name";
            // 
            // enterCityTextBox
            // 
            this.enterCityTextBox.Location = new System.Drawing.Point(27, 109);
            this.enterCityTextBox.Name = "enterCityTextBox";
            this.enterCityTextBox.Size = new System.Drawing.Size(250, 22);
            this.enterCityTextBox.TabIndex = 1;
            // 
            // getDataBtn
            // 
            this.getDataBtn.Location = new System.Drawing.Point(27, 152);
            this.getDataBtn.Name = "getDataBtn";
            this.getDataBtn.Size = new System.Drawing.Size(75, 23);
            this.getDataBtn.TabIndex = 2;
            this.getDataBtn.Text = "Get Data";
            this.getDataBtn.UseVisualStyleBackColor = true;
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(416, 23);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(356, 401);
            this.resultTextBox.TabIndex = 3;
            // 
            // helloWorldBtn
            // 
            this.helloWorldBtn.Location = new System.Drawing.Point(269, 401);
            this.helloWorldBtn.Name = "helloWorldBtn";
            this.helloWorldBtn.Size = new System.Drawing.Size(120, 23);
            this.helloWorldBtn.TabIndex = 4;
            this.helloWorldBtn.Text = "Hello World";
            this.helloWorldBtn.UseVisualStyleBackColor = true;
            this.helloWorldBtn.Click += new System.EventHandler(this.helloWorldBtn_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.helloWorldBtn);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.getDataBtn);
            this.Controls.Add(this.enterCityTextBox);
            this.Controls.Add(this.enterCityLbl);
            this.Name = "MainWindow";
            this.Text = "Whats The Weather";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label enterCityLbl;
        private System.Windows.Forms.TextBox enterCityTextBox;
        private System.Windows.Forms.Button getDataBtn;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Button helloWorldBtn;
    }
}

