namespace ChuckNorrisGenerator
{
    partial class Form1
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
            this.btnGetJoke = new System.Windows.Forms.Button();
            this.cboCatagoies = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnGetJoke
            // 
            this.btnGetJoke.Location = new System.Drawing.Point(60, 12);
            this.btnGetJoke.Name = "btnGetJoke";
            this.btnGetJoke.Size = new System.Drawing.Size(151, 24);
            this.btnGetJoke.TabIndex = 0;
            this.btnGetJoke.Text = "Get Joke";
            this.btnGetJoke.UseVisualStyleBackColor = true;
            this.btnGetJoke.Click += new System.EventHandler(this.btnGetJoke_ClickAsync);
            // 
            // cboCatagoies
            // 
            this.cboCatagoies.FormattingEnabled = true;
            this.cboCatagoies.Location = new System.Drawing.Point(38, 42);
            this.cboCatagoies.Name = "cboCatagoies";
            this.cboCatagoies.Size = new System.Drawing.Size(197, 21);
            this.cboCatagoies.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 79);
            this.Controls.Add(this.cboCatagoies);
            this.Controls.Add(this.btnGetJoke);
            this.Name = "Form1";
            this.Text = "Chuck Norris Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGetJoke;
        private System.Windows.Forms.ComboBox cboCatagoies;
    }
}

