namespace TPA_EstruturasRepeticao
{
    partial class FrmEx1
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
            this.lbldigite = new System.Windows.Forms.Label();
            this.lstresult = new System.Windows.Forms.ListBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnwhile = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btndowhile = new System.Windows.Forms.Button();
            this.btnFor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbldigite
            // 
            this.lbldigite.AutoSize = true;
            this.lbldigite.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldigite.Location = new System.Drawing.Point(235, 51);
            this.lbldigite.Name = "lbldigite";
            this.lbldigite.Size = new System.Drawing.Size(182, 24);
            this.lbldigite.TabIndex = 0;
            this.lbldigite.Text = "Digite um número:";
            // 
            // lstresult
            // 
            this.lstresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstresult.FormattingEnabled = true;
            this.lstresult.ItemHeight = 20;
            this.lstresult.Location = new System.Drawing.Point(239, 156);
            this.lstresult.Name = "lstresult";
            this.lstresult.Size = new System.Drawing.Size(353, 224);
            this.lstresult.TabIndex = 2;
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(434, 48);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(118, 29);
            this.txtNumero.TabIndex = 3;
            // 
            // btnwhile
            // 
            this.btnwhile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnwhile.Location = new System.Drawing.Point(336, 91);
            this.btnwhile.Name = "btnwhile";
            this.btnwhile.Size = new System.Drawing.Size(77, 35);
            this.btnwhile.TabIndex = 4;
            this.btnwhile.Text = "while";
            this.btnwhile.UseVisualStyleBackColor = true;
            this.btnwhile.Click += new System.EventHandler(this.btngerar_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpar.Location = new System.Drawing.Point(336, 386);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(81, 33);
            this.btnlimpar.TabIndex = 5;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(235, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Resultado:";
            // 
            // btnvoltar
            // 
            this.btnvoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvoltar.Location = new System.Drawing.Point(434, 386);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(81, 33);
            this.btnvoltar.TabIndex = 7;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // btndowhile
            // 
            this.btndowhile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndowhile.Location = new System.Drawing.Point(419, 91);
            this.btndowhile.Name = "btndowhile";
            this.btndowhile.Size = new System.Drawing.Size(118, 35);
            this.btndowhile.TabIndex = 8;
            this.btndowhile.Text = "do...while";
            this.btndowhile.UseVisualStyleBackColor = true;
            this.btndowhile.Click += new System.EventHandler(this.btndowhile_Click);
            // 
            // btnFor
            // 
            this.btnFor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFor.Location = new System.Drawing.Point(543, 91);
            this.btnFor.Name = "btnFor";
            this.btnFor.Size = new System.Drawing.Size(88, 35);
            this.btnFor.TabIndex = 9;
            this.btnFor.Text = "for";
            this.btnFor.UseVisualStyleBackColor = true;
            this.btnFor.Click += new System.EventHandler(this.btnFor_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(325, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Escolha um para gerar a tabuada:";
            // 
            // FrmEx1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnFor);
            this.Controls.Add(this.btndowhile);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btnwhile);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lstresult);
            this.Controls.Add(this.lbldigite);
            this.Name = "FrmEx1";
            this.Text = "Exercício1-while";
            this.Load += new System.EventHandler(this.FrmEx1while_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbldigite;
        private System.Windows.Forms.ListBox lstresult;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btnwhile;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btndowhile;
        private System.Windows.Forms.Button btnFor;
        private System.Windows.Forms.Label label2;
    }
}