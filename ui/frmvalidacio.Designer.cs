namespace appPlanillas_4tose.ui
{
    partial class frmvalidacio
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
            this.txtboxletras = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtboxnumeros = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtboxletras
            // 
            this.txtboxletras.Location = new System.Drawing.Point(397, 158);
            this.txtboxletras.Name = "txtboxletras";
            this.txtboxletras.Size = new System.Drawing.Size(193, 26);
            this.txtboxletras.TabIndex = 0;
            this.txtboxletras.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtboxletras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxletras_KeyPress);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // txtboxnumeros
            // 
            this.txtboxnumeros.Location = new System.Drawing.Point(397, 100);
            this.txtboxnumeros.Name = "txtboxnumeros";
            this.txtboxnumeros.Size = new System.Drawing.Size(193, 26);
            this.txtboxnumeros.TabIndex = 2;
            this.txtboxnumeros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxnumeros_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(279, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "solo numeros :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(302, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "solo letras :";
            // 
            // frmvalidacio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtboxnumeros);
            this.Controls.Add(this.txtboxletras);
            this.Name = "frmvalidacio";
            this.Text = "frmvalidacio";
            this.Load += new System.EventHandler(this.frmvalidacio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtboxletras;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtboxnumeros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}