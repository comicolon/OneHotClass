
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.label_email = new System.Windows.Forms.Label();
			this.label_password = new System.Windows.Forms.Label();
			this.textBox_email = new System.Windows.Forms.TextBox();
			this.textBox_password = new System.Windows.Forms.TextBox();
			this.button_login = new System.Windows.Forms.Button();
			this.button_codestates = new System.Windows.Forms.Button();
			this.dataGridView_timeTable = new System.Windows.Forms.DataGridView();
			this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.일정내용 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.button_getSchedule = new System.Windows.Forms.Button();
			this.textBox_calendarWord = new System.Windows.Forms.TextBox();
			this.label_alamSearchWord = new System.Windows.Forms.Label();
			this.textBox_searchWord1 = new System.Windows.Forms.TextBox();
			this.textBox_searchWord2 = new System.Windows.Forms.TextBox();
			this.textBox_searchWord3 = new System.Windows.Forms.TextBox();
			this.textBox_searchWord4 = new System.Windows.Forms.TextBox();
			this.textBox_pythonPath = new System.Windows.Forms.TextBox();
			this.label_python = new System.Windows.Forms.Label();
			this.button_zoomLink = new System.Windows.Forms.Button();
			this.button_2ndLogin = new System.Windows.Forms.Button();
			this.checkBox_chainLogin = new System.Windows.Forms.CheckBox();
			this.button_preLoginKakao = new System.Windows.Forms.Button();
			this.button_preLoginGoogle = new System.Windows.Forms.Button();
			this.button_logout = new System.Windows.Forms.Button();
			this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
			this.button_applyAlam = new System.Windows.Forms.Button();
			this.button_saveSetting = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_timeTable)).BeginInit();
			this.SuspendLayout();
			// 
			// label_email
			// 
			this.label_email.AutoSize = true;
			this.label_email.Location = new System.Drawing.Point(26, 216);
			this.label_email.Name = "label_email";
			this.label_email.Size = new System.Drawing.Size(69, 12);
			this.label_email.TabIndex = 0;
			this.label_email.Text = "이메일 주소";
			this.label_email.UseWaitCursor = true;
			// 
			// label_password
			// 
			this.label_password.AutoSize = true;
			this.label_password.Location = new System.Drawing.Point(26, 243);
			this.label_password.Name = "label_password";
			this.label_password.Size = new System.Drawing.Size(53, 12);
			this.label_password.TabIndex = 1;
			this.label_password.Text = "비밀번호";
			this.label_password.UseWaitCursor = true;
			// 
			// textBox_email
			// 
			this.textBox_email.Location = new System.Drawing.Point(101, 213);
			this.textBox_email.Name = "textBox_email";
			this.textBox_email.Size = new System.Drawing.Size(151, 21);
			this.textBox_email.TabIndex = 2;
			this.textBox_email.UseWaitCursor = true;
			// 
			// textBox_password
			// 
			this.textBox_password.Location = new System.Drawing.Point(101, 240);
			this.textBox_password.Name = "textBox_password";
			this.textBox_password.Size = new System.Drawing.Size(151, 21);
			this.textBox_password.TabIndex = 3;
			this.textBox_password.UseSystemPasswordChar = true;
			this.textBox_password.UseWaitCursor = true;
			// 
			// button_login
			// 
			this.button_login.Location = new System.Drawing.Point(28, 97);
			this.button_login.Name = "button_login";
			this.button_login.Size = new System.Drawing.Size(75, 54);
			this.button_login.TabIndex = 4;
			this.button_login.Text = "1차로그인";
			this.button_login.UseVisualStyleBackColor = true;
			this.button_login.UseWaitCursor = true;
			// 
			// button_codestates
			// 
			this.button_codestates.Location = new System.Drawing.Point(28, 30);
			this.button_codestates.Name = "button_codestates";
			this.button_codestates.Size = new System.Drawing.Size(148, 51);
			this.button_codestates.TabIndex = 8;
			this.button_codestates.Text = "코-스 홈페이지";
			this.button_codestates.UseVisualStyleBackColor = true;
			this.button_codestates.UseWaitCursor = true;
			// 
			// dataGridView_timeTable
			// 
			this.dataGridView_timeTable.AllowUserToAddRows = false;
			this.dataGridView_timeTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_timeTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.time,
            this.일정내용});
			this.dataGridView_timeTable.Location = new System.Drawing.Point(347, 59);
			this.dataGridView_timeTable.Name = "dataGridView_timeTable";
			this.dataGridView_timeTable.ReadOnly = true;
			this.dataGridView_timeTable.RowHeadersVisible = false;
			this.dataGridView_timeTable.RowTemplate.Height = 23;
			this.dataGridView_timeTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView_timeTable.Size = new System.Drawing.Size(441, 176);
			this.dataGridView_timeTable.TabIndex = 10;
			this.dataGridView_timeTable.UseWaitCursor = true;
			// 
			// time
			// 
			this.time.Frozen = true;
			this.time.HeaderText = "시간";
			this.time.Name = "time";
			this.time.ReadOnly = true;
			this.time.Width = 200;
			// 
			// 일정내용
			// 
			this.일정내용.Frozen = true;
			this.일정내용.HeaderText = "schedule";
			this.일정내용.Name = "일정내용";
			this.일정내용.ReadOnly = true;
			this.일정내용.Width = 250;
			// 
			// button_getSchedule
			// 
			this.button_getSchedule.Location = new System.Drawing.Point(504, 30);
			this.button_getSchedule.Name = "button_getSchedule";
			this.button_getSchedule.Size = new System.Drawing.Size(75, 23);
			this.button_getSchedule.TabIndex = 11;
			this.button_getSchedule.Text = "일정표";
			this.button_getSchedule.UseVisualStyleBackColor = true;
			// 
			// textBox_calendarWord
			// 
			this.textBox_calendarWord.Location = new System.Drawing.Point(595, 32);
			this.textBox_calendarWord.Name = "textBox_calendarWord";
			this.textBox_calendarWord.Size = new System.Drawing.Size(150, 21);
			this.textBox_calendarWord.TabIndex = 12;
			// 
			// label_alamSearchWord
			// 
			this.label_alamSearchWord.AutoSize = true;
			this.label_alamSearchWord.Location = new System.Drawing.Point(580, 240);
			this.label_alamSearchWord.Name = "label_alamSearchWord";
			this.label_alamSearchWord.Size = new System.Drawing.Size(69, 12);
			this.label_alamSearchWord.TabIndex = 13;
			this.label_alamSearchWord.Text = "알람 검색어";
			// 
			// textBox_searchWord1
			// 
			this.textBox_searchWord1.Location = new System.Drawing.Point(582, 258);
			this.textBox_searchWord1.Name = "textBox_searchWord1";
			this.textBox_searchWord1.Size = new System.Drawing.Size(100, 21);
			this.textBox_searchWord1.TabIndex = 14;
			// 
			// textBox_searchWord2
			// 
			this.textBox_searchWord2.Location = new System.Drawing.Point(688, 258);
			this.textBox_searchWord2.Name = "textBox_searchWord2";
			this.textBox_searchWord2.Size = new System.Drawing.Size(100, 21);
			this.textBox_searchWord2.TabIndex = 15;
			// 
			// textBox_searchWord3
			// 
			this.textBox_searchWord3.Location = new System.Drawing.Point(582, 285);
			this.textBox_searchWord3.Name = "textBox_searchWord3";
			this.textBox_searchWord3.Size = new System.Drawing.Size(100, 21);
			this.textBox_searchWord3.TabIndex = 16;
			// 
			// textBox_searchWord4
			// 
			this.textBox_searchWord4.Location = new System.Drawing.Point(688, 285);
			this.textBox_searchWord4.Name = "textBox_searchWord4";
			this.textBox_searchWord4.Size = new System.Drawing.Size(100, 21);
			this.textBox_searchWord4.TabIndex = 17;
			// 
			// textBox_pythonPath
			// 
			this.textBox_pythonPath.Location = new System.Drawing.Point(101, 417);
			this.textBox_pythonPath.Name = "textBox_pythonPath";
			this.textBox_pythonPath.Size = new System.Drawing.Size(408, 21);
			this.textBox_pythonPath.TabIndex = 18;
			// 
			// label_python
			// 
			this.label_python.AutoSize = true;
			this.label_python.Location = new System.Drawing.Point(12, 420);
			this.label_python.Name = "label_python";
			this.label_python.Size = new System.Drawing.Size(69, 12);
			this.label_python.TabIndex = 19;
			this.label_python.Text = "파이썬 경로";
			// 
			// button_zoomLink
			// 
			this.button_zoomLink.Location = new System.Drawing.Point(347, 256);
			this.button_zoomLink.Name = "button_zoomLink";
			this.button_zoomLink.Size = new System.Drawing.Size(96, 50);
			this.button_zoomLink.TabIndex = 20;
			this.button_zoomLink.Text = "Zoom 링크";
			this.button_zoomLink.UseVisualStyleBackColor = true;
			// 
			// button_2ndLogin
			// 
			this.button_2ndLogin.Location = new System.Drawing.Point(177, 97);
			this.button_2ndLogin.Name = "button_2ndLogin";
			this.button_2ndLogin.Size = new System.Drawing.Size(75, 54);
			this.button_2ndLogin.TabIndex = 21;
			this.button_2ndLogin.Text = "2차로그인";
			this.button_2ndLogin.UseVisualStyleBackColor = true;
			this.button_2ndLogin.UseWaitCursor = true;
			// 
			// checkBox_chainLogin
			// 
			this.checkBox_chainLogin.AutoSize = true;
			this.checkBox_chainLogin.Location = new System.Drawing.Point(28, 157);
			this.checkBox_chainLogin.Name = "checkBox_chainLogin";
			this.checkBox_chainLogin.Size = new System.Drawing.Size(84, 16);
			this.checkBox_chainLogin.TabIndex = 22;
			this.checkBox_chainLogin.Text = "연속로그인";
			this.checkBox_chainLogin.UseVisualStyleBackColor = true;
			// 
			// button_preLoginKakao
			// 
			this.button_preLoginKakao.Location = new System.Drawing.Point(109, 97);
			this.button_preLoginKakao.Name = "button_preLoginKakao";
			this.button_preLoginKakao.Size = new System.Drawing.Size(62, 23);
			this.button_preLoginKakao.TabIndex = 23;
			this.button_preLoginKakao.Text = "카카오";
			this.button_preLoginKakao.UseVisualStyleBackColor = true;
			// 
			// button_preLoginGoogle
			// 
			this.button_preLoginGoogle.Location = new System.Drawing.Point(109, 128);
			this.button_preLoginGoogle.Name = "button_preLoginGoogle";
			this.button_preLoginGoogle.Size = new System.Drawing.Size(62, 23);
			this.button_preLoginGoogle.TabIndex = 24;
			this.button_preLoginGoogle.Text = "구글";
			this.button_preLoginGoogle.UseVisualStyleBackColor = true;
			// 
			// button_logout
			// 
			this.button_logout.Location = new System.Drawing.Point(258, 97);
			this.button_logout.Name = "button_logout";
			this.button_logout.Size = new System.Drawing.Size(75, 54);
			this.button_logout.TabIndex = 25;
			this.button_logout.Text = "로그아웃";
			this.button_logout.UseVisualStyleBackColor = true;
			this.button_logout.UseWaitCursor = true;
			// 
			// notifyIcon1
			// 
			this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
			this.notifyIcon1.Text = "notifyIcon1";
			this.notifyIcon1.Visible = true;
			this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
			// 
			// button_applyAlam
			// 
			this.button_applyAlam.Location = new System.Drawing.Point(582, 312);
			this.button_applyAlam.Name = "button_applyAlam";
			this.button_applyAlam.Size = new System.Drawing.Size(75, 23);
			this.button_applyAlam.TabIndex = 26;
			this.button_applyAlam.Text = "알람적용";
			this.button_applyAlam.UseVisualStyleBackColor = true;
			// 
			// button_saveSetting
			// 
			this.button_saveSetting.Location = new System.Drawing.Point(713, 415);
			this.button_saveSetting.Name = "button_saveSetting";
			this.button_saveSetting.Size = new System.Drawing.Size(75, 23);
			this.button_saveSetting.TabIndex = 27;
			this.button_saveSetting.Text = "설정저장";
			this.button_saveSetting.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.button_saveSetting);
			this.Controls.Add(this.button_applyAlam);
			this.Controls.Add(this.button_logout);
			this.Controls.Add(this.button_preLoginGoogle);
			this.Controls.Add(this.button_preLoginKakao);
			this.Controls.Add(this.checkBox_chainLogin);
			this.Controls.Add(this.button_2ndLogin);
			this.Controls.Add(this.button_zoomLink);
			this.Controls.Add(this.label_python);
			this.Controls.Add(this.textBox_pythonPath);
			this.Controls.Add(this.textBox_searchWord4);
			this.Controls.Add(this.textBox_searchWord3);
			this.Controls.Add(this.textBox_searchWord2);
			this.Controls.Add(this.textBox_searchWord1);
			this.Controls.Add(this.label_alamSearchWord);
			this.Controls.Add(this.textBox_calendarWord);
			this.Controls.Add(this.button_getSchedule);
			this.Controls.Add(this.dataGridView_timeTable);
			this.Controls.Add(this.button_codestates);
			this.Controls.Add(this.button_login);
			this.Controls.Add(this.textBox_password);
			this.Controls.Add(this.textBox_email);
			this.Controls.Add(this.label_password);
			this.Controls.Add(this.label_email);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.Text = "OneHotClass";
			this.Resize += new System.EventHandler(this.MainForm_Resize);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_timeTable)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label_email;
		private System.Windows.Forms.Label label_password;
		internal System.Windows.Forms.Button button_login;
		internal System.Windows.Forms.TextBox textBox_email;
		internal System.Windows.Forms.TextBox textBox_password;
		internal System.Windows.Forms.Button button_codestates;
		internal System.Windows.Forms.DataGridView dataGridView_timeTable;
		internal System.Windows.Forms.Button button_getSchedule;
		internal System.Windows.Forms.TextBox textBox_calendarWord;
		private System.Windows.Forms.Label label_alamSearchWord;
		internal System.Windows.Forms.TextBox textBox_searchWord1;
		internal System.Windows.Forms.TextBox textBox_searchWord2;
		internal System.Windows.Forms.TextBox textBox_searchWord3;
		internal System.Windows.Forms.TextBox textBox_searchWord4;
		internal System.Windows.Forms.TextBox textBox_pythonPath;
		private System.Windows.Forms.Label label_python;
		private System.Windows.Forms.DataGridViewTextBoxColumn time;
		private System.Windows.Forms.DataGridViewTextBoxColumn 일정내용;
		internal System.Windows.Forms.Button button_zoomLink;
		internal System.Windows.Forms.Button button_2ndLogin;
		internal System.Windows.Forms.CheckBox checkBox_chainLogin;
		internal System.Windows.Forms.Button button_preLoginKakao;
		internal System.Windows.Forms.Button button_preLoginGoogle;
		internal System.Windows.Forms.Button button_logout;
		internal System.Windows.Forms.NotifyIcon notifyIcon1;
		internal System.Windows.Forms.Button button_applyAlam;
		internal System.Windows.Forms.Button button_saveSetting;
	}
}

