
namespace Parcial2
{
    partial class Parqueo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPlacas = new System.Windows.Forms.TextBox();
            this.txtFH = new System.Windows.Forms.TextBox();
            this.btnFH = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.rtxRegistrar = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnGuardarda = new System.Windows.Forms.Button();
            this.btnleerda = new System.Windows.Forms.Button();
            this.btnVac = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(141, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(454, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sistema de estacionamiento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Placas:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha y hora de entrada:";
            // 
            // txtPlacas
            // 
            this.txtPlacas.Location = new System.Drawing.Point(100, 90);
            this.txtPlacas.Name = "txtPlacas";
            this.txtPlacas.Size = new System.Drawing.Size(100, 20);
            this.txtPlacas.TabIndex = 3;
            this.txtPlacas.TextChanged += new System.EventHandler(this.txtPlacas_TextChanged);
            // 
            // txtFH
            // 
            this.txtFH.Location = new System.Drawing.Point(173, 121);
            this.txtFH.Name = "txtFH";
            this.txtFH.Size = new System.Drawing.Size(143, 20);
            this.txtFH.TabIndex = 4;
            // 
            // btnFH
            // 
            this.btnFH.Location = new System.Drawing.Point(45, 163);
            this.btnFH.Name = "btnFH";
            this.btnFH.Size = new System.Drawing.Size(155, 23);
            this.btnFH.TabIndex = 5;
            this.btnFH.Text = "Introducir fecha y hora actual";
            this.btnFH.UseVisualStyleBackColor = true;
            this.btnFH.Click += new System.EventHandler(this.btnFH_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(224, 163);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpiar.TabIndex = 6;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // rtxRegistrar
            // 
            this.rtxRegistrar.Location = new System.Drawing.Point(45, 257);
            this.rtxRegistrar.Name = "rtxRegistrar";
            this.rtxRegistrar.Size = new System.Drawing.Size(291, 155);
            this.rtxRegistrar.TabIndex = 7;
            this.rtxRegistrar.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(450, 257);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(299, 165);
            this.richTextBox2.TabIndex = 8;
            this.richTextBox2.Text = "";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(120, 228);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(113, 23);
            this.btnRegistrar.TabIndex = 9;
            this.btnRegistrar.Text = "Registrar datos";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnGuardarda
            // 
            this.btnGuardarda.Location = new System.Drawing.Point(450, 228);
            this.btnGuardarda.Name = "btnGuardarda";
            this.btnGuardarda.Size = new System.Drawing.Size(118, 23);
            this.btnGuardarda.TabIndex = 10;
            this.btnGuardarda.Text = "Guardar en datos txt";
            this.btnGuardarda.UseVisualStyleBackColor = true;
            this.btnGuardarda.Click += new System.EventHandler(this.btnGuardarda_Click);
            // 
            // btnleerda
            // 
            this.btnleerda.Location = new System.Drawing.Point(584, 228);
            this.btnleerda.Name = "btnleerda";
            this.btnleerda.Size = new System.Drawing.Size(75, 23);
            this.btnleerda.TabIndex = 11;
            this.btnleerda.Text = "Leer datos txt";
            this.btnleerda.UseVisualStyleBackColor = true;
            this.btnleerda.Click += new System.EventHandler(this.btnleerda_Click);
            // 
            // btnVac
            // 
            this.btnVac.Location = new System.Drawing.Point(674, 228);
            this.btnVac.Name = "btnVac";
            this.btnVac.Size = new System.Drawing.Size(75, 23);
            this.btnVac.TabIndex = 12;
            this.btnVac.Text = "Vaciar";
            this.btnVac.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Parqueo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVac);
            this.Controls.Add(this.btnleerda);
            this.Controls.Add(this.btnGuardarda);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.rtxRegistrar);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btnFH);
            this.Controls.Add(this.txtFH);
            this.Controls.Add(this.txtPlacas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Parqueo";
            this.Text = "Parqueadero";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPlacas;
        private System.Windows.Forms.TextBox txtFH;
        private System.Windows.Forms.Button btnFH;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.RichTextBox rtxRegistrar;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnGuardarda;
        private System.Windows.Forms.Button btnleerda;
        private System.Windows.Forms.Button btnVac;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

