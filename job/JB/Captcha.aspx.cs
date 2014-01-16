using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Web.UI;

namespace JB
{
    public partial class captcha : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var Text = Request.QueryString["ranstr"].Replace(".png", "").Trim();
            Session["capts"] = (Text.Length)-1;

            const int Height = 100;
            const int Width = 320;
            var bitmap = new Bitmap(Width, Height);

            Graphics graphics = Graphics.FromImage(bitmap);

            var BrushBackColor = new SolidBrush(Color.Silver);
            var OverLay = new Pen(Color.Silver);
            var _TotalPoints = Convert.ToInt16(Text.Length-1);

            Rectangle[] _RectPoints = new Rectangle[_TotalPoints];

            Random r = new Random();

            int w, x, y, z;

            w = r.Next(0, 25);

            if (_TotalPoints < 5)
            {
                w += 75;
            }

            for (int i = 0; i < _RectPoints.Length; i++)
            {
                x = r.Next(10, 70);
                y = 20;
                z = 20;

                // Create points for curve.
                Rectangle a = new Rectangle(w, x, y, z);
                graphics.FillRectangle(BrushBackColor, a);

                w += 25;

                _RectPoints[i] = a;
            }

            //need array
            graphics.DrawRectangles(OverLay, _RectPoints);

            Response.ContentType = "image/jpeg";
            bitmap.Save(Response.OutputStream, ImageFormat.Jpeg);

            GC.Collect();
        }
    }
}