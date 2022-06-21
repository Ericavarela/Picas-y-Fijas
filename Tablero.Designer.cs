
namespace Picas_y_Fijas
{
    partial class Tablero
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tablero));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numUsuario = new System.Windows.Forms.TextBox();
            this.Calcular = new System.Windows.Forms.Button();
            this.numOculto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(28, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite el número para descrifrar :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(127, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Digite su número :";
            // 
            // numUsuario
            // 
            this.numUsuario.Location = new System.Drawing.Point(284, 62);
            this.numUsuario.Name = "numUsuario";
            this.numUsuario.Size = new System.Drawing.Size(100, 20);
            this.numUsuario.TabIndex = 3;
            // 
            // Calcular
            // 
            this.Calcular.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Calcular.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calcular.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Calcular.Location = new System.Drawing.Point(266, 104);
            this.Calcular.Name = "Calcular";
            this.Calcular.Size = new System.Drawing.Size(149, 35);
            this.Calcular.TabIndex = 4;
            this.Calcular.Text = "Calcular Picas y Fijas";
            this.Calcular.UseVisualStyleBackColor = false;
            // 
            // numOculto
            // 
            this.numOculto.BackColor = System.Drawing.Color.White;
            this.numOculto.Location = new System.Drawing.Point(284, 28);
            this.numOculto.Name = "numOculto";
            this.numOculto.Size = new System.Drawing.Size(100, 20);
            this.numOculto.TabIndex = 1;
            // 
            // Tablero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Calcular);
            this.Controls.Add(this.numUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numOculto);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Tablero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Picas y Fijas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox numUsuario;
        private System.Windows.Forms.Button Calcular;
        private System.Windows.Forms.TextBox numOculto;
    }
}