using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace iSkorpionAiO_RE
{



public class DropShadow
{
    private bool _isAeroEnabled = false;
    private bool _isDraggingEnabled = false;
    private const int WM_NCHITTEST = 0x0084;
    private const int CS_DROPSHADOW = 0x00020000;
    private const int WS_MINIMIZEBOX = 0x20000;
    private const int HTCLIENT = 0x1;
    private const int HTCAPTION = 0x2;

    [DllImport("dwmapi.dll")]
    public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);

    [DllImport("dwmapi.dll")]
    public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

    [DllImport("dwmapi.dll")]
    public static extern int DwmIsCompositionEnabled(ref int pfEnabled);

    public struct MARGINS
    {
        public int leftWidth;
        public int rightWidth;
        public int topHeight;
        public int bottomHeight;
    }



    public void ApplyShadows(Form form)
    {
        // Check if DWM composition is enabled (Aero Glass effect)
        int v = 0;
        DwmIsCompositionEnabled(ref v);
        _isAeroEnabled = (v == 1);

        if (_isAeroEnabled)
        {
            // Extend the frame into the client area to enable shadow
            var margins = new MARGINS()
            {
                leftWidth = 2,
                rightWidth = 2,
                topHeight = 5, // A non-zero value is key here
                bottomHeight = 5
            };
            DwmExtendFrameIntoClientArea(form.Handle, ref margins);
        }
        else
        {
            // Fallback to the CreateParams method if Aero is off
           // form.CreateParams.ClassStyle |= CS_DROPSHADOW;
        }
    }
}

}