using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CharmedPointer
{
    /// <summary>
    /// 画像（チャーム）を表すクラス
    /// </summary>
    public class Charm
    {
        public Image Image;
        public Size Size;
        public Point Origin;
        public int Opacity;

        public Charm()
        {
            Image = null;
            Size = new Size();
            Origin = new Point();
            Opacity = 100;
        }

        public Charm(Image image)
        {
            Image = image;
            Size = new Size(image.Width, image.Height);
            Origin = new Point(Size.Width / 2, Size.Height / 2);
            Opacity = 100;
        }
    }

    public class ListViewCharmItem : ListViewItem
    {
        public Charm Charm;

        public ListViewCharmItem(string name, Image image, int imageIndex)
        {
            Charm = new Charm(image);

            Text = name;
            ImageIndex = imageIndex;
        }
    }


}
