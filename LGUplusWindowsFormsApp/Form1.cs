using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//논리 참조 추가 
using LGUPlus.Common;

namespace LGUplusWindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //폼화면이 로딩완료되면 실행되는 이벤트 
        private void Form1_Load(object sender, EventArgs e)
        {

            UserService service = new UserService();
            var user = service.GetUserData("eddy");

            this.textBox1.Text = user.UserName;
            this.textBox2.Text = user.UserEmail;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("저장버튼이 클릭되었습니다.");
        }
    }
}
