
namespace Meetlat
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalcLength = new System.Windows.Forms.Button();
            this.lblM = new System.Windows.Forms.Label();
            this.lblCm = new System.Windows.Forms.Label();
            this.lblKm = new System.Windows.Forms.Label();
            this.lblFeet = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter length in meters";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnCalcLength
            // 
            this.btnCalcLength.Location = new System.Drawing.Point(380, 51);
            this.btnCalcLength.Name = "btnCalcLength";
            this.btnCalcLength.Size = new System.Drawing.Size(75, 23);
            this.btnCalcLength.TabIndex = 2;
            this.btnCalcLength.Text = "Calculate";
            this.btnCalcLength.UseVisualStyleBackColor = true;
            this.btnCalcLength.Click += new System.EventHandler(this.btnCalcLength_Click);
            // 
            // lblM
            // 
            this.lblM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblM.Location = new System.Drawing.Point(137, 129);
            this.lblM.Name = "lblM";
            this.lblM.Size = new System.Drawing.Size(62, 23);
            this.lblM.TabIndex = 3;
            this.lblM.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCm
            // 
            this.lblCm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCm.Location = new System.Drawing.Point(199, 129);
            this.lblCm.Name = "lblCm";
            this.lblCm.Size = new System.Drawing.Size(62, 23);
            this.lblCm.TabIndex = 4;
            this.lblCm.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblKm
            // 
            this.lblKm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblKm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKm.Location = new System.Drawing.Point(261, 129);
            this.lblKm.Name = "lblKm";
            this.lblKm.Size = new System.Drawing.Size(62, 23);
            this.lblKm.TabIndex = 5;
            this.lblKm.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblFeet
            // 
            this.lblFeet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFeet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeet.Location = new System.Drawing.Point(323, 129);
            this.lblFeet.Name = "lblFeet";
            this.lblFeet.Size = new System.Drawing.Size(62, 23);
            this.lblFeet.TabIndex = 6;
            this.lblFeet.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(246, 51);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(110, 20);
            this.txtInput.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(137, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "M";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(323, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "FT";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(261, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "KM";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(199, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "CM";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 191);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblFeet);
            this.Controls.Add(this.lblKm);
            this.Controls.Add(this.lblCm);
            this.Controls.Add(this.lblM);
            this.Controls.Add(this.btnCalcLength);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Meetlat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalcLength;
        private System.Windows.Forms.Label lblM;
        private System.Windows.Forms.Label lblCm;
        private System.Windows.Forms.Label lblKm;
        private System.Windows.Forms.Label lblFeet;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

