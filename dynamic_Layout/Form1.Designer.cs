
namespace dynamic_Layout
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ucFormColorMenu = new dynamic_Layout.ucColorMenu();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ucPanel2 = new dynamic_Layout.ucPanel();
            this.ucPanel3 = new dynamic_Layout.ucPanel();
            this.ucPanel4 = new dynamic_Layout.ucPanel();
            this.ucPanel1 = new dynamic_Layout.ucPanel();
            this.lboxLog = new System.Windows.Forms.ListBox();
            this.btnPanelRe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.splitContainer1.Panel1.Controls.Add(this.btnPanelRe);
            this.splitContainer1.Panel1.Controls.Add(this.ucFormColorMenu);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(871, 460);
            this.splitContainer1.SplitterDistance = 129;
            this.splitContainer1.TabIndex = 0;
            // 
            // ucFormColorMenu
            // 
            this.ucFormColorMenu.BackColor = System.Drawing.SystemColors.Control;
            this.ucFormColorMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucFormColorMenu.Location = new System.Drawing.Point(0, 0);
            this.ucFormColorMenu.Name = "ucFormColorMenu";
            this.ucFormColorMenu.Size = new System.Drawing.Size(129, 460);
            this.ucFormColorMenu.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 563F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ucPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lboxLog, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.05821F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.94366F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.99812F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(738, 460);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.ucPanel2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.ucPanel3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.ucPanel4, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 101);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(738, 243);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // ucPanel2
            // 
            this.ucPanel2.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ucPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPanel2.Location = new System.Drawing.Point(0, 0);
            this.ucPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.ucPanel2.Name = "ucPanel2";
            this.ucPanel2.Size = new System.Drawing.Size(369, 121);
            this.ucPanel2.TabIndex = 0;
            // 
            // ucPanel3
            // 
            this.ucPanel3.BackColor = System.Drawing.Color.PaleVioletRed;
            this.ucPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPanel3.Location = new System.Drawing.Point(0, 121);
            this.ucPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.ucPanel3.Name = "ucPanel3";
            this.ucPanel3.Size = new System.Drawing.Size(369, 122);
            this.ucPanel3.TabIndex = 1;
            // 
            // ucPanel4
            // 
            this.ucPanel4.BackColor = System.Drawing.Color.PaleGreen;
            this.ucPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPanel4.Location = new System.Drawing.Point(369, 0);
            this.ucPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.ucPanel4.Name = "ucPanel4";
            this.tableLayoutPanel2.SetRowSpan(this.ucPanel4, 2);
            this.ucPanel4.Size = new System.Drawing.Size(369, 243);
            this.ucPanel4.TabIndex = 2;
            // 
            // ucPanel1
            // 
            this.ucPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ucPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPanel1.Location = new System.Drawing.Point(0, 0);
            this.ucPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.ucPanel1.Name = "ucPanel1";
            this.ucPanel1.Size = new System.Drawing.Size(738, 101);
            this.ucPanel1.TabIndex = 1;
            // 
            // lboxLog
            // 
            this.lboxLog.BackColor = System.Drawing.SystemColors.Menu;
            this.lboxLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lboxLog.FormattingEnabled = true;
            this.lboxLog.ItemHeight = 15;
            this.lboxLog.Location = new System.Drawing.Point(0, 344);
            this.lboxLog.Margin = new System.Windows.Forms.Padding(0);
            this.lboxLog.Name = "lboxLog";
            this.lboxLog.Size = new System.Drawing.Size(738, 116);
            this.lboxLog.TabIndex = 2;
            // 
            // btnPanelRe
            // 
            this.btnPanelRe.BackColor = System.Drawing.Color.Gray;
            this.btnPanelRe.Location = new System.Drawing.Point(8, 344);
            this.btnPanelRe.Name = "btnPanelRe";
            this.btnPanelRe.Size = new System.Drawing.Size(112, 32);
            this.btnPanelRe.TabIndex = 1;
            this.btnPanelRe.Text = "초기화";
            this.btnPanelRe.UseVisualStyleBackColor = false;
            this.btnPanelRe.Click += new System.EventHandler(this.btnPanelRe_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 460);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private ucPanel ucPanel2;
        private ucPanel ucPanel1;
        private ucPanel ucPanel3;
        private ucPanel ucPanel4;
        private ucColorMenu ucFormColorMenu;
        private System.Windows.Forms.ListBox lboxLog;
        private System.Windows.Forms.Button btnPanelRe;
    }
}

