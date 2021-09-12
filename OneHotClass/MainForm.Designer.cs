
namespace OneHotClass
{
	partial class MainForm
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
			this.label_email = new System.Windows.Forms.Label();
			this.label_password = new System.Windows.Forms.Label();
			this.textBox_email = new System.Windows.Forms.TextBox();
			this.textBox_password = new System.Windows.Forms.TextBox();
			this.button_login = new System.Windows.Forms.Button();
			this.button_logout = new System.Windows.Forms.Button();
			this.button_google = new System.Windows.Forms.Button();
			this.button_naver = new System.Windows.Forms.Button();
			this.button_codestates = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label_email
			// 
			this.label_email.AutoSize = true;
			this.label_email.Location = new System.Drawing.Point(26, 108);
			this.label_email.Name = "label_email";
			this.label_email.Size = new System.Drawing.Size(69, 12);
			this.label_email.TabIndex = 0;
			this.label_email.Text = "이메일 주소";
			// 
			// label_password
			// 
			this.label_password.AutoSize = true;
			this.label_password.Location = new System.Drawing.Point(26, 143);
			this.label_password.Name = "label_password";
			this.label_password.Size = new System.Drawing.Size(53, 12);
			this.label_password.TabIndex = 1;
			this.label_password.Text = "비밀번호";
			// 
			// textBox_email
			// 
			this.textBox_email.Location = new System.Drawing.Point(101, 105);
			this.textBox_email.Name = "textBox_email";
			this.textBox_email.Size = new System.Drawing.Size(151, 21);
			this.textBox_email.TabIndex = 2;
			// 
			// textBox_password
			// 
			this.textBox_password.Location = new System.Drawing.Point(101, 140);
			this.textBox_password.Name = "textBox_password";
			this.textBox_password.Size = new System.Drawing.Size(151, 21);
			this.textBox_password.TabIndex = 3;
			// 
			// button_login
			// 
			this.button_login.Location = new System.Drawing.Point(269, 105);
			this.button_login.Name = "button_login";
			this.button_login.Size = new System.Drawing.Size(75, 54);
			this.button_login.TabIndex = 4;
			this.button_login.Text = "로그인";
			this.button_login.UseVisualStyleBackColor = true;
			// 
			// button_logout
			// 
			this.button_logout.Location = new System.Drawing.Point(350, 105);
			this.button_logout.Name = "button_logout";
			this.button_logout.Size = new System.Drawing.Size(63, 54);
			this.button_logout.TabIndex = 5;
			this.button_logout.Text = "로그아웃";
			this.button_logout.UseVisualStyleBackColor = true;
			// 
			// button_google
			// 
			this.button_google.Location = new System.Drawing.Point(101, 176);
			this.button_google.Name = "button_google";
			this.button_google.Size = new System.Drawing.Size(75, 23);
			this.button_google.TabIndex = 6;
			this.button_google.Text = "구글";
			this.button_google.UseVisualStyleBackColor = true;
			// 
			// button_naver
			// 
			this.button_naver.Location = new System.Drawing.Point(182, 176);
			this.button_naver.Name = "button_naver";
			this.button_naver.Size = new System.Drawing.Size(75, 23);
			this.button_naver.TabIndex = 7;
			this.button_naver.Text = "네이버";
			this.button_naver.UseVisualStyleBackColor = true;
			// 
			// button_codestates
			// 
			this.button_codestates.Location = new System.Drawing.Point(28, 30);
			this.button_codestates.Name = "button_codestates";
			this.button_codestates.Size = new System.Drawing.Size(148, 51);
			this.button_codestates.TabIndex = 8;
			this.button_codestates.Text = "코-스 홈페이지";
			this.button_codestates.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.button_codestates);
			this.Controls.Add(this.button_naver);
			this.Controls.Add(this.button_google);
			this.Controls.Add(this.button_logout);
			this.Controls.Add(this.button_login);
			this.Controls.Add(this.textBox_password);
			this.Controls.Add(this.textBox_email);
			this.Controls.Add(this.label_password);
			this.Controls.Add(this.label_email);
			this.Name = "MainForm";
			this.Text = "OneHotClass";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label_email;
		private System.Windows.Forms.Label label_password;
		internal System.Windows.Forms.Button button_login;
		internal System.Windows.Forms.TextBox textBox_email;
		internal System.Windows.Forms.TextBox textBox_password;
		internal System.Windows.Forms.Button button_logout;
		internal System.Windows.Forms.Button button_google;
		internal System.Windows.Forms.Button button_naver;
		internal System.Windows.Forms.Button button_codestates;
	}
}

