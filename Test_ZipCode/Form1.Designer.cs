namespace Test_ZipCode
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
            this.TBox_ZipCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Search = new System.Windows.Forms.Button();
            this.TBox_Address1 = new System.Windows.Forms.TextBox();
            this.TBox_Address2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TBox_Notes = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TBox_ZipCode
            // 
            this.TBox_ZipCode.Location = new System.Drawing.Point(124, 66);
            this.TBox_ZipCode.Name = "TBox_ZipCode";
            this.TBox_ZipCode.Size = new System.Drawing.Size(100, 21);
            this.TBox_ZipCode.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "우편번호";
            // 
            // Btn_Search
            // 
            this.Btn_Search.Location = new System.Drawing.Point(230, 65);
            this.Btn_Search.Name = "Btn_Search";
            this.Btn_Search.Size = new System.Drawing.Size(75, 23);
            this.Btn_Search.TabIndex = 2;
            this.Btn_Search.Text = "주소검색";
            this.Btn_Search.UseVisualStyleBackColor = true;
            this.Btn_Search.Click += new System.EventHandler(this.Btn_Search_Click);
            // 
            // TBox_Address1
            // 
            this.TBox_Address1.Location = new System.Drawing.Point(124, 93);
            this.TBox_Address1.Name = "TBox_Address1";
            this.TBox_Address1.Size = new System.Drawing.Size(280, 21);
            this.TBox_Address1.TabIndex = 3;
            // 
            // TBox_Address2
            // 
            this.TBox_Address2.Location = new System.Drawing.Point(124, 120);
            this.TBox_Address2.Name = "TBox_Address2";
            this.TBox_Address2.Size = new System.Drawing.Size(280, 21);
            this.TBox_Address2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "주소1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "주소2";
            // 
            // TBox_Notes
            // 
            this.TBox_Notes.Location = new System.Drawing.Point(124, 147);
            this.TBox_Notes.Name = "TBox_Notes";
            this.TBox_Notes.Size = new System.Drawing.Size(280, 21);
            this.TBox_Notes.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "참고";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TBox_Notes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBox_Address2);
            this.Controls.Add(this.TBox_Address1);
            this.Controls.Add(this.Btn_Search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBox_ZipCode);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBox_ZipCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Search;
        private System.Windows.Forms.TextBox TBox_Address1;
        private System.Windows.Forms.TextBox TBox_Address2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBox_Notes;
        private System.Windows.Forms.Label label4;
    }
}

