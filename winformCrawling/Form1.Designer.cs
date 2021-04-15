
namespace winformCrawling
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
            this.tboxID = new System.Windows.Forms.TextBox();
            this.tboxPW = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.Button();
            this.tboxSearch = new System.Windows.Forms.TextBox();
            this.btnSerach = new System.Windows.Forms.Button();
            this.tboxUrl = new System.Windows.Forms.TextBox();
            this.pboxMain = new System.Windows.Forms.PictureBox();
            this.btnPre = new System.Windows.Forms.Button();
            this.tboxNow = new System.Windows.Forms.TextBox();
            this.lbTotal = new System.Windows.Forms.Label();
            this.btnGo = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pboxMain)).BeginInit();
            this.SuspendLayout();
            // 
            // tboxID
            // 
            this.tboxID.Location = new System.Drawing.Point(93, 53);
            this.tboxID.Name = "tboxID";
            this.tboxID.Size = new System.Drawing.Size(131, 28);
            this.tboxID.TabIndex = 0;
            // 
            // tboxPW
            // 
            this.tboxPW.Location = new System.Drawing.Point(92, 101);
            this.tboxPW.Name = "tboxPW";
            this.tboxPW.Size = new System.Drawing.Size(131, 28);
            this.tboxPW.TabIndex = 1;
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(241, 49);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(120, 79);
            this.Login.TabIndex = 2;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tboxSearch
            // 
            this.tboxSearch.Location = new System.Drawing.Point(93, 184);
            this.tboxSearch.Name = "tboxSearch";
            this.tboxSearch.Size = new System.Drawing.Size(187, 28);
            this.tboxSearch.TabIndex = 3;
            // 
            // btnSerach
            // 
            this.btnSerach.Location = new System.Drawing.Point(291, 183);
            this.btnSerach.Name = "btnSerach";
            this.btnSerach.Size = new System.Drawing.Size(69, 28);
            this.btnSerach.TabIndex = 4;
            this.btnSerach.Text = "조회";
            this.btnSerach.UseVisualStyleBackColor = true;
            this.btnSerach.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tboxUrl
            // 
            this.tboxUrl.Location = new System.Drawing.Point(93, 233);
            this.tboxUrl.Name = "tboxUrl";
            this.tboxUrl.Size = new System.Drawing.Size(266, 28);
            this.tboxUrl.TabIndex = 5;
            // 
            // pboxMain
            // 
            this.pboxMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pboxMain.Location = new System.Drawing.Point(410, 37);
            this.pboxMain.Name = "pboxMain";
            this.pboxMain.Size = new System.Drawing.Size(340, 290);
            this.pboxMain.TabIndex = 6;
            this.pboxMain.TabStop = false;
            // 
            // btnPre
            // 
            this.btnPre.Location = new System.Drawing.Point(415, 349);
            this.btnPre.Name = "btnPre";
            this.btnPre.Size = new System.Drawing.Size(87, 32);
            this.btnPre.TabIndex = 7;
            this.btnPre.Text = "◀";
            this.btnPre.UseVisualStyleBackColor = true;
            // 
            // tboxNow
            // 
            this.tboxNow.Location = new System.Drawing.Point(511, 352);
            this.tboxNow.Name = "tboxNow";
            this.tboxNow.Size = new System.Drawing.Size(39, 28);
            this.tboxNow.TabIndex = 8;
            this.tboxNow.Text = "0";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(555, 357);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(26, 18);
            this.lbTotal.TabIndex = 9;
            this.lbTotal.Text = "/0";
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(590, 351);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(67, 28);
            this.btnGo.TabIndex = 10;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(672, 349);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 32);
            this.btnNext.TabIndex = 11;
            this.btnNext.Text = "▶";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.tboxNow);
            this.Controls.Add(this.btnPre);
            this.Controls.Add(this.pboxMain);
            this.Controls.Add(this.tboxUrl);
            this.Controls.Add(this.btnSerach);
            this.Controls.Add(this.tboxSearch);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.tboxPW);
            this.Controls.Add(this.tboxID);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pboxMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tboxID;
        private System.Windows.Forms.TextBox tboxPW;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.TextBox tboxSearch;
        private System.Windows.Forms.Button btnSerach;
        private System.Windows.Forms.TextBox tboxUrl;
        private System.Windows.Forms.PictureBox pboxMain;
        private System.Windows.Forms.Button btnPre;
        private System.Windows.Forms.TextBox tboxNow;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Button btnNext;
    }
}

