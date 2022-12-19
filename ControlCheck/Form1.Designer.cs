
namespace ControlCheck
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.chkCheck1 = new System.Windows.Forms.CheckBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblNumeric = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rboRadio1 = new System.Windows.Forms.RadioButton();
            this.rboRadio2 = new System.Windows.Forms.RadioButton();
            this.rboRadio3 = new System.Windows.Forms.RadioButton();
            this.rboRadio4 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkCheck1
            // 
            this.chkCheck1.AutoSize = true;
            this.chkCheck1.Checked = true;
            this.chkCheck1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCheck1.Location = new System.Drawing.Point(48, 34);
            this.chkCheck1.Name = "chkCheck1";
            this.chkCheck1.Size = new System.Drawing.Size(89, 16);
            this.chkCheck1.TabIndex = 0;
            this.chkCheck1.Text = "チェックボックス";
            this.chkCheck1.UseVisualStyleBackColor = true;
            this.chkCheck1.CheckedChanged += new System.EventHandler(this.chkCheck1_CheckedChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(48, 303);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 19);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown1.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(284, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(284, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "label3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(284, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 12);
            this.label6.TabIndex = 3;
            this.label6.Text = "label6";
            // 
            // lblNumeric
            // 
            this.lblNumeric.AutoSize = true;
            this.lblNumeric.Location = new System.Drawing.Point(46, 288);
            this.lblNumeric.Name = "lblNumeric";
            this.lblNumeric.Size = new System.Drawing.Size(114, 12);
            this.lblNumeric.TabIndex = 3;
            this.lblNumeric.Text = "ニューメリックアップダウン";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rboRadio2);
            this.groupBox1.Controls.Add(this.rboRadio1);
            this.groupBox1.Location = new System.Drawing.Point(35, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(199, 93);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rboRadio4);
            this.groupBox2.Controls.Add(this.rboRadio3);
            this.groupBox2.Location = new System.Drawing.Point(35, 170);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(199, 93);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(284, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(284, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "label5";
            // 
            // rboRadio1
            // 
            this.rboRadio1.AutoSize = true;
            this.rboRadio1.Location = new System.Drawing.Point(13, 22);
            this.rboRadio1.Name = "rboRadio1";
            this.rboRadio1.Size = new System.Drawing.Size(85, 16);
            this.rboRadio1.TabIndex = 0;
            this.rboRadio1.Text = "ラジオボタン１";
            this.rboRadio1.UseVisualStyleBackColor = true;
            this.rboRadio1.CheckedChanged += new System.EventHandler(this.rboRadio1_CheckedChanged);
            // 
            // rboRadio2
            // 
            this.rboRadio2.AutoSize = true;
            this.rboRadio2.Checked = true;
            this.rboRadio2.Location = new System.Drawing.Point(13, 67);
            this.rboRadio2.Name = "rboRadio2";
            this.rboRadio2.Size = new System.Drawing.Size(85, 16);
            this.rboRadio2.TabIndex = 0;
            this.rboRadio2.TabStop = true;
            this.rboRadio2.Text = "ラジオボタン２";
            this.rboRadio2.UseVisualStyleBackColor = true;
            // 
            // rboRadio3
            // 
            this.rboRadio3.AutoSize = true;
            this.rboRadio3.Checked = true;
            this.rboRadio3.Location = new System.Drawing.Point(13, 19);
            this.rboRadio3.Name = "rboRadio3";
            this.rboRadio3.Size = new System.Drawing.Size(85, 16);
            this.rboRadio3.TabIndex = 0;
            this.rboRadio3.TabStop = true;
            this.rboRadio3.Text = "ラジオボタン３";
            this.rboRadio3.UseVisualStyleBackColor = true;
            this.rboRadio3.CheckedChanged += new System.EventHandler(this.rboRadio3_CheckedChanged_1);
            // 
            // rboRadio4
            // 
            this.rboRadio4.AutoSize = true;
            this.rboRadio4.Location = new System.Drawing.Point(13, 64);
            this.rboRadio4.Name = "rboRadio4";
            this.rboRadio4.Size = new System.Drawing.Size(85, 16);
            this.rboRadio4.TabIndex = 0;
            this.rboRadio4.Text = "ラジオボタン４";
            this.rboRadio4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 448);
            this.Controls.Add(this.lblNumeric);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.chkCheck1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "コントロールの状態";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkCheck1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblNumeric;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rboRadio2;
        private System.Windows.Forms.RadioButton rboRadio1;
        private System.Windows.Forms.RadioButton rboRadio4;
        private System.Windows.Forms.RadioButton rboRadio3;
    }
}

