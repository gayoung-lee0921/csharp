namespace 기본컨트롤
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
            this.btnEvent = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.chkTang = new System.Windows.Forms.CheckBox();
            this.chkBok = new System.Windows.Forms.CheckBox();
            this.chkFri = new System.Windows.Forms.CheckBox();
            this.btnOrder = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioAgree = new System.Windows.Forms.RadioButton();
            this.radioDisagree = new System.Windows.Forms.RadioButton();
            this.btnEnter = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtReq = new System.Windows.Forms.TextBox();
            this.btnReq = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbPay = new System.Windows.Forms.ComboBox();
            this.lbArea = new System.Windows.Forms.ListBox();
            this.btnPay = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEvent
            // 
            this.btnEvent.BackColor = System.Drawing.Color.PaleGreen;
            this.btnEvent.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnEvent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEvent.Location = new System.Drawing.Point(37, 33);
            this.btnEvent.Name = "btnEvent";
            this.btnEvent.Size = new System.Drawing.Size(142, 50);
            this.btnEvent.TabIndex = 0;
            this.btnEvent.Text = "버튼";
            this.btnEvent.UseVisualStyleBackColor = false;
            this.btnEvent.Click += new System.EventHandler(this.btnEvent_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("궁서체", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(279, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "주문하시겠습니까?";
            // 
            // chkTang
            // 
            this.chkTang.AutoSize = true;
            this.chkTang.Location = new System.Drawing.Point(202, 61);
            this.chkTang.Name = "chkTang";
            this.chkTang.Size = new System.Drawing.Size(60, 16);
            this.chkTang.TabIndex = 2;
            this.chkTang.Text = "마라탕";
            this.chkTang.UseVisualStyleBackColor = true;
            // 
            // chkBok
            // 
            this.chkBok.AutoSize = true;
            this.chkBok.Location = new System.Drawing.Point(356, 61);
            this.chkBok.Name = "chkBok";
            this.chkBok.Size = new System.Drawing.Size(72, 16);
            this.chkBok.TabIndex = 3;
            this.chkBok.Text = "마라샹궈";
            this.chkBok.UseVisualStyleBackColor = true;
            // 
            // chkFri
            // 
            this.chkFri.AutoSize = true;
            this.chkFri.Location = new System.Drawing.Point(514, 60);
            this.chkFri.Name = "chkFri";
            this.chkFri.Size = new System.Drawing.Size(72, 16);
            this.chkFri.TabIndex = 4;
            this.chkFri.Text = "꿔바로우";
            this.chkFri.UseVisualStyleBackColor = true;
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.Red;
            this.btnOrder.Font = new System.Drawing.Font("궁서체", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnOrder.ForeColor = System.Drawing.Color.White;
            this.btnOrder.Location = new System.Drawing.Point(202, 104);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(384, 40);
            this.btnOrder.TabIndex = 5;
            this.btnOrder.Text = "주문하기";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblResult.Location = new System.Drawing.Point(338, 191);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(106, 24);
            this.lblResult.TabIndex = 6;
            this.lblResult.Text = "주문결과";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(199, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(336, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "이벤트 참여 시 개인정보 동의를 허용해주세요";
            // 
            // radioAgree
            // 
            this.radioAgree.AutoSize = true;
            this.radioAgree.Location = new System.Drawing.Point(40, 35);
            this.radioAgree.Name = "radioAgree";
            this.radioAgree.Size = new System.Drawing.Size(83, 16);
            this.radioAgree.TabIndex = 8;
            this.radioAgree.TabStop = true;
            this.radioAgree.Text = "동의합니다";
            this.radioAgree.UseVisualStyleBackColor = true;
            // 
            // radioDisagree
            // 
            this.radioDisagree.AutoSize = true;
            this.radioDisagree.Location = new System.Drawing.Point(233, 35);
            this.radioDisagree.Name = "radioDisagree";
            this.radioDisagree.Size = new System.Drawing.Size(123, 16);
            this.radioDisagree.TabIndex = 9;
            this.radioDisagree.TabStop = true;
            this.radioDisagree.Text = "동의하지 않습니다";
            this.radioDisagree.UseVisualStyleBackColor = true;
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnEnter.Font = new System.Drawing.Font("궁서", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnEnter.ForeColor = System.Drawing.Color.White;
            this.btnEnter.Location = new System.Drawing.Point(202, 358);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(384, 51);
            this.btnEnter.TabIndex = 10;
            this.btnEnter.Text = "이벤트 응모하기";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioAgree);
            this.groupBox1.Controls.Add(this.radioDisagree);
            this.groupBox1.Location = new System.Drawing.Point(202, 259);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 74);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "개인정보동의";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(199, 427);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "주문 시 요구사항";
            // 
            // txtReq
            // 
            this.txtReq.Location = new System.Drawing.Point(203, 464);
            this.txtReq.Multiline = true;
            this.txtReq.Name = "txtReq";
            this.txtReq.Size = new System.Drawing.Size(299, 88);
            this.txtReq.TabIndex = 13;
            // 
            // btnReq
            // 
            this.btnReq.BackColor = System.Drawing.Color.Gold;
            this.btnReq.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnReq.ForeColor = System.Drawing.Color.White;
            this.btnReq.Location = new System.Drawing.Point(515, 464);
            this.btnReq.Name = "btnReq";
            this.btnReq.Size = new System.Drawing.Size(75, 88);
            this.btnReq.TabIndex = 14;
            this.btnReq.Text = "접수";
            this.btnReq.UseVisualStyleBackColor = false;
            this.btnReq.Click += new System.EventHandler(this.btnReq_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(200, 584);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "결제방법";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(373, 584);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "결제정보";
            // 
            // cbPay
            // 
            this.cbPay.FormattingEnabled = true;
            this.cbPay.Items.AddRange(new object[] {
            "신용카드",
            "무통장입금",
            "포인트 결제",
            "삼성페이",
            "네이버페이",
            "비트코인 결제"});
            this.cbPay.Location = new System.Drawing.Point(207, 617);
            this.cbPay.Name = "cbPay";
            this.cbPay.Size = new System.Drawing.Size(121, 20);
            this.cbPay.TabIndex = 17;
            this.cbPay.Text = "신용카드";
            this.cbPay.SelectedIndexChanged += new System.EventHandler(this.cbPay_SelectedIndexChanged);
            // 
            // lbArea
            // 
            this.lbArea.FormattingEnabled = true;
            this.lbArea.ItemHeight = 12;
            this.lbArea.Items.AddRange(new object[] {
            "일시불",
            "3개월 할부",
            "6개월 할부"});
            this.lbArea.Location = new System.Drawing.Point(376, 617);
            this.lbArea.Name = "lbArea";
            this.lbArea.Size = new System.Drawing.Size(120, 88);
            this.lbArea.TabIndex = 18;
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.Turquoise;
            this.btnPay.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnPay.ForeColor = System.Drawing.Color.White;
            this.btnPay.Location = new System.Drawing.Point(515, 617);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(75, 88);
            this.btnPay.TabIndex = 19;
            this.btnPay.Text = "결제";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 758);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.lbArea);
            this.Controls.Add(this.cbPay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnReq);
            this.Controls.Add(this.txtReq);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.chkFri);
            this.Controls.Add(this.chkBok);
            this.Controls.Add(this.chkTang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEvent);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEvent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkTang;
        private System.Windows.Forms.CheckBox chkBok;
        private System.Windows.Forms.CheckBox chkFri;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioAgree;
        private System.Windows.Forms.RadioButton radioDisagree;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtReq;
        private System.Windows.Forms.Button btnReq;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbPay;
        private System.Windows.Forms.ListBox lbArea;
        private System.Windows.Forms.Button btnPay;
    }
}

