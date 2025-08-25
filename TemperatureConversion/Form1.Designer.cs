
namespace TemperatureConversion
{
    partial class TempatureForm
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
            this.buttonCTF = new System.Windows.Forms.Button();
            this.labelTempture = new System.Windows.Forms.Label();
            this.textBoxTemp = new System.Windows.Forms.TextBox();
            this.buttonCTC = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCTF
            // 
            this.buttonCTF.BackColor = System.Drawing.Color.Cornsilk;
            this.buttonCTF.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCTF.Location = new System.Drawing.Point(7, 170);
            this.buttonCTF.Name = "buttonCTF";
            this.buttonCTF.Size = new System.Drawing.Size(109, 70);
            this.buttonCTF.TabIndex = 0;
            this.buttonCTF.Text = "Convert To Fahrenheit";
            this.buttonCTF.UseVisualStyleBackColor = false;
            this.buttonCTF.Click += new System.EventHandler(this.buttonCTF_Click);
            // 
            // labelTempture
            // 
            this.labelTempture.AutoSize = true;
            this.labelTempture.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTempture.Location = new System.Drawing.Point(134, 74);
            this.labelTempture.Name = "labelTempture";
            this.labelTempture.Size = new System.Drawing.Size(94, 20);
            this.labelTempture.TabIndex = 2;
            this.labelTempture.Text = "Tempature :";
            // 
            // textBoxTemp
            // 
            this.textBoxTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTemp.Location = new System.Drawing.Point(7, 68);
            this.textBoxTemp.Name = "textBoxTemp";
            this.textBoxTemp.Size = new System.Drawing.Size(104, 29);
            this.textBoxTemp.TabIndex = 3;
            // 
            // buttonCTC
            // 
            this.buttonCTC.BackColor = System.Drawing.Color.OldLace;
            this.buttonCTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCTC.Location = new System.Drawing.Point(122, 170);
            this.buttonCTC.Name = "buttonCTC";
            this.buttonCTC.Size = new System.Drawing.Size(109, 70);
            this.buttonCTC.TabIndex = 4;
            this.buttonCTC.Text = "Convert To Celsius ";
            this.buttonCTC.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.buttonCTC.UseVisualStyleBackColor = false;
            this.buttonCTC.Click += new System.EventHandler(this.buttonCTC_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.PapayaWhip;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(212, 12);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 42);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "Exit";
            this.buttonExit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.PapayaWhip;
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(212, 122);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 42);
            this.buttonClear.TabIndex = 6;
            this.buttonClear.Text = "Clear";
            this.buttonClear.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // TempatureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(299, 250);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonCTC);
            this.Controls.Add(this.textBoxTemp);
            this.Controls.Add(this.labelTempture);
            this.Controls.Add(this.buttonCTF);
            this.Name = "TempatureForm";
            this.Text = "Tempature Convertsion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCTF;
        private System.Windows.Forms.Label labelTempture;
        private System.Windows.Forms.TextBox textBoxTemp;
        private System.Windows.Forms.Button buttonCTC;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonClear;
    }
}

