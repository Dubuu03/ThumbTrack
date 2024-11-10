using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

public class RoundedPanel : Panel
{
    public int BorderRadius { get; set; } = 30; // Default radius for smoother corners

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        // Set anti-aliasing for smoother edges
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
        e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

        // Create a GraphicsPath for rounded corners with smoother curves
        using (var path = new GraphicsPath())
        {
            path.AddArc(0, 0, BorderRadius, BorderRadius, 180, 90);
            path.AddArc(Width - BorderRadius, 0, BorderRadius, BorderRadius, 270, 90);
            path.AddArc(Width - BorderRadius, Height - BorderRadius, BorderRadius, BorderRadius, 0, 90);
            path.AddArc(0, Height - BorderRadius, BorderRadius, BorderRadius, 90, 90);
            path.CloseAllFigures();

            // Set the region of the panel to the rounded shape
            this.Region = new Region(path);

            // Fill the background with the panel's background color
            e.Graphics.FillPath(new SolidBrush(BackColor), path);
        }
    }
}