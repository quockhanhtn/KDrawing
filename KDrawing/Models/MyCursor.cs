using System.Drawing;
using System.Windows.Forms;

namespace KDrawing.Models
{
    public class MyCursor
    {
        private static MyCursor instance;
        public static MyCursor Instance 
        { 
            get 
            {
                if (instance == null) { instance = new MyCursor(); }
                return instance; 
            } 
            set => instance = value; 
        }
        public Cursor Cross { get; set; }
        public Cursor SizeAll { get; set; }
        public Cursor Pencil { get; set; }
        private MyCursor() 
        {
            Cross = CreateCurson(Properties.Resources.cursor_cross, 30, 30);
            SizeAll = CreateCurson(Properties.Resources.cursor_size_all, 30, 30);
            Pencil = CreateCurson(Properties.Resources.cursor_lead_pencil_black, 30, 30);
        }

        Cursor CreateCurson(Bitmap bitmap, int width, int height)
        {
            bitmap = new Bitmap(bitmap, new Size(width, height));
            return new Cursor(bitmap.GetHicon());
        }
    }
}
