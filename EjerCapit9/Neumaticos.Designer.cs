namespace EjerCapit9
{
    partial class Neumaticos
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
            this.richTextBoxDatos = new System.Windows.Forms.RichTextBox();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.buttonMostrar = new System.Windows.Forms.Button();
            this.textBoxNeumaticos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBoxDatos
            // 
            this.richTextBoxDatos.Location = new System.Drawing.Point(34, 139);
            this.richTextBoxDatos.Name = "richTextBoxDatos";
            this.richTextBoxDatos.Size = new System.Drawing.Size(517, 96);
            this.richTextBoxDatos.TabIndex = 0;
            this.richTextBoxDatos.Text = "";
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Location = new System.Drawing.Point(452, 24);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(99, 30);
            this.buttonAgregar.TabIndex = 1;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            // 
            // buttonMostrar
            // 
            this.buttonMostrar.Location = new System.Drawing.Point(452, 89);
            this.buttonMostrar.Name = "buttonMostrar";
            this.buttonMostrar.Size = new System.Drawing.Size(99, 30);
            this.buttonMostrar.TabIndex = 2;
            this.buttonMostrar.Text = "Mostrar";
            this.buttonMostrar.UseVisualStyleBackColor = true;
            // 
            // textBoxNeumaticos
            // 
            this.textBoxNeumaticos.Location = new System.Drawing.Point(291, 34);
            this.textBoxNeumaticos.Name = "textBoxNeumaticos";
            this.textBoxNeumaticos.Size = new System.Drawing.Size(160, 20);
            this.textBoxNeumaticos.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ingrese tipos de neumaticos";
            // 
            // Neumaticos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 262);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNeumaticos);
            this.Controls.Add(this.buttonMostrar);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.richTextBoxDatos);
            this.Name = "Neumaticos";
            this.Text = "Neumaticos";
            this.Load += new System.EventHandler(this.Neumaticos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxDatos;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Button buttonMostrar;
        private System.Windows.Forms.TextBox textBoxNeumaticos;
        private System.Windows.Forms.Label label1;
    }
}