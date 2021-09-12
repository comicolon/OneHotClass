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
    }
}
