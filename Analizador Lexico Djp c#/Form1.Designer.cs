namespace Analizador_Lexico_Djp
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
            this.TOKEN_LEXEMA = new System.Windows.Forms.DataGridView();
            this.textBox_codigo = new System.Windows.Forms.TextBox();
            this.Analisis = new System.Windows.Forms.Button();
            this.salir = new System.Windows.Forms.Button();
            this.limpiar = new System.Windows.Forms.Button();
            this.Token = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lexema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TOKEN_LEXEMA)).BeginInit();
            this.SuspendLayout();
            // 
            // TOKEN_LEXEMA
            // 
            this.TOKEN_LEXEMA.AllowUserToOrderColumns = true;
            this.TOKEN_LEXEMA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TOKEN_LEXEMA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Token,
            this.Lexema});
            this.TOKEN_LEXEMA.Location = new System.Drawing.Point(434, 77);
            this.TOKEN_LEXEMA.Name = "TOKEN_LEXEMA";
            this.TOKEN_LEXEMA.Size = new System.Drawing.Size(319, 269);
            this.TOKEN_LEXEMA.TabIndex = 0;
            this.TOKEN_LEXEMA.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBox_codigo
            // 
            this.textBox_codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_codigo.Location = new System.Drawing.Point(12, 77);
            this.textBox_codigo.Multiline = true;
            this.textBox_codigo.Name = "textBox_codigo";
            this.textBox_codigo.Size = new System.Drawing.Size(362, 269);
            this.textBox_codigo.TabIndex = 2;
            // 
            // Analisis
            // 
            this.Analisis.Location = new System.Drawing.Point(57, 376);
            this.Analisis.Name = "Analisis";
            this.Analisis.Size = new System.Drawing.Size(118, 23);
            this.Analisis.TabIndex = 3;
            this.Analisis.Text = "Analisis Lexico";
            this.Analisis.UseVisualStyleBackColor = true;
            this.Analisis.Click += new System.EventHandler(this.analisis_Click);
            // 
            // salir
            // 
            this.salir.Location = new System.Drawing.Point(367, 376);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(75, 23);
            this.salir.TabIndex = 4;
            this.salir.Text = "Salir";
            this.salir.UseVisualStyleBackColor = true;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // limpiar
            // 
            this.limpiar.Location = new System.Drawing.Point(612, 376);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(118, 23);
            this.limpiar.TabIndex = 5;
            this.limpiar.Text = "Limpiar Tabla";
            this.limpiar.UseVisualStyleBackColor = true;
            this.limpiar.Click += new System.EventHandler(this.limpiar_Click);
            // 
            // Token
            // 
            this.Token.HeaderText = "Token";
            this.Token.Name = "Token";
            // 
            // Lexema
            // 
            this.Lexema.HeaderText = "Lexema";
            this.Lexema.Name = "Lexema";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Codigo a Analizar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(255, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(287, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Deyvi Jose Pascual 2-14-0555";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 423);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.limpiar);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.Analisis);
            this.Controls.Add(this.textBox_codigo);
            this.Controls.Add(this.TOKEN_LEXEMA);
            this.Name = "Form1";
            this.Text = "Analisis Lexico DeyviJP";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TOKEN_LEXEMA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TOKEN_LEXEMA;
        private System.Windows.Forms.TextBox textBox_codigo;
        private System.Windows.Forms.Button Analisis;
        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.Button limpiar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Token;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lexema;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

