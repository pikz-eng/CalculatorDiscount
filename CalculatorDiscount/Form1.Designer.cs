
namespace CalculatorDiscount
{
    partial class CalculatorDiscount
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.numeProdusTextBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.discountProdusTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.afisaj = new System.Windows.Forms.Label();
            this.afisare = new System.Windows.Forms.Label();
            this.controlAfisare = new System.Windows.Forms.Label();
            this.btnStergeti = new System.Windows.Forms.Button();
            this.btnCalculeaza = new System.Windows.Forms.Button();
            this.pretProdusTextBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(220, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(402, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "CALCULATOR DISCOUNT";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // numeProdusTextBox
            // 
            this.numeProdusTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.numeProdusTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.numeProdusTextBox.Location = new System.Drawing.Point(27, 82);
            this.numeProdusTextBox.Multiline = true;
            this.numeProdusTextBox.Name = "numeProdusTextBox";
            this.numeProdusTextBox.Size = new System.Drawing.Size(232, 41);
            this.numeProdusTextBox.TabIndex = 1;
            this.numeProdusTextBox.TextChanged += new System.EventHandler(this.numeProdusTextBox_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // discountProdusTextBox
            // 
            this.discountProdusTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.discountProdusTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.discountProdusTextBox.Location = new System.Drawing.Point(27, 210);
            this.discountProdusTextBox.Multiline = true;
            this.discountProdusTextBox.Name = "discountProdusTextBox";
            this.discountProdusTextBox.Size = new System.Drawing.Size(232, 41);
            this.discountProdusTextBox.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.afisaj);
            this.panel1.Controls.Add(this.afisare);
            this.panel1.Controls.Add(this.controlAfisare);
            this.panel1.Location = new System.Drawing.Point(179, 360);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(455, 78);
            this.panel1.TabIndex = 4;
            // 
            // afisaj
            // 
            this.afisaj.AutoSize = true;
            this.afisaj.Location = new System.Drawing.Point(172, 17);
            this.afisaj.Name = "afisaj";
            this.afisaj.Size = new System.Drawing.Size(0, 15);
            this.afisaj.TabIndex = 2;
            // 
            // afisare
            // 
            this.afisare.AutoSize = true;
            this.afisare.Location = new System.Drawing.Point(25, 17);
            this.afisare.Name = "afisare";
            this.afisare.Size = new System.Drawing.Size(0, 15);
            this.afisare.TabIndex = 1;
            // 
            // controlAfisare
            // 
            this.controlAfisare.AutoSize = true;
            this.controlAfisare.CausesValidation = false;
            this.controlAfisare.Location = new System.Drawing.Point(32, 18);
            this.controlAfisare.Name = "controlAfisare";
            this.controlAfisare.Size = new System.Drawing.Size(0, 15);
            this.controlAfisare.TabIndex = 0;
            // 
            // btnStergeti
            // 
            this.btnStergeti.BackColor = System.Drawing.Color.Red;
            this.btnStergeti.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStergeti.Location = new System.Drawing.Point(192, 279);
            this.btnStergeti.Name = "btnStergeti";
            this.btnStergeti.Size = new System.Drawing.Size(147, 39);
            this.btnStergeti.TabIndex = 6;
            this.btnStergeti.Text = "STERGE";
            this.btnStergeti.UseVisualStyleBackColor = false;
            this.btnStergeti.Click += new System.EventHandler(this.btnStergeti_Click);
            // 
            // btnCalculeaza
            // 
            this.btnCalculeaza.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnCalculeaza.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCalculeaza.Location = new System.Drawing.Point(12, 279);
            this.btnCalculeaza.Name = "btnCalculeaza";
            this.btnCalculeaza.Size = new System.Drawing.Size(147, 39);
            this.btnCalculeaza.TabIndex = 7;
            this.btnCalculeaza.Text = "CALCULEAZA";
            this.btnCalculeaza.UseVisualStyleBackColor = false;
            this.btnCalculeaza.Click += new System.EventHandler(this.btnCalculeaza_Click);
            // 
            // pretProdusTextBox
            // 
            this.pretProdusTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pretProdusTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.pretProdusTextBox.Location = new System.Drawing.Point(27, 144);
            this.pretProdusTextBox.Multiline = true;
            this.pretProdusTextBox.Name = "pretProdusTextBox";
            this.pretProdusTextBox.Size = new System.Drawing.Size(232, 41);
            this.pretProdusTextBox.TabIndex = 8;
            // 
            // CalculatorDiscount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pretProdusTextBox);
            this.Controls.Add(this.btnCalculeaza);
            this.Controls.Add(this.btnStergeti);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.discountProdusTextBox);
            this.Controls.Add(this.numeProdusTextBox);
            this.Controls.Add(this.label1);
            this.Name = "CalculatorDiscount";
            this.Text = "CalculatorDiscount";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numeProdusTextBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox discountProdusTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label controlAfisare;
        private System.Windows.Forms.Label afisare;
        private System.Windows.Forms.Button btnStergeti;
        private System.Windows.Forms.Label afisaj;
        private System.Windows.Forms.Button btnCalculeaza;
        private System.Windows.Forms.TextBox pretProdusTextBox;
    }
}

