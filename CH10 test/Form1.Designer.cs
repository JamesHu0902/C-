namespace CH10_test
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.id_Text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.psd_Text = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.btn_calc = new System.Windows.Forms.Button();
            this.btn_link = new System.Windows.Forms.Button();
            this.n_Text = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.star = new System.Windows.Forms.Button();
            this.ans = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // id_Text
            // 
            this.id_Text.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.id_Text.Location = new System.Drawing.Point(305, 57);
            this.id_Text.Name = "id_Text";
            this.id_Text.Size = new System.Drawing.Size(192, 43);
            this.id_Text.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(145, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "帳號";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(145, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 44);
            this.label2.TabIndex = 3;
            this.label2.Text = "密碼";
            // 
            // psd_Text
            // 
            this.psd_Text.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.psd_Text.Location = new System.Drawing.Point(305, 136);
            this.psd_Text.Name = "psd_Text";
            this.psd_Text.PasswordChar = '*';
            this.psd_Text.Size = new System.Drawing.Size(192, 43);
            this.psd_Text.TabIndex = 2;
            this.toolTip2.SetToolTip(this.psd_Text, "這是TOOL2");
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(168, 305);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(96, 45);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "登入";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(439, 305);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(96, 45);
            this.btnEnd.TabIndex = 5;
            this.btnEnd.Text = "離開";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.ReshowDelay = 100;
            this.toolTip1.ShowAlways = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "請輸入帳號";
            // 
            // toolTip2
            // 
            this.toolTip2.AutoPopDelay = 5000;
            this.toolTip2.InitialDelay = 500;
            this.toolTip2.ReshowDelay = 100;
            this.toolTip2.ShowAlways = true;
            this.toolTip2.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip2.ToolTipTitle = "請輸入密碼";
            // 
            // btn_calc
            // 
            this.btn_calc.Location = new System.Drawing.Point(168, 225);
            this.btn_calc.Name = "btn_calc";
            this.btn_calc.Size = new System.Drawing.Size(96, 45);
            this.btn_calc.TabIndex = 6;
            this.btn_calc.Text = "小算盤";
            this.btn_calc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_calc.UseVisualStyleBackColor = true;
            this.btn_calc.Click += new System.EventHandler(this.btn_calc_Click);
            // 
            // btn_link
            // 
            this.btn_link.Location = new System.Drawing.Point(305, 225);
            this.btn_link.Name = "btn_link";
            this.btn_link.Size = new System.Drawing.Size(96, 45);
            this.btn_link.TabIndex = 7;
            this.btn_link.Text = "Google";
            this.btn_link.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_link.UseVisualStyleBackColor = true;
            this.btn_link.Click += new System.EventHandler(this.btn_link_Click);
            // 
            // n_Text
            // 
            this.n_Text.Location = new System.Drawing.Point(135, 394);
            this.n_Text.Name = "n_Text";
            this.n_Text.Size = new System.Drawing.Size(100, 22);
            this.n_Text.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 398);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "請輸入 n 值";
            // 
            // star
            // 
            this.star.Location = new System.Drawing.Point(263, 393);
            this.star.Name = "star";
            this.star.Size = new System.Drawing.Size(75, 23);
            this.star.TabIndex = 10;
            this.star.Text = "star";
            this.star.UseVisualStyleBackColor = true;
            this.star.Click += new System.EventHandler(this.star_Click);
            // 
            // ans
            // 
            this.ans.AutoSize = true;
            this.ans.Location = new System.Drawing.Point(394, 401);
            this.ans.Name = "ans";
            this.ans.Size = new System.Drawing.Size(33, 12);
            this.ans.TabIndex = 11;
            this.ans.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ans);
            this.Controls.Add(this.star);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.n_Text);
            this.Controls.Add(this.btn_link);
            this.Controls.Add(this.btn_calc);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.psd_Text);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.id_Text);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox id_Text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox psd_Text;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btnEnd;
        public System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.Button btn_calc;
        private System.Windows.Forms.Button btn_link;
        private System.Windows.Forms.TextBox n_Text;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button star;
        private System.Windows.Forms.Label ans;
    }
}

