using ExpressCraft;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressCraftExample
{
    public class frmMain : Form
    {
        public frmMain()
        {
            this.Body.SetBoundsFull();
            this.Heading.style.visibility = "hidden";

            ShowClose = false;
            ShowMinimize = false;
            ShowMaximize = false;

            this.WindowState = WindowStateType.Maximized;

            this.AllowMoveChange = false;
            this.AllowSizeChange = false;
        }
    }
}
