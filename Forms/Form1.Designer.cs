namespace Forms
{
    partial class TXTNOMBRE
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
            this.TEXEDAD = new System.Windows.Forms.GroupBox();
            this.butELIMINAR = new System.Windows.Forms.Button();
            this.butMODIFICAR = new System.Windows.Forms.Button();
            this.butAGREGAR = new System.Windows.Forms.Button();
            this.NIVEL = new System.Windows.Forms.TextBox();
            this.textNOMBRE = new System.Windows.Forms.TextBox();
            this.textEDAD = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.TEXEDAD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TEXEDAD
            // 
            this.TEXEDAD.Controls.Add(this.butELIMINAR);
            this.TEXEDAD.Controls.Add(this.butMODIFICAR);
            this.TEXEDAD.Controls.Add(this.butAGREGAR);
            this.TEXEDAD.Controls.Add(this.NIVEL);
            this.TEXEDAD.Controls.Add(this.textNOMBRE);
            this.TEXEDAD.Controls.Add(this.textEDAD);
            this.TEXEDAD.Controls.Add(this.label5);
            this.TEXEDAD.Controls.Add(this.label4);
            this.TEXEDAD.Controls.Add(this.label3);
            this.TEXEDAD.Controls.Add(this.label1);
            this.TEXEDAD.Location = new System.Drawing.Point(3, 12);
            this.TEXEDAD.Name = "TEXEDAD";
            this.TEXEDAD.Size = new System.Drawing.Size(236, 321);
            this.TEXEDAD.TabIndex = 0;
            this.TEXEDAD.TabStop = false;
            this.TEXEDAD.Text = "GESTION DE JUGADORES E INVENTARIO";
            // 
            // butELIMINAR
            // 
            this.butELIMINAR.Location = new System.Drawing.Point(97, 213);
            this.butELIMINAR.Name = "butELIMINAR";
            this.butELIMINAR.Size = new System.Drawing.Size(85, 29);
            this.butELIMINAR.TabIndex = 9;
            this.butELIMINAR.Text = "ELIMINAR";
            this.butELIMINAR.UseVisualStyleBackColor = true;
            // 
            // butMODIFICAR
            // 
            this.butMODIFICAR.Location = new System.Drawing.Point(0, 213);
            this.butMODIFICAR.Name = "butMODIFICAR";
            this.butMODIFICAR.Size = new System.Drawing.Size(88, 29);
            this.butMODIFICAR.TabIndex = 8;
            this.butMODIFICAR.Text = "MODIFICAR";
            this.butMODIFICAR.UseVisualStyleBackColor = true;
            // 
            // butAGREGAR
            // 
            this.butAGREGAR.Location = new System.Drawing.Point(3, 179);
            this.butAGREGAR.Name = "butAGREGAR";
            this.butAGREGAR.Size = new System.Drawing.Size(197, 22);
            this.butAGREGAR.TabIndex = 7;
            this.butAGREGAR.Text = "AGREGAR";
            this.butAGREGAR.UseVisualStyleBackColor = true;
            // 
            // NIVEL
            // 
            this.NIVEL.Location = new System.Drawing.Point(73, 121);
            this.NIVEL.Name = "NIVEL";
            this.NIVEL.Size = new System.Drawing.Size(121, 20);
            this.NIVEL.TabIndex = 6;
            // 
            // textNOMBRE
            // 
            this.textNOMBRE.Location = new System.Drawing.Point(73, 81);
            this.textNOMBRE.Name = "textNOMBRE";
            this.textNOMBRE.Size = new System.Drawing.Size(121, 20);
            this.textNOMBRE.TabIndex = 5;
            this.textNOMBRE.TextChanged += new System.EventHandler(this.textNOMBRE_TextChanged);
            // 
            // textEDAD
            // 
            this.textEDAD.Location = new System.Drawing.Point(73, 28);
            this.textEDAD.Name = "textEDAD";
            this.textEDAD.Size = new System.Drawing.Size(121, 20);
            this.textEDAD.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "NIVEL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "NOMBRE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "EDAD";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(255, 21);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(304, 312);
            this.dataGridView.TabIndex = 1;
            this.dataGridView.ReadOnlyChanged += new System.EventHandler(this.btnAgregar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(569, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 29);
            this.button1.TabIndex = 10;
            this.button1.Text = "EXPORTAR CSV";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // TXTNOMBRE
            // 
            this.ClientSize = new System.Drawing.Size(691, 403);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.TEXEDAD);
            this.Name = "TXTNOMBRE";
            this.TEXEDAD.ResumeLayout(false);
            this.TEXEDAD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label NOMBRE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.TextBox TXTEDAD;
        private System.Windows.Forms.GroupBox TEXEDAD;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butELIMINAR;
        private System.Windows.Forms.Button butMODIFICAR;
        private System.Windows.Forms.Button butAGREGAR;
        private System.Windows.Forms.TextBox NIVEL;
        private System.Windows.Forms.TextBox textNOMBRE;
        private System.Windows.Forms.TextBox textEDAD;
        private System.Windows.Forms.Button button1;
    }
}

