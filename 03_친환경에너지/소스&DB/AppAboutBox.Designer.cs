namespace UniversalPowerMonitor
{
    partial class AppAboutBox
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppAboutBox));
            this.tblLP = new System.Windows.Forms.TableLayoutPanel();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.lblCopyrightCol = new System.Windows.Forms.Label();
            this.lblPubCompCol = new System.Windows.Forms.Label();
            this.lblDevCompCol = new System.Windows.Forms.Label();
            this.lblVersionCol = new System.Windows.Forms.Label();
            this.lblPubComp = new System.Windows.Forms.Label();
            this.lblDevComp = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.lblProdName = new System.Windows.Forms.Label();
            this.lblProdNameCol = new System.Windows.Forms.Label();
            this.matMLTB_Desc = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.matBtn_OK = new MaterialSkin.Controls.MaterialButton();
            this.tblLP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tblLP
            // 
            resources.ApplyResources(this.tblLP, "tblLP");
            this.tblLP.Controls.Add(this.lblCopyright, 2, 4);
            this.tblLP.Controls.Add(this.lblCopyrightCol, 1, 4);
            this.tblLP.Controls.Add(this.lblPubCompCol, 1, 3);
            this.tblLP.Controls.Add(this.lblDevCompCol, 1, 2);
            this.tblLP.Controls.Add(this.lblVersionCol, 1, 1);
            this.tblLP.Controls.Add(this.lblPubComp, 2, 3);
            this.tblLP.Controls.Add(this.lblDevComp, 2, 2);
            this.tblLP.Controls.Add(this.lblVersion, 2, 1);
            this.tblLP.Controls.Add(this.logoPictureBox, 0, 0);
            this.tblLP.Controls.Add(this.lblProdName, 2, 0);
            this.tblLP.Controls.Add(this.lblProdNameCol, 1, 0);
            this.tblLP.Controls.Add(this.matMLTB_Desc, 1, 5);
            this.tblLP.Controls.Add(this.matBtn_OK, 2, 6);
            this.tblLP.Name = "tblLP";
            // 
            // lblCopyright
            // 
            resources.ApplyResources(this.lblCopyright, "lblCopyright");
            this.lblCopyright.Name = "lblCopyright";
            // 
            // lblCopyrightCol
            // 
            resources.ApplyResources(this.lblCopyrightCol, "lblCopyrightCol");
            this.lblCopyrightCol.Name = "lblCopyrightCol";
            // 
            // lblPubCompCol
            // 
            resources.ApplyResources(this.lblPubCompCol, "lblPubCompCol");
            this.lblPubCompCol.Name = "lblPubCompCol";
            // 
            // lblDevCompCol
            // 
            resources.ApplyResources(this.lblDevCompCol, "lblDevCompCol");
            this.lblDevCompCol.Name = "lblDevCompCol";
            // 
            // lblVersionCol
            // 
            resources.ApplyResources(this.lblVersionCol, "lblVersionCol");
            this.lblVersionCol.Name = "lblVersionCol";
            // 
            // lblPubComp
            // 
            resources.ApplyResources(this.lblPubComp, "lblPubComp");
            this.lblPubComp.Name = "lblPubComp";
            // 
            // lblDevComp
            // 
            resources.ApplyResources(this.lblDevComp, "lblDevComp");
            this.lblDevComp.Name = "lblDevComp";
            // 
            // lblVersion
            // 
            resources.ApplyResources(this.lblVersion, "lblVersion");
            this.lblVersion.Name = "lblVersion";
            // 
            // logoPictureBox
            // 
            resources.ApplyResources(this.logoPictureBox, "logoPictureBox");
            this.logoPictureBox.Name = "logoPictureBox";
            this.tblLP.SetRowSpan(this.logoPictureBox, 7);
            this.logoPictureBox.TabStop = false;
            // 
            // lblProdName
            // 
            resources.ApplyResources(this.lblProdName, "lblProdName");
            this.lblProdName.Name = "lblProdName";
            // 
            // lblProdNameCol
            // 
            resources.ApplyResources(this.lblProdNameCol, "lblProdNameCol");
            this.lblProdNameCol.Name = "lblProdNameCol";
            // 
            // matMLTB_Desc
            // 
            this.matMLTB_Desc.AnimateReadOnly = false;
            resources.ApplyResources(this.matMLTB_Desc, "matMLTB_Desc");
            this.matMLTB_Desc.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tblLP.SetColumnSpan(this.matMLTB_Desc, 2);
            this.matMLTB_Desc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.matMLTB_Desc.Depth = 0;
            this.matMLTB_Desc.HideSelection = true;
            this.matMLTB_Desc.MaxLength = 32767;
            this.matMLTB_Desc.MouseState = MaterialSkin.MouseState.OUT;
            this.matMLTB_Desc.Name = "matMLTB_Desc";
            this.matMLTB_Desc.PasswordChar = '\0';
            this.matMLTB_Desc.ReadOnly = false;
            this.matMLTB_Desc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.matMLTB_Desc.SelectedText = "";
            this.matMLTB_Desc.SelectionLength = 0;
            this.matMLTB_Desc.SelectionStart = 0;
            this.matMLTB_Desc.ShortcutsEnabled = false;
            this.matMLTB_Desc.TabStop = false;
            this.matMLTB_Desc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.matMLTB_Desc.UseSystemPasswordChar = false;
            // 
            // matBtn_OK
            // 
            resources.ApplyResources(this.matBtn_OK, "matBtn_OK");
            this.matBtn_OK.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.matBtn_OK.Depth = 0;
            this.matBtn_OK.HighEmphasis = true;
            this.matBtn_OK.Icon = null;
            this.matBtn_OK.MouseState = MaterialSkin.MouseState.HOVER;
            this.matBtn_OK.Name = "matBtn_OK";
            this.matBtn_OK.NoAccentTextColor = System.Drawing.Color.Empty;
            this.matBtn_OK.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.matBtn_OK.UseAccentColor = false;
            this.matBtn_OK.UseVisualStyleBackColor = true;
            // 
            // AppAboutBox
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tblLP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AppAboutBox";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Sizable = false;
            this.Load += new System.EventHandler(this.AppAboutBox_Load);
            this.tblLP.ResumeLayout(false);
            this.tblLP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblLP;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Label lblPubComp;
        private System.Windows.Forms.Label lblDevComp;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblProdName;
        private System.Windows.Forms.Label lblPubCompCol;
        private System.Windows.Forms.Label lblDevCompCol;
        private System.Windows.Forms.Label lblVersionCol;
        private System.Windows.Forms.Label lblProdNameCol;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 matMLTB_Desc;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.Label lblCopyrightCol;
        private MaterialSkin.Controls.MaterialButton matBtn_OK;
    }
}
