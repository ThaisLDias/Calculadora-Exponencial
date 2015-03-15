namespace CalculadoraRecursiva
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
            this.bt = new System.Windows.Forms.Button();
            this.visor = new System.Windows.Forms.Label();
            this.visor2 = new System.Windows.Forms.TextBox();
            this.bt2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt
            // 
            this.bt.Location = new System.Drawing.Point(72, 86);
            this.bt.Name = "bt";
            this.bt.Size = new System.Drawing.Size(119, 26);
            this.bt.TabIndex = 0;
            this.bt.Text = "Gerar Recursivo";
            this.bt.UseVisualStyleBackColor = true;
            this.bt.Click += new System.EventHandler(this.bt_Click);
            // 
            // visor
            // 
            this.visor.AutoSize = true;
            this.visor.Location = new System.Drawing.Point(16, 17);
            this.visor.Name = "visor";
            this.visor.Size = new System.Drawing.Size(61, 13);
            this.visor.TabIndex = 1;
            this.visor.Text = "Resultado: ";
            // 
            // visor2
            // 
            this.visor2.Location = new System.Drawing.Point(12, 53);
            this.visor2.Name = "visor2";
            this.visor2.Size = new System.Drawing.Size(260, 20);
            this.visor2.TabIndex = 2;
            this.visor2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.visor2_KeyPress);
            // 
            // bt2
            // 
            this.bt2.Location = new System.Drawing.Point(71, 124);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(119, 25);
            this.bt2.TabIndex = 3;
            this.bt2.Text = "Gerar Iterativo";
            this.bt2.UseVisualStyleBackColor = true;
            this.bt2.Click += new System.EventHandler(this.bt2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 182);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.visor2);
            this.Controls.Add(this.visor);
            this.Controls.Add(this.bt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt;
        private System.Windows.Forms.Label visor;
        private System.Windows.Forms.TextBox visor2;
        private System.Windows.Forms.Button bt2;
    }
}

