namespace minipainting
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
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripNew = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripExit = new System.Windows.Forms.ToolStripMenuItem();
            this.도형ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripLine = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripRect = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripCircle = new System.Windows.Forms.ToolStripMenuItem();
            this.색상ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripColor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripComboThick = new System.Windows.Forms.ToolStripComboBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.toolStripBtnLine = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnRect = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnCircle = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnBlack = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnRed = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnGreen = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnBlue = new System.Windows.Forms.ToolStripButton();
            this.menuBar.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuBar
            // 
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.도형ToolStripMenuItem,
            this.색상ToolStripMenuItem});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(800, 24);
            this.menuBar.TabIndex = 0;
            this.menuBar.Text = "menuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripNew,
            this.toolStripSeparator1,
            this.ToolStripExit});
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.파일ToolStripMenuItem.Text = "파일";
            // 
            // ToolStripNew
            // 
            this.ToolStripNew.Name = "ToolStripNew";
            this.ToolStripNew.Size = new System.Drawing.Size(180, 22);
            this.ToolStripNew.Text = "새로만들기";
            this.ToolStripNew.Click += new System.EventHandler(this.ToolStripNew_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(131, 6);
            // 
            // ToolStripExit
            // 
            this.ToolStripExit.Name = "ToolStripExit";
            this.ToolStripExit.Size = new System.Drawing.Size(180, 22);
            this.ToolStripExit.Text = "종료";
            this.ToolStripExit.Click += new System.EventHandler(this.ToolStripExit_Click);
            // 
            // 도형ToolStripMenuItem
            // 
            this.도형ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripLine,
            this.ToolStripRect,
            this.ToolStripCircle});
            this.도형ToolStripMenuItem.Name = "도형ToolStripMenuItem";
            this.도형ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.도형ToolStripMenuItem.Text = "도형";
            // 
            // ToolStripLine
            // 
            this.ToolStripLine.Name = "ToolStripLine";
            this.ToolStripLine.Size = new System.Drawing.Size(180, 22);
            this.ToolStripLine.Text = "직선";
            this.ToolStripLine.Click += new System.EventHandler(this.ToolStripLine_Click);
            // 
            // ToolStripRect
            // 
            this.ToolStripRect.Name = "ToolStripRect";
            this.ToolStripRect.Size = new System.Drawing.Size(180, 22);
            this.ToolStripRect.Text = "사각형";
            this.ToolStripRect.Click += new System.EventHandler(this.ToolStripRect_Click);
            // 
            // ToolStripCircle
            // 
            this.ToolStripCircle.Name = "ToolStripCircle";
            this.ToolStripCircle.Size = new System.Drawing.Size(180, 22);
            this.ToolStripCircle.Text = "원";
            this.ToolStripCircle.Click += new System.EventHandler(this.ToolStripCircle_Click);
            // 
            // 색상ToolStripMenuItem
            // 
            this.색상ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripColor});
            this.색상ToolStripMenuItem.Name = "색상ToolStripMenuItem";
            this.색상ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.색상ToolStripMenuItem.Text = "색상";
            // 
            // ToolStripColor
            // 
            this.ToolStripColor.Name = "ToolStripColor";
            this.ToolStripColor.Size = new System.Drawing.Size(180, 22);
            this.ToolStripColor.Text = "색깔선택";
            this.ToolStripColor.Click += new System.EventHandler(this.ToolStripColor_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnLine,
            this.toolStripBtnRect,
            this.toolStripBtnCircle,
            this.toolStripSeparator2,
            this.toolStripBtnBlack,
            this.toolStripBtnRed,
            this.toolStripBtnGreen,
            this.toolStripBtnBlue,
            this.toolStripSeparator3,
            this.toolStripComboThick});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripComboThick
            // 
            this.toolStripComboThick.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            ""});
            this.toolStripComboThick.Name = "toolStripComboThick";
            this.toolStripComboThick.Size = new System.Drawing.Size(121, 25);
            this.toolStripComboThick.Text = "미니그림판";
            this.toolStripComboThick.SelectedIndexChanged += new System.EventHandler(this.toolStripComboThick_SelectedIndexChanged);
            // 
            // toolStripBtnLine
            // 
            this.toolStripBtnLine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnLine.Image = global::minipainting.Properties.Resources.Line1;
            this.toolStripBtnLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnLine.Name = "toolStripBtnLine";
            this.toolStripBtnLine.Size = new System.Drawing.Size(23, 22);
            this.toolStripBtnLine.Text = "toolStripButton1";
            this.toolStripBtnLine.ToolTipText = "직선";
            this.toolStripBtnLine.Click += new System.EventHandler(this.toolStripBtnLine_Click);
            // 
            // toolStripBtnRect
            // 
            this.toolStripBtnRect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnRect.Image = global::minipainting.Properties.Resources.Rect;
            this.toolStripBtnRect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnRect.Name = "toolStripBtnRect";
            this.toolStripBtnRect.Size = new System.Drawing.Size(23, 22);
            this.toolStripBtnRect.Text = "toolStripButton2";
            this.toolStripBtnRect.ToolTipText = "사각형";
            this.toolStripBtnRect.Click += new System.EventHandler(this.toolStripBtnRect_Click);
            // 
            // toolStripBtnCircle
            // 
            this.toolStripBtnCircle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnCircle.Image = global::minipainting.Properties.Resources.Circle;
            this.toolStripBtnCircle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnCircle.Name = "toolStripBtnCircle";
            this.toolStripBtnCircle.Size = new System.Drawing.Size(23, 22);
            this.toolStripBtnCircle.Text = "toolStripButton3";
            this.toolStripBtnCircle.ToolTipText = "원";
            this.toolStripBtnCircle.Click += new System.EventHandler(this.toolStripBtnCircle_Click);
            // 
            // toolStripBtnBlack
            // 
            this.toolStripBtnBlack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnBlack.Image = global::minipainting.Properties.Resources.Black;
            this.toolStripBtnBlack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnBlack.Name = "toolStripBtnBlack";
            this.toolStripBtnBlack.Size = new System.Drawing.Size(23, 22);
            this.toolStripBtnBlack.Text = "toolStripButton1";
            this.toolStripBtnBlack.ToolTipText = "검정색";
            this.toolStripBtnBlack.Click += new System.EventHandler(this.toolStripBtnBlack_Click);
            // 
            // toolStripBtnRed
            // 
            this.toolStripBtnRed.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnRed.Image = global::minipainting.Properties.Resources.Red;
            this.toolStripBtnRed.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnRed.Name = "toolStripBtnRed";
            this.toolStripBtnRed.Size = new System.Drawing.Size(23, 22);
            this.toolStripBtnRed.Text = "toolStripButton2";
            this.toolStripBtnRed.ToolTipText = "빨간색";
            this.toolStripBtnRed.Click += new System.EventHandler(this.toolStripBtnRed_Click);
            // 
            // toolStripBtnGreen
            // 
            this.toolStripBtnGreen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnGreen.Image = global::minipainting.Properties.Resources.Green;
            this.toolStripBtnGreen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnGreen.Name = "toolStripBtnGreen";
            this.toolStripBtnGreen.Size = new System.Drawing.Size(23, 22);
            this.toolStripBtnGreen.Text = "toolStripButton3";
            this.toolStripBtnGreen.ToolTipText = "초록색";
            this.toolStripBtnGreen.Click += new System.EventHandler(this.toolStripBtnGreen_Click);
            // 
            // toolStripBtnBlue
            // 
            this.toolStripBtnBlue.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnBlue.Image = global::minipainting.Properties.Resources.Blue;
            this.toolStripBtnBlue.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnBlue.Name = "toolStripBtnBlue";
            this.toolStripBtnBlue.Size = new System.Drawing.Size(23, 22);
            this.toolStripBtnBlue.Text = "toolStripButton4";
            this.toolStripBtnBlue.ToolTipText = "파란색";
            this.toolStripBtnBlue.Click += new System.EventHandler(this.toolStripBtnBlue_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuBar);
            this.MainMenuStrip = this.menuBar;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripNew;
        private System.Windows.Forms.ToolStripMenuItem 도형ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 색상ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripExit;
        private System.Windows.Forms.ToolStripMenuItem ToolStripLine;
        private System.Windows.Forms.ToolStripMenuItem ToolStripRect;
        private System.Windows.Forms.ToolStripMenuItem ToolStripCircle;
        private System.Windows.Forms.ToolStripMenuItem ToolStripColor;
        private System.Windows.Forms.ToolStripButton toolStripBtnLine;
        private System.Windows.Forms.ToolStripButton toolStripBtnRect;
        private System.Windows.Forms.ToolStripButton toolStripBtnCircle;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripBtnBlack;
        private System.Windows.Forms.ToolStripButton toolStripBtnRed;
        private System.Windows.Forms.ToolStripButton toolStripBtnGreen;
        private System.Windows.Forms.ToolStripButton toolStripBtnBlue;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripComboBox toolStripComboThick;
    }
}

