using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OneHotClass
{
	public partial class MainForm : Form
	{
        public static MainForm mainForm; //공용으로 쓰기위한 선언
        public MainForm()
        {
            mainForm = this;            //공용으로 쓰기위한 선언
            InitializeComponent();

            InstanceManager instanceManager = new InstanceManager(); //인스턴스 매니저 생성
        }

		private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			//시스템 트레이에서의 아이콘이 더블클릭되었을때의 이벤트
			this.Visible = true; //윈도우의 모습을 보인다.
			this.ShowIcon = true; //아이콘의 모습을 보인다.
			notifyIcon1.Visible = true; //시스템트레이의 모습을 감춘다.

			this.Show();
			this.WindowState = FormWindowState.Normal;
		}

		private void MainForm_Resize(object sender, EventArgs e)
		{
			if (this.WindowState == FormWindowState.Minimized)
			{
				//winform의 최소화버튼을 눌렀을때의 이벤트
				this.Visible = false; //윈도우의 모습을 감춘다.
				this.ShowIcon = false; //아이콘의 모습을 감춘다.
				notifyIcon1.Visible = true; //시스템트레이의 모습을 보인다.
			}
		}	
	}
}
