namespace Roots_Calculator
{
    partial class FormMain
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.lbTitle = new System.Windows.Forms.Label();
            this.tbNum = new System.Windows.Forms.TextBox();
            this.tbRoot = new System.Windows.Forms.TextBox();
            this.lbNum = new System.Windows.Forms.Label();
            this.lbRoot = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnSqrt = new System.Windows.Forms.Button();
            this.btnCbrt = new System.Windows.Forms.Button();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.rtbInfo = new System.Windows.Forms.RichTextBox();
            this.lbInfo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(130, 20);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(440, 56);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Roots Calculator";
            // 
            // tbNum
            // 
            this.tbNum.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbNum.Location = new System.Drawing.Point(98, 108);
            this.tbNum.Name = "tbNum";
            this.tbNum.Size = new System.Drawing.Size(100, 32);
            this.tbNum.TabIndex = 1;
            // 
            // tbRoot
            // 
            this.tbRoot.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbRoot.Location = new System.Drawing.Point(98, 148);
            this.tbRoot.Name = "tbRoot";
            this.tbRoot.Size = new System.Drawing.Size(100, 32);
            this.tbRoot.TabIndex = 2;
            // 
            // lbNum
            // 
            this.lbNum.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbNum.Location = new System.Drawing.Point(32, 109);
            this.lbNum.Name = "lbNum";
            this.lbNum.Size = new System.Drawing.Size(60, 32);
            this.lbNum.TabIndex = 3;
            this.lbNum.Text = "x =";
            // 
            // lbRoot
            // 
            this.lbRoot.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbRoot.Location = new System.Drawing.Point(32, 147);
            this.lbRoot.Name = "lbRoot";
            this.lbRoot.Size = new System.Drawing.Size(60, 32);
            this.lbRoot.TabIndex = 4;
            this.lbRoot.Text = "n = ";
            // 
            // btnCalc
            // 
            this.btnCalc.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCalc.Location = new System.Drawing.Point(240, 108);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(150, 33);
            this.btnCalc.TabIndex = 6;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnSqrt
            // 
            this.btnSqrt.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSqrt.Location = new System.Drawing.Point(405, 108);
            this.btnSqrt.Name = "btnSqrt";
            this.btnSqrt.Size = new System.Drawing.Size(150, 33);
            this.btnSqrt.TabIndex = 12;
            this.btnSqrt.Text = "Square root of x";
            this.btnSqrt.UseVisualStyleBackColor = true;
            this.btnSqrt.Click += new System.EventHandler(this.btnSqrt_Click);
            // 
            // btnCbrt
            // 
            this.btnCbrt.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCbrt.Location = new System.Drawing.Point(405, 146);
            this.btnCbrt.Name = "btnCbrt";
            this.btnCbrt.Size = new System.Drawing.Size(150, 33);
            this.btnCbrt.TabIndex = 13;
            this.btnCbrt.Text = "Cube root";
            this.btnCbrt.UseVisualStyleBackColor = true;
            this.btnCbrt.Click += new System.EventHandler(this.btnCbrt_Click);
            // 
            // tbResult
            // 
            this.tbResult.Font = new System.Drawing.Font("Consolas", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbResult.Location = new System.Drawing.Point(166, 208);
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(389, 48);
            this.tbResult.TabIndex = 14;
            // 
            // lblResult
            // 
            this.lblResult.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblResult.Location = new System.Drawing.Point(32, 217);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(128, 32);
            this.lblResult.TabIndex = 15;
            this.lblResult.Text = "Result:";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnClear.Location = new System.Drawing.Point(240, 146);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(150, 33);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // rtbInfo
            // 
            this.rtbInfo.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rtbInfo.Location = new System.Drawing.Point(119, 294);
            this.rtbInfo.Name = "rtbInfo";
            this.rtbInfo.Size = new System.Drawing.Size(436, 96);
            this.rtbInfo.TabIndex = 17;
            this.rtbInfo.Text = "";
            // 
            // lbInfo
            // 
            this.lbInfo.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbInfo.Location = new System.Drawing.Point(32, 330);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(81, 32);
            this.lbInfo.TabIndex = 18;
            this.lbInfo.Text = "Info:";
            this.lbInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(372, 520);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 32);
            this.label1.TabIndex = 20;
            this.label1.Text = "Author: David Poslušný";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 520);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 32);
            this.label2.TabIndex = 21;
            this.label2.Text = "v1.0";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbInfo);
            this.Controls.Add(this.rtbInfo);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.btnCbrt);
            this.Controls.Add(this.btnSqrt);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.lbRoot);
            this.Controls.Add(this.lbNum);
            this.Controls.Add(this.tbRoot);
            this.Controls.Add(this.tbNum);
            this.Controls.Add(this.lbTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Roots Calculator";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.TextBox tbNum;
        private System.Windows.Forms.TextBox tbRoot;
        private System.Windows.Forms.Label lbNum;
        private System.Windows.Forms.Label lbRoot;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnSqrt;
        private System.Windows.Forms.Button btnCbrt;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.RichTextBox rtbInfo;
        private System.Windows.Forms.Label lbInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

