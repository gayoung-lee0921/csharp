namespace Variable
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnInt = new System.Windows.Forms.Button();
            this.btnDouble = new System.Windows.Forms.Button();
            this.btnString = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.textinput1 = new System.Windows.Forms.TextBox();
            this.textinput2 = new System.Windows.Forms.TextBox();
            this.btnDivide = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInt
            // 
            this.btnInt.Location = new System.Drawing.Point(102, 124);
            this.btnInt.Name = "btnInt";
            this.btnInt.Size = new System.Drawing.Size(75, 23);
            this.btnInt.TabIndex = 0;
            this.btnInt.Text = "더하기";
            this.btnInt.UseVisualStyleBackColor = true;
            this.btnInt.Click += new System.EventHandler(this.btnInt_Click);
            // 
            // btnDouble
            // 
            this.btnDouble.Location = new System.Drawing.Point(205, 124);
            this.btnDouble.Name = "btnDouble";
            this.btnDouble.Size = new System.Drawing.Size(75, 23);
            this.btnDouble.TabIndex = 1;
            this.btnDouble.Text = "빼기";
            this.btnDouble.UseVisualStyleBackColor = true;
            this.btnDouble.Click += new System.EventHandler(this.btnDouble_Click);
            // 
            // btnString
            // 
            this.btnString.Location = new System.Drawing.Point(308, 124);
            this.btnString.Name = "btnString";
            this.btnString.Size = new System.Drawing.Size(75, 23);
            this.btnString.TabIndex = 2;
            this.btnString.Text = "곱하기";
            this.btnString.UseVisualStyleBackColor = true;
            this.btnString.Click += new System.EventHandler(this.btnString_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("굴림", 26F);
            this.lblResult.Location = new System.Drawing.Point(185, 192);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(85, 35);
            this.lblResult.TabIndex = 3;
            this.lblResult.Text = "결과";
            // 
            // textinput1
            // 
            this.textinput1.Location = new System.Drawing.Point(102, 58);
            this.textinput1.Name = "textinput1";
            this.textinput1.Size = new System.Drawing.Size(150, 21);
            this.textinput1.TabIndex = 5;
            // 
            // textinput2
            // 
            this.textinput2.Location = new System.Drawing.Point(275, 58);
            this.textinput2.Name = "textinput2";
            this.textinput2.Size = new System.Drawing.Size(156, 21);
            this.textinput2.TabIndex = 6;
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(436, 123);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(75, 23);
            this.btnDivide.TabIndex = 7;
            this.btnDivide.Text = "나누기";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 597);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.textinput2);
            this.Controls.Add(this.textinput1);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnString);
            this.Controls.Add(this.btnDouble);
            this.Controls.Add(this.btnInt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInt;
        private System.Windows.Forms.Button btnDouble;
        private System.Windows.Forms.Button btnString;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox textinput1;
        private System.Windows.Forms.TextBox textinput2;
        private System.Windows.Forms.Button btnDivide;
    }
}

