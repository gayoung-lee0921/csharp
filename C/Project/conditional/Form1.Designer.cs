namespace conditional
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
            this.textKuk = new System.Windows.Forms.TextBox();
            this.textEng = new System.Windows.Forms.TextBox();
            this.textMath = new System.Windows.Forms.TextBox();
            this.btnResult = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textKuk
            // 
            this.textKuk.Location = new System.Drawing.Point(71, 65);
            this.textKuk.Name = "textKuk";
            this.textKuk.Size = new System.Drawing.Size(100, 21);
            this.textKuk.TabIndex = 0;
            // 
            // textEng
            // 
            this.textEng.Location = new System.Drawing.Point(218, 65);
            this.textEng.Name = "textEng";
            this.textEng.Size = new System.Drawing.Size(100, 21);
            this.textEng.TabIndex = 1;
            // 
            // textMath
            // 
            this.textMath.Location = new System.Drawing.Point(375, 65);
            this.textMath.Name = "textMath";
            this.textMath.Size = new System.Drawing.Size(100, 21);
            this.textMath.TabIndex = 2;
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(124, 112);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(321, 23);
            this.btnResult.TabIndex = 3;
            this.btnResult.Text = "결과";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblResult.Font = new System.Drawing.Font("굴림", 20F);
            this.lblResult.Location = new System.Drawing.Point(234, 165);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(120, 27);
            this.lblResult.TabIndex = 4;
            this.lblResult.Text = "결과출력";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.textMath);
            this.Controls.Add(this.textEng);
            this.Controls.Add(this.textKuk);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textKuk;
        private System.Windows.Forms.TextBox textEng;
        private System.Windows.Forms.TextBox textMath;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Label lblResult;
    }
}

