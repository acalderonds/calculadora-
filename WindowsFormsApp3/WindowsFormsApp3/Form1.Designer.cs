namespace WindowsFormsApp3
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
            this.btnsuma = new System.Windows.Forms.Button();
            this.btnresta = new System.Windows.Forms.Button();
            this.btnmulti = new System.Windows.Forms.Button();
            this.btndivision = new System.Windows.Forms.Button();
            this.lblsuma = new System.Windows.Forms.Label();
            this.lblresta = new System.Windows.Forms.Label();
            this.lblmulti = new System.Windows.Forms.Label();
            this.lbldivision = new System.Windows.Forms.Label();
            this.txtnum1 = new System.Windows.Forms.TextBox();
            this.txtnum2 = new System.Windows.Forms.TextBox();
            this.txtresultado = new System.Windows.Forms.TextBox();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.lblresultado = new System.Windows.Forms.Label();
            this.lbligual = new System.Windows.Forms.Label();
            this.btnpotencia = new System.Windows.Forms.Button();
            this.btnraiz = new System.Windows.Forms.Button();
            this.lblpotencia = new System.Windows.Forms.Label();
            this.lblraiz = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnsuma
            // 
            this.btnsuma.Location = new System.Drawing.Point(183, 106);
            this.btnsuma.Name = "btnsuma";
            this.btnsuma.Size = new System.Drawing.Size(75, 23);
            this.btnsuma.TabIndex = 0;
            this.btnsuma.Text = "+";
            this.btnsuma.UseVisualStyleBackColor = true;
            this.btnsuma.Click += new System.EventHandler(this.buttonsumaClick);
            // 
            // btnresta
            // 
            this.btnresta.Location = new System.Drawing.Point(183, 172);
            this.btnresta.Name = "btnresta";
            this.btnresta.Size = new System.Drawing.Size(75, 23);
            this.btnresta.TabIndex = 1;
            this.btnresta.Text = "-";
            this.btnresta.UseVisualStyleBackColor = true;
            this.btnresta.Click += new System.EventHandler(this.btnresta_Click);
            // 
            // btnmulti
            // 
            this.btnmulti.Location = new System.Drawing.Point(299, 106);
            this.btnmulti.Name = "btnmulti";
            this.btnmulti.Size = new System.Drawing.Size(105, 23);
            this.btnmulti.TabIndex = 2;
            this.btnmulti.Text = "X";
            this.btnmulti.UseVisualStyleBackColor = true;
            this.btnmulti.Click += new System.EventHandler(this.btnmulti_Click);
            // 
            // btndivision
            // 
            this.btndivision.Location = new System.Drawing.Point(317, 172);
            this.btndivision.Name = "btndivision";
            this.btndivision.Size = new System.Drawing.Size(75, 23);
            this.btndivision.TabIndex = 3;
            this.btndivision.Text = "/";
            this.btndivision.UseVisualStyleBackColor = true;
            this.btndivision.Click += new System.EventHandler(this.btndivision_Click);
            // 
            // lblsuma
            // 
            this.lblsuma.AutoSize = true;
            this.lblsuma.Location = new System.Drawing.Point(202, 132);
            this.lblsuma.Name = "lblsuma";
            this.lblsuma.Size = new System.Drawing.Size(38, 13);
            this.lblsuma.TabIndex = 4;
            this.lblsuma.Text = "SUMA";
            // 
            // lblresta
            // 
            this.lblresta.AutoSize = true;
            this.lblresta.Location = new System.Drawing.Point(201, 202);
            this.lblresta.Name = "lblresta";
            this.lblresta.Size = new System.Drawing.Size(43, 13);
            this.lblresta.TabIndex = 5;
            this.lblresta.Text = "RESTA";
            // 
            // lblmulti
            // 
            this.lblmulti.AutoSize = true;
            this.lblmulti.Location = new System.Drawing.Point(296, 132);
            this.lblmulti.Name = "lblmulti";
            this.lblmulti.Size = new System.Drawing.Size(96, 13);
            this.lblmulti.TabIndex = 6;
            this.lblmulti.Text = "MULTIPLICACION";
            // 
            // lbldivision
            // 
            this.lbldivision.AutoSize = true;
            this.lbldivision.Location = new System.Drawing.Point(318, 202);
            this.lbldivision.Name = "lbldivision";
            this.lbldivision.Size = new System.Drawing.Size(54, 13);
            this.lbldivision.TabIndex = 7;
            this.lbldivision.Text = "DIVISION";
            // 
            // txtnum1
            // 
            this.txtnum1.Location = new System.Drawing.Point(183, 42);
            this.txtnum1.Name = "txtnum1";
            this.txtnum1.Size = new System.Drawing.Size(100, 20);
            this.txtnum1.TabIndex = 8;
            this.txtnum1.Text = "5";
            this.txtnum1.TextChanged += new System.EventHandler(this.txtnum1_TextChanged);
            // 
            // txtnum2
            // 
            this.txtnum2.Location = new System.Drawing.Point(335, 42);
            this.txtnum2.Name = "txtnum2";
            this.txtnum2.Size = new System.Drawing.Size(100, 20);
            this.txtnum2.TabIndex = 9;
            this.txtnum2.Text = "5";
            // 
            // txtresultado
            // 
            this.txtresultado.Location = new System.Drawing.Point(535, 42);
            this.txtresultado.Name = "txtresultado";
            this.txtresultado.Size = new System.Drawing.Size(100, 20);
            this.txtresultado.TabIndex = 10;
            this.txtresultado.TextChanged += new System.EventHandler(this.txtresultado_TextChanged);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(535, 141);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpiar.TabIndex = 11;
            this.btnlimpiar.Text = "LIMPIAR";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Location = new System.Drawing.Point(547, 65);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(73, 13);
            this.lblresultado.TabIndex = 12;
            this.lblresultado.Text = "RESULTADO";
            // 
            // lbligual
            // 
            this.lbligual.AutoSize = true;
            this.lbligual.Location = new System.Drawing.Point(470, 42);
            this.lbligual.Name = "lbligual";
            this.lbligual.Size = new System.Drawing.Size(13, 13);
            this.lbligual.TabIndex = 13;
            this.lbligual.Text = "=";
            // 
            // btnpotencia
            // 
            this.btnpotencia.Location = new System.Drawing.Point(173, 240);
            this.btnpotencia.Name = "btnpotencia";
            this.btnpotencia.Size = new System.Drawing.Size(100, 40);
            this.btnpotencia.TabIndex = 14;
            this.btnpotencia.Text = "³ ";
            this.btnpotencia.UseVisualStyleBackColor = true;
            this.btnpotencia.Click += new System.EventHandler(this.btnpotencia_Click);
            // 
            // btnraiz
            // 
            this.btnraiz.Location = new System.Drawing.Point(317, 249);
            this.btnraiz.Name = "btnraiz";
            this.btnraiz.Size = new System.Drawing.Size(75, 23);
            this.btnraiz.TabIndex = 15;
            this.btnraiz.Text = "√ ";
            this.btnraiz.UseVisualStyleBackColor = true;
            this.btnraiz.Click += new System.EventHandler(this.btnraiz_Click);
            // 
            // lblpotencia
            // 
            this.lblpotencia.AutoSize = true;
            this.lblpotencia.Location = new System.Drawing.Point(204, 287);
            this.lblpotencia.Name = "lblpotencia";
            this.lblpotencia.Size = new System.Drawing.Size(61, 13);
            this.lblpotencia.TabIndex = 16;
            this.lblpotencia.Text = "POTENCIA";
            // 
            // lblraiz
            // 
            this.lblraiz.AutoSize = true;
            this.lblraiz.Location = new System.Drawing.Point(335, 286);
            this.lblraiz.Name = "lblraiz";
            this.lblraiz.Size = new System.Drawing.Size(32, 13);
            this.lblraiz.TabIndex = 17;
            this.lblraiz.Text = "RAIZ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblraiz);
            this.Controls.Add(this.lblpotencia);
            this.Controls.Add(this.btnraiz);
            this.Controls.Add(this.btnpotencia);
            this.Controls.Add(this.lbligual);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.txtresultado);
            this.Controls.Add(this.txtnum2);
            this.Controls.Add(this.txtnum1);
            this.Controls.Add(this.lbldivision);
            this.Controls.Add(this.lblmulti);
            this.Controls.Add(this.lblresta);
            this.Controls.Add(this.lblsuma);
            this.Controls.Add(this.btndivision);
            this.Controls.Add(this.btnmulti);
            this.Controls.Add(this.btnresta);
            this.Controls.Add(this.btnsuma);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsuma;
        private System.Windows.Forms.Button btnresta;
        private System.Windows.Forms.Button btnmulti;
        private System.Windows.Forms.Button btndivision;
        private System.Windows.Forms.Label lblsuma;
        private System.Windows.Forms.Label lblresta;
        private System.Windows.Forms.Label lblmulti;
        private System.Windows.Forms.Label lbldivision;
        private System.Windows.Forms.TextBox txtnum1;
        private System.Windows.Forms.TextBox txtnum2;
        private System.Windows.Forms.TextBox txtresultado;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.Label lbligual;
        private System.Windows.Forms.Button btnpotencia;
        private System.Windows.Forms.Button btnraiz;
        private System.Windows.Forms.Label lblpotencia;
        private System.Windows.Forms.Label lblraiz;
    }
}

