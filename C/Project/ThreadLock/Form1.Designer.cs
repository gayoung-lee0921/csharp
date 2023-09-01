namespace ThreadLock
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
            this.txtThreadState = new System.Windows.Forms.TextBox();
            this.btnThreadLock = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtThreadState
            // 
            this.txtThreadState.Location = new System.Drawing.Point(13, 13);
            this.txtThreadState.Multiline = true;
            this.txtThreadState.Name = "txtThreadState";
            this.txtThreadState.Size = new System.Drawing.Size(444, 436);
            this.txtThreadState.TabIndex = 0;
            // 
            // btnThreadLock
            // 
            this.btnThreadLock.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnThreadLock.Location = new System.Drawing.Point(12, 454);
            this.btnThreadLock.Name = "btnThreadLock";
            this.btnThreadLock.Size = new System.Drawing.Size(444, 61);
            this.btnThreadLock.TabIndex = 1;
            this.btnThreadLock.Text = "스레드 락";
            this.btnThreadLock.UseVisualStyleBackColor = true;
            this.btnThreadLock.Click += new System.EventHandler(this.btnThreadLock_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 527);
            this.Controls.Add(this.btnThreadLock);
            this.Controls.Add(this.txtThreadState);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtThreadState;
        private System.Windows.Forms.Button btnThreadLock;
    }
}

