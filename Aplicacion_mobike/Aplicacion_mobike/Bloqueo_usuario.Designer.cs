namespace Aplicacion_mobike
{
    partial class Bloqueo_usuario
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bloqueo_usuario));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboHoras = new System.Windows.Forms.ComboBox();
            this.cboMinutos = new System.Windows.Forms.ComboBox();
            this.cboSegundos = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txt_rut_test = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.reporte_txt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Silver;
            this.button1.Location = new System.Drawing.Point(40, 290);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Silver;
            this.button2.Location = new System.Drawing.Point(168, 290);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(49, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selecciona el tiempo de bloqueo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(25, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Horas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(25, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Minutos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(25, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Segundos";
            // 
            // cboHoras
            // 
            this.cboHoras.FormattingEnabled = true;
            this.cboHoras.Location = new System.Drawing.Point(28, 125);
            this.cboHoras.Name = "cboHoras";
            this.cboHoras.Size = new System.Drawing.Size(121, 21);
            this.cboHoras.TabIndex = 6;
            // 
            // cboMinutos
            // 
            this.cboMinutos.FormattingEnabled = true;
            this.cboMinutos.Location = new System.Drawing.Point(28, 191);
            this.cboMinutos.Name = "cboMinutos";
            this.cboMinutos.Size = new System.Drawing.Size(121, 21);
            this.cboMinutos.TabIndex = 7;
            // 
            // cboSegundos
            // 
            this.cboSegundos.FormattingEnabled = true;
            this.cboSegundos.Location = new System.Drawing.Point(28, 243);
            this.cboSegundos.Name = "cboSegundos";
            this.cboSegundos.Size = new System.Drawing.Size(121, 21);
            this.cboSegundos.TabIndex = 8;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txt_rut_test
            // 
            this.txt_rut_test.Location = new System.Drawing.Point(28, 66);
            this.txt_rut_test.Name = "txt_rut_test";
            this.txt_rut_test.ReadOnly = true;
            this.txt_rut_test.Size = new System.Drawing.Size(121, 20);
            this.txt_rut_test.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(25, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "RUT usuario";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(176, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Numero reporte";
            // 
            // reporte_txt
            // 
            this.reporte_txt.Location = new System.Drawing.Point(179, 66);
            this.reporte_txt.Name = "reporte_txt";
            this.reporte_txt.ReadOnly = true;
            this.reporte_txt.Size = new System.Drawing.Size(121, 20);
            this.reporte_txt.TabIndex = 12;
            // 
            // Bloqueo_usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(352, 334);
            this.Controls.Add(this.reporte_txt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_rut_test);
            this.Controls.Add(this.cboSegundos);
            this.Controls.Add(this.cboMinutos);
            this.Controls.Add(this.cboHoras);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Bloqueo_usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bloqueo_usuario";
            this.Load += new System.EventHandler(this.Bloqueo_usuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboHoras;
        private System.Windows.Forms.ComboBox cboMinutos;
        private System.Windows.Forms.ComboBox cboSegundos;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.TextBox txt_rut_test;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox reporte_txt;
    }
}