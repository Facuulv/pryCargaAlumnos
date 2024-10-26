namespace pryFinalTP
{
    partial class CargaAlumnos
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFilas = new System.Windows.Forms.Button();
            this.numCargarFilas = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCargarAlumno = new System.Windows.Forms.Button();
            this.lblCantFilas = new System.Windows.Forms.Label();
            this.numTp = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numParcial2 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numParcial1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAlumno = new System.Windows.Forms.TextBox();
            this.dgvAlumnos = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnResultados = new System.Windows.Forms.Button();
            this.lblDesaprobados = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblAprobados = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblPromo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPromGral = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCargarFilas)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numParcial2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numParcial1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFilas);
            this.groupBox1.Controls.Add(this.numCargarFilas);
            this.groupBox1.Location = new System.Drawing.Point(37, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(224, 120);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cantidad de Alumnos";
            // 
            // btnFilas
            // 
            this.btnFilas.Location = new System.Drawing.Point(62, 81);
            this.btnFilas.Name = "btnFilas";
            this.btnFilas.Size = new System.Drawing.Size(96, 33);
            this.btnFilas.TabIndex = 1;
            this.btnFilas.Text = "Cargar";
            this.btnFilas.UseVisualStyleBackColor = true;
            this.btnFilas.Click += new System.EventHandler(this.btnFilas_Click);
            // 
            // numCargarFilas
            // 
            this.numCargarFilas.Location = new System.Drawing.Point(43, 38);
            this.numCargarFilas.Name = "numCargarFilas";
            this.numCargarFilas.Size = new System.Drawing.Size(133, 22);
            this.numCargarFilas.TabIndex = 0;
            this.numCargarFilas.ValueChanged += new System.EventHandler(this.numCargarFilas_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCargarAlumno);
            this.groupBox2.Controls.Add(this.lblCantFilas);
            this.groupBox2.Controls.Add(this.numTp);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.numParcial2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.numParcial1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtAlumno);
            this.groupBox2.Location = new System.Drawing.Point(316, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(357, 184);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Notas de Alumno";
            // 
            // btnCargarAlumno
            // 
            this.btnCargarAlumno.Location = new System.Drawing.Point(52, 130);
            this.btnCargarAlumno.Name = "btnCargarAlumno";
            this.btnCargarAlumno.Size = new System.Drawing.Size(127, 40);
            this.btnCargarAlumno.TabIndex = 9;
            this.btnCargarAlumno.Text = "Cargar Alumno";
            this.btnCargarAlumno.UseVisualStyleBackColor = true;
            this.btnCargarAlumno.Click += new System.EventHandler(this.btnCargarAlumno_Click);
            // 
            // lblCantFilas
            // 
            this.lblCantFilas.AutoSize = true;
            this.lblCantFilas.Location = new System.Drawing.Point(96, 104);
            this.lblCantFilas.Name = "lblCantFilas";
            this.lblCantFilas.Size = new System.Drawing.Size(0, 16);
            this.lblCantFilas.TabIndex = 8;
            // 
            // numTp
            // 
            this.numTp.Location = new System.Drawing.Point(254, 140);
            this.numTp.Name = "numTp";
            this.numTp.Size = new System.Drawing.Size(74, 22);
            this.numTp.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(277, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tp";
            // 
            // numParcial2
            // 
            this.numParcial2.Location = new System.Drawing.Point(254, 89);
            this.numParcial2.Name = "numParcial2";
            this.numParcial2.Size = new System.Drawing.Size(74, 22);
            this.numParcial2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(260, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Parcial 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Parcial 1";
            // 
            // numParcial1
            // 
            this.numParcial1.Location = new System.Drawing.Point(254, 38);
            this.numParcial1.Name = "numParcial1";
            this.numParcial1.Size = new System.Drawing.Size(74, 22);
            this.numParcial1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre y Apellido";
            // 
            // txtAlumno
            // 
            this.txtAlumno.Location = new System.Drawing.Point(33, 49);
            this.txtAlumno.Name = "txtAlumno";
            this.txtAlumno.Size = new System.Drawing.Size(162, 22);
            this.txtAlumno.TabIndex = 0;
            // 
            // dgvAlumnos
            // 
            this.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumnos.Location = new System.Drawing.Point(12, 225);
            this.dgvAlumnos.Name = "dgvAlumnos";
            this.dgvAlumnos.ReadOnly = true;
            this.dgvAlumnos.RowHeadersWidth = 51;
            this.dgvAlumnos.RowTemplate.Height = 24;
            this.dgvAlumnos.Size = new System.Drawing.Size(740, 414);
            this.dgvAlumnos.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnResultados);
            this.groupBox3.Controls.Add(this.lblDesaprobados);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.lblAprobados);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.lblPromo);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.lblPromGral);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(778, 35);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(311, 546);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Resultados";
            // 
            // btnResultados
            // 
            this.btnResultados.Location = new System.Drawing.Point(49, 481);
            this.btnResultados.Name = "btnResultados";
            this.btnResultados.Size = new System.Drawing.Size(210, 48);
            this.btnResultados.TabIndex = 8;
            this.btnResultados.Text = "Ver Resultados";
            this.btnResultados.UseVisualStyleBackColor = true;
            this.btnResultados.Click += new System.EventHandler(this.btnResultados_Click);
            // 
            // lblDesaprobados
            // 
            this.lblDesaprobados.AutoSize = true;
            this.lblDesaprobados.Location = new System.Drawing.Point(114, 432);
            this.lblDesaprobados.Name = "lblDesaprobados";
            this.lblDesaprobados.Size = new System.Drawing.Size(0, 16);
            this.lblDesaprobados.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 432);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "Desaprobados:";
            // 
            // lblAprobados
            // 
            this.lblAprobados.AutoSize = true;
            this.lblAprobados.Location = new System.Drawing.Point(90, 312);
            this.lblAprobados.Name = "lblAprobados";
            this.lblAprobados.Size = new System.Drawing.Size(0, 16);
            this.lblAprobados.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 312);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Aprobados:";
            // 
            // lblPromo
            // 
            this.lblPromo.AutoSize = true;
            this.lblPromo.Location = new System.Drawing.Point(118, 190);
            this.lblPromo.Name = "lblPromo";
            this.lblPromo.Size = new System.Drawing.Size(0, 16);
            this.lblPromo.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Promocionados:";
            // 
            // lblPromGral
            // 
            this.lblPromGral.AutoSize = true;
            this.lblPromGral.Location = new System.Drawing.Point(132, 70);
            this.lblPromGral.Name = "lblPromGral";
            this.lblPromGral.Size = new System.Drawing.Size(0, 16);
            this.lblPromGral.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Promedio General:";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(883, 601);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(102, 38);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // CargaAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1101, 651);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dgvAlumnos);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "CargaAlumnos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carga de Alumnos y Consulta";
            this.Load += new System.EventHandler(this.CargaAlumnos_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numCargarFilas)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numParcial2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numParcial1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFilas;
        private System.Windows.Forms.NumericUpDown numCargarFilas;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown numTp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numParcial2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numParcial1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAlumno;
        private System.Windows.Forms.Button btnCargarAlumno;
        private System.Windows.Forms.Label lblCantFilas;
        private System.Windows.Forms.DataGridView dgvAlumnos;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblDesaprobados;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblAprobados;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblPromo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblPromGral;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnResultados;
        private System.Windows.Forms.Button btnSalir;
    }
}

