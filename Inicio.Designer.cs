
namespace Picas_y_Fijas
{
    partial class Inicio
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Jugador1 = new System.Windows.Forms.TextBox();
            this.botonEmpezar = new System.Windows.Forms.Button();
            this.Label = new System.Windows.Forms.Label();
            this.Jugador2 = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(319, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(293, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 45);
            this.label2.TabIndex = 5;
            this.label2.Text = "Picas y Fijas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(202, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 33);
            this.label3.TabIndex = 6;
            this.label3.Text = "Jugador 1:";
            this.label3.Click += new System.EventHandler(this.jugador1);
            // 
            // Jugador1
            // 
            this.Jugador1.Location = new System.Drawing.Point(347, 206);
            this.Jugador1.MaxLength = 50;
            this.Jugador1.Name = "Jugador1";
            this.Jugador1.Size = new System.Drawing.Size(165, 20);
            this.Jugador1.TabIndex = 7;
            this.Jugador1.Text = "Escribe su nombre";
            this.Jugador1.TextChanged += new System.EventHandler(this.Jugador1_TextChanged);
            // 
            // botonEmpezar
            // 
            this.botonEmpezar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.botonEmpezar.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonEmpezar.ForeColor = System.Drawing.Color.Blue;
            this.botonEmpezar.Location = new System.Drawing.Point(356, 320);
            this.botonEmpezar.Name = "botonEmpezar";
            this.botonEmpezar.Size = new System.Drawing.Size(137, 46);
            this.botonEmpezar.TabIndex = 10;
            this.botonEmpezar.Text = "EMPEZAR";
            this.botonEmpezar.UseVisualStyleBackColor = false;
            this.botonEmpezar.Click += new System.EventHandler(this.botonEmpezar_Click_1);
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label.ForeColor = System.Drawing.Color.Blue;
            this.Label.Location = new System.Drawing.Point(195, 262);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(133, 33);
            this.Label.TabIndex = 12;
            this.Label.Text = "Jugador 2: ";
            // 
            // Jugador2
            // 
            this.Jugador2.Location = new System.Drawing.Point(356, 275);
            this.Jugador2.Name = "Jugador2";
            this.Jugador2.Size = new System.Drawing.Size(165, 20);
            this.Jugador2.TabIndex = 13;
            this.Jugador2.Text = "Escriba su nombre";
            this.Jugador2.TextChanged += new System.EventHandler(this.Jugador2_TextChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(239, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(317, 79);
            this.label4.TabIndex = 14;
            this.label4.Text = "Bienvenidos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Picas_y_Fijas.Properties.Resources.cerebro;
            this.pictureBox1.Location = new System.Drawing.Point(562, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(238, 239);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Jugador2);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.botonEmpezar);
            this.Controls.Add(this.Jugador1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.MediumBlue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Picas y Fijas";
            this.Load += new System.EventHandler(this.Inicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Jugador1;
        private System.Windows.Forms.Button botonEmpezar;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.TextBox Jugador2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

