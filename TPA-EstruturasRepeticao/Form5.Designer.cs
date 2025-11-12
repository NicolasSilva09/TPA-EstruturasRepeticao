namespace TPA_EstruturasRepeticao
{
    partial class FrmEx2
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblconverter = new System.Windows.Forms.Label();
            this.btnconverter = new System.Windows.Forms.Button();
            this.lstresult = new System.Windows.Forms.ListBox();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btnDoWhile = new System.Windows.Forms.Button();
            this.btnFor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(354, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // lblconverter
            // 
            this.lblconverter.AutoSize = true;
            this.lblconverter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblconverter.Location = new System.Drawing.Point(259, 9);
            this.lblconverter.Name = "lblconverter";
            this.lblconverter.Size = new System.Drawing.Size(263, 24);
            this.lblconverter.TabIndex = 1;
            this.lblconverter.Text = "Converter  Cº para fahreenheit";
            // 
            // btnconverter
            // 
            this.btnconverter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconverter.Location = new System.Drawing.Point(127, 49);
            this.btnconverter.Name = "btnconverter";
            this.btnconverter.Size = new System.Drawing.Size(161, 31);
            this.btnconverter.TabIndex = 2;
            this.btnconverter.Text = "Converta com while";
            this.btnconverter.UseVisualStyleBackColor = true;
            this.btnconverter.Click += new System.EventHandler(this.btnconverter_Click);
            // 
            // lstresult
            // 
            this.lstresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstresult.FormattingEnabled = true;
            this.lstresult.ItemHeight = 25;
            this.lstresult.Location = new System.Drawing.Point(202, 86);
            this.lstresult.Name = "lstresult";
            this.lstresult.Size = new System.Drawing.Size(393, 279);
            this.lstresult.TabIndex = 3;
            // 
            // btnlimpar
            // 
            this.btnlimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpar.Location = new System.Drawing.Point(249, 373);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(128, 32);
            this.btnlimpar.TabIndex = 4;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvoltar.Location = new System.Drawing.Point(424, 373);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(128, 28);
            this.btnvoltar.TabIndex = 5;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // btnDoWhile
            // 
            this.btnDoWhile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoWhile.Location = new System.Drawing.Point(294, 49);
            this.btnDoWhile.Name = "btnDoWhile";
            this.btnDoWhile.Size = new System.Drawing.Size(187, 31);
            this.btnDoWhile.TabIndex = 6;
            this.btnDoWhile.Text = "Converta com do...while";
            this.btnDoWhile.UseVisualStyleBackColor = true;
            this.btnDoWhile.Click += new System.EventHandler(this.btnDoWhile_Click);
            // 
            // btnFor
            // 
            this.btnFor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFor.Location = new System.Drawing.Point(496, 49);
            this.btnFor.Name = "btnFor";
            this.btnFor.Size = new System.Drawing.Size(150, 31);
            this.btnFor.TabIndex = 7;
            this.btnFor.Text = "Converta com for";
            this.btnFor.UseVisualStyleBackColor = true;
            this.btnFor.Click += new System.EventHandler(this.btnFor_Click);
            // 
            // FrmEx2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFor);
            this.Controls.Add(this.btnDoWhile);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.lstresult);
            this.Controls.Add(this.btnconverter);
            this.Controls.Add(this.lblconverter);
            this.Controls.Add(this.label1);
            this.Name = "FrmEx2";
            this.Text = "Exercício2-While";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblconverter;
        private System.Windows.Forms.Button btnconverter;
        private System.Windows.Forms.ListBox lstresult;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btnDoWhile;
        private System.Windows.Forms.Button btnFor;
    }
}