namespace WindowsFormsApplication1
{
    using System;
    using System.Windows.Forms;

    public partial class Form1 :Form
    {
        private const int WM_KEYDOWN = 0x0100;

        private const int WM_SETTEXT = 0x000c;

        public Form1()
        {
            InitializeComponent();

            button1.Click += OnClick;
        }

        private void OnClick(object sender, EventArgs e)
        {
            IntPtr hWndNotepad = NativeMethods.FindWindow("Notepad", null);

            IntPtr hWndEdit = NativeMethods.FindWindowEx(hWndNotepad, IntPtr.Zero, "Edit", null);

            NativeMethods.SendMessage(hWndEdit, WM_SETTEXT, 0, " key");

            NativeMethods.PostMessage(hWndEdit, WM_KEYDOWN, Keys.A, IntPtr.Zero);
        }
    }
}