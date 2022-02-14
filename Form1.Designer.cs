
namespace calculadora2
{
    partial class bt
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblresultado = new System.Windows.Forms.Label();
            this.txtcantidad1 = new System.Windows.Forms.TextBox();
            this.txtcantidad2 = new System.Windows.Forms.TextBox();
            this.txtresultado = new System.Windows.Forms.TextBox();
            this.btnsumar = new System.Windows.Forms.Button();
            this.btnresta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(55, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "cantidad 1 ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Chartreuse;
            this.label2.Location = new System.Drawing.Point(55, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "cantidad 2";
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblresultado.ForeColor = System.Drawing.Color.Coral;
            this.lblresultado.Location = new System.Drawing.Point(118, 140);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(22, 25);
            this.lblresultado.TabIndex = 2;
            this.lblresultado.Text = "0";
            // 
            // txtcantidad1
            // 
            this.txtcantidad1.Location = new System.Drawing.Point(203, 45);
            this.txtcantidad1.Name = "txtcantidad1";
            this.txtcantidad1.Size = new System.Drawing.Size(100, 23);
            this.txtcantidad1.TabIndex = 3;
            this.txtcantidad1.Text = "5";
            // 
            // txtcantidad2
            // 
            this.txtcantidad2.Location = new System.Drawing.Point(203, 94);
            this.txtcantidad2.Name = "txtcantidad2";
            this.txtcantidad2.Size = new System.Drawing.Size(100, 23);
            this.txtcantidad2.TabIndex = 4;
            this.txtcantidad2.Text = "6";
            // 
            // txtresultado
            // 
            this.txtresultado.Location = new System.Drawing.Point(203, 141);
            this.txtresultado.Name = "txtresultado";
            this.txtresultado.Size = new System.Drawing.Size(100, 23);
            this.txtresultado.TabIndex = 5;
            // 
            // btnsumar
            // 
            this.btnsumar.Location = new System.Drawing.Point(544, 44);
            this.btnsumar.Name = "btnsumar";
            this.btnsumar.Size = new System.Drawing.Size(75, 23);
            this.btnsumar.TabIndex = 6;
            this.btnsumar.Text = "Suma";
            this.btnsumar.UseVisualStyleBackColor = true;
            this.btnsumar.Click += new System.EventHandler(this.btnsumar_Click);
            // 
            // btnresta
            // 
            this.btnresta.Location = new System.Drawing.Point(544, 144);
            this.btnresta.Name = "btnresta";
            this.btnresta.Size = new System.Drawing.Size(75, 23);
            this.btnresta.TabIndex = 7;
            this.btnresta.Text = "Resta";
            this.btnresta.UseVisualStyleBackColor = true;
            // 
            // bt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnresta);
            this.Controls.Add(this.btnsumar);
            this.Controls.Add(this.txtresultado);
            this.Controls.Add(this.txtcantidad2);
            this.Controls.Add(this.txtcantidad1);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Coral;
            this.Name = "bt";
            this.Text = "calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.TextBox txtcantidad1;
        private System.Windows.Forms.TextBox txtcantidad2;
        private System.Windows.Forms.TextBox txtresultado;
        private System.Windows.Forms.Button btnsumar;
        private System.Windows.Forms.Button btnresta;
    }
}

