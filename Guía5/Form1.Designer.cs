
namespace Guía5
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.rbtn1gerente = new System.Windows.Forms.RadioButton();
            this.rbtn3secretaria = new System.Windows.Forms.RadioButton();
            this.rbtn2subgerente = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label_ans = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(261, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "Problema 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(156, 118);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(157, 22);
            this.txt1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(480, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Salario:";
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(542, 118);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(114, 22);
            this.txt2.TabIndex = 4;
            // 
            // rbtn1gerente
            // 
            this.rbtn1gerente.AutoSize = true;
            this.rbtn1gerente.Location = new System.Drawing.Point(73, 217);
            this.rbtn1gerente.Name = "rbtn1gerente";
            this.rbtn1gerente.Size = new System.Drawing.Size(81, 21);
            this.rbtn1gerente.TabIndex = 5;
            this.rbtn1gerente.TabStop = true;
            this.rbtn1gerente.Text = "Gerente";
            this.rbtn1gerente.UseVisualStyleBackColor = true;
            // 
            // rbtn3secretaria
            // 
            this.rbtn3secretaria.AutoSize = true;
            this.rbtn3secretaria.Location = new System.Drawing.Point(562, 217);
            this.rbtn3secretaria.Name = "rbtn3secretaria";
            this.rbtn3secretaria.Size = new System.Drawing.Size(94, 21);
            this.rbtn3secretaria.TabIndex = 6;
            this.rbtn3secretaria.TabStop = true;
            this.rbtn3secretaria.Text = "Secretaria";
            this.rbtn3secretaria.UseVisualStyleBackColor = true;
            // 
            // rbtn2subgerente
            // 
            this.rbtn2subgerente.AutoSize = true;
            this.rbtn2subgerente.Location = new System.Drawing.Point(314, 217);
            this.rbtn2subgerente.Name = "rbtn2subgerente";
            this.rbtn2subgerente.Size = new System.Drawing.Size(106, 21);
            this.rbtn2subgerente.TabIndex = 7;
            this.rbtn2subgerente.TabStop = true;
            this.rbtn2subgerente.Text = "SubGerente";
            this.rbtn2subgerente.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(326, 362);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(156, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 9;
            // 
            // label_ans
            // 
            this.label_ans.AutoSize = true;
            this.label_ans.Location = new System.Drawing.Point(336, 320);
            this.label_ans.Name = "label_ans";
            this.label_ans.Size = new System.Drawing.Size(0, 17);
            this.label_ans.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 450);
            this.Controls.Add(this.label_ans);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rbtn2subgerente);
            this.Controls.Add(this.rbtn3secretaria);
            this.Controls.Add(this.rbtn1gerente);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.RadioButton rbtn1gerente;
        private System.Windows.Forms.RadioButton rbtn3secretaria;
        private System.Windows.Forms.RadioButton rbtn2subgerente;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_ans;
    }
}

