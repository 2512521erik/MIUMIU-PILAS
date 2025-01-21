namespace MIUMIU1 {
    partial class Form1 {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing) {
            if (disposing&&(components!=null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.btnapilar = new System.Windows.Forms.Button();
            this.btndesapila = new System.Windows.Forms.Button();
            this.btnvistazo = new System.Windows.Forms.Button();
            this.btnelemento = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(283, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "PILA-STACK (LIFO)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "INGRESA NOMBRE";
            // 
            // txtnom
            // 
            this.txtnom.Location = new System.Drawing.Point(187, 97);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(100, 20);
            this.txtnom.TabIndex = 2;
            // 
            // btnapilar
            // 
            this.btnapilar.Location = new System.Drawing.Point(56, 138);
            this.btnapilar.Name = "btnapilar";
            this.btnapilar.Size = new System.Drawing.Size(75, 23);
            this.btnapilar.TabIndex = 3;
            this.btnapilar.Text = "apilar";
            this.btnapilar.UseVisualStyleBackColor = true;
            // 
            // btndesapila
            // 
            this.btndesapila.Location = new System.Drawing.Point(56, 168);
            this.btndesapila.Name = "btndesapila";
            this.btndesapila.Size = new System.Drawing.Size(75, 23);
            this.btndesapila.TabIndex = 4;
            this.btndesapila.Text = "desapilar ";
            this.btndesapila.UseVisualStyleBackColor = true;
            // 
            // btnvistazo
            // 
            this.btnvistazo.Location = new System.Drawing.Point(56, 198);
            this.btnvistazo.Name = "btnvistazo";
            this.btnvistazo.Size = new System.Drawing.Size(75, 23);
            this.btnvistazo.TabIndex = 5;
            this.btnvistazo.Text = "vistazo ";
            this.btnvistazo.UseVisualStyleBackColor = true;
            // 
            // btnelemento
            // 
            this.btnelemento.Location = new System.Drawing.Point(56, 228);
            this.btnelemento.Name = "btnelemento";
            this.btnelemento.Size = new System.Drawing.Size(75, 23);
            this.btnelemento.TabIndex = 6;
            this.btnelemento.Text = "elementos ";
            this.btnelemento.UseVisualStyleBackColor = true;
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(56, 258);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpiar.TabIndex = 7;
            this.btnlimpiar.Text = "limipiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(187, 138);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(139, 147);
            this.listBox1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btnelemento);
            this.Controls.Add(this.btnvistazo);
            this.Controls.Add(this.btndesapila);
            this.Controls.Add(this.btnapilar);
            this.Controls.Add(this.txtnom);
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
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.Button btnapilar;
        private System.Windows.Forms.Button btndesapila;
        private System.Windows.Forms.Button btnvistazo;
        private System.Windows.Forms.Button btnelemento;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.ListBox listBox1;
    }
}

