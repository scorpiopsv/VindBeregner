namespace VindBeregner
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
            this.btnUdregn = new System.Windows.Forms.Button();
            this.txtResultat = new System.Windows.Forms.TextBox();
            this.numVindstyrke = new System.Windows.Forms.NumericUpDown();
            this.numMaxEffekt = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numVindstyrke)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxEffekt)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUdregn
            // 
            this.btnUdregn.Location = new System.Drawing.Point(91, 86);
            this.btnUdregn.Name = "btnUdregn";
            this.btnUdregn.Size = new System.Drawing.Size(120, 23);
            this.btnUdregn.TabIndex = 0;
            this.btnUdregn.Text = "Udregn";
            this.btnUdregn.UseVisualStyleBackColor = true;
            this.btnUdregn.Click += new System.EventHandler(this.btnUdregn_Click);
            // 
            // txtResultat
            // 
            this.txtResultat.Location = new System.Drawing.Point(91, 115);
            this.txtResultat.Name = "txtResultat";
            this.txtResultat.Size = new System.Drawing.Size(120, 20);
            this.txtResultat.TabIndex = 1;
            // 
            // numVindstyrke
            // 
            this.numVindstyrke.Location = new System.Drawing.Point(91, 34);
            this.numVindstyrke.Name = "numVindstyrke";
            this.numVindstyrke.Size = new System.Drawing.Size(120, 20);
            this.numVindstyrke.TabIndex = 3;
            // 
            // numMaxEffekt
            // 
            this.numMaxEffekt.Location = new System.Drawing.Point(91, 60);
            this.numMaxEffekt.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numMaxEffekt.Name = "numMaxEffekt";
            this.numMaxEffekt.Size = new System.Drawing.Size(120, 20);
            this.numMaxEffekt.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Vindstyrke";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Max effekt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 212);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numMaxEffekt);
            this.Controls.Add(this.numVindstyrke);
            this.Controls.Add(this.txtResultat);
            this.Controls.Add(this.btnUdregn);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numVindstyrke)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxEffekt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUdregn;
        private System.Windows.Forms.TextBox txtResultat;
        private System.Windows.Forms.NumericUpDown numVindstyrke;
        private System.Windows.Forms.NumericUpDown numMaxEffekt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

