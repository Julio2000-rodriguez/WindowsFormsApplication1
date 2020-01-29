namespace WindowsFormsApplication1
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
            this.btnProcesar = new System.Windows.Forms.Button();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.lblNum1 = new System.Windows.Forms.Label();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.lblRespuesta = new System.Windows.Forms.Label();
            this.grbOperaciones = new System.Windows.Forms.GroupBox();
            this.optSuma = new System.Windows.Forms.RadioButton();
            this.optMult = new System.Windows.Forms.RadioButton();
            this.optResta = new System.Windows.Forms.RadioButton();
            this.optDivis = new System.Windows.Forms.RadioButton();
            this.grbOperaciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(37, 170);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(75, 23);
            this.btnProcesar.TabIndex = 0;
            this.btnProcesar.Text = "Procesar ";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(54, 84);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(27, 20);
            this.txtNum1.TabIndex = 1;
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(144, 88);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(33, 20);
            this.txtNum2.TabIndex = 2;
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.Location = new System.Drawing.Point(12, 91);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(38, 13);
            this.lblNum1.TabIndex = 3;
            this.lblNum1.Text = "Num 1";
            // 
            // lblNum2
            // 
            this.lblNum2.AutoSize = true;
            this.lblNum2.Location = new System.Drawing.Point(100, 91);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(38, 13);
            this.lblNum2.TabIndex = 4;
            this.lblNum2.Text = "Num 2";
            // 
            // lblRespuesta
            // 
            this.lblRespuesta.AutoSize = true;
            this.lblRespuesta.Location = new System.Drawing.Point(51, 138);
            this.lblRespuesta.Name = "lblRespuesta";
            this.lblRespuesta.Size = new System.Drawing.Size(61, 13);
            this.lblRespuesta.TabIndex = 5;
            this.lblRespuesta.Text = "Respuesta ";
            // 
            // grbOperaciones
            // 
            this.grbOperaciones.Controls.Add(this.optDivis);
            this.grbOperaciones.Controls.Add(this.optResta);
            this.grbOperaciones.Controls.Add(this.optMult);
            this.grbOperaciones.Controls.Add(this.optSuma);
            this.grbOperaciones.Location = new System.Drawing.Point(215, 12);
            this.grbOperaciones.Name = "grbOperaciones";
            this.grbOperaciones.Size = new System.Drawing.Size(117, 139);
            this.grbOperaciones.TabIndex = 6;
            this.grbOperaciones.TabStop = false;
            this.grbOperaciones.Text = "Operaciones ";
            // 
            // optSuma
            // 
            this.optSuma.AutoSize = true;
            this.optSuma.Location = new System.Drawing.Point(6, 33);
            this.optSuma.Name = "optSuma";
            this.optSuma.Size = new System.Drawing.Size(52, 17);
            this.optSuma.TabIndex = 0;
            this.optSuma.TabStop = true;
            this.optSuma.Text = "Suma";
            this.optSuma.UseVisualStyleBackColor = true;
            // 
            // optMult
            // 
            this.optMult.AutoSize = true;
            this.optMult.Location = new System.Drawing.Point(6, 77);
            this.optMult.Name = "optMult";
            this.optMult.Size = new System.Drawing.Size(89, 17);
            this.optMult.TabIndex = 1;
            this.optMult.TabStop = true;
            this.optMult.Text = "Multiplicacion";
            this.optMult.UseVisualStyleBackColor = true;
            // 
            // optResta
            // 
            this.optResta.AutoSize = true;
            this.optResta.Location = new System.Drawing.Point(6, 56);
            this.optResta.Name = "optResta";
            this.optResta.Size = new System.Drawing.Size(53, 17);
            this.optResta.TabIndex = 2;
            this.optResta.TabStop = true;
            this.optResta.Text = "Resta";
            this.optResta.UseVisualStyleBackColor = true;
            // 
            // optDivis
            // 
            this.optDivis.AutoSize = true;
            this.optDivis.Location = new System.Drawing.Point(6, 100);
            this.optDivis.Name = "optDivis";
            this.optDivis.Size = new System.Drawing.Size(65, 17);
            this.optDivis.TabIndex = 3;
            this.optDivis.TabStop = true;
            this.optDivis.Text = "Division ";
            this.optDivis.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 217);
            this.Controls.Add(this.grbOperaciones);
            this.Controls.Add(this.lblRespuesta);
            this.Controls.Add(this.lblNum2);
            this.Controls.Add(this.lblNum1);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.btnProcesar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grbOperaciones.ResumeLayout(false);
            this.grbOperaciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.Label lblRespuesta;
        private System.Windows.Forms.GroupBox grbOperaciones;
        private System.Windows.Forms.RadioButton optDivis;
        private System.Windows.Forms.RadioButton optResta;
        private System.Windows.Forms.RadioButton optMult;
        private System.Windows.Forms.RadioButton optSuma;
    }
}

