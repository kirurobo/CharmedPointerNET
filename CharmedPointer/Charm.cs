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
        public Size Size;
        public Point Origin;
        public int Opacity;
        public int ImageIndex;
    }

    public class ListViewCharmItem : ListViewItem
    {
        public Charm Charm;

        public ListViewCharmItem(string name, Image image, int imageIndex)
        {
            Charm = new Charm();

            Text = name;
            ImageIndex = imageIndex;
            Charm.ImageIndex = imageIndex;
            Charm.Size = new Size(image.Width, image.Height);
            Charm.Origin = new Point(Charm.Size.Width / 2, Charm.Size.Height / 2);
            Charm.Opacity = 100;
        }
    }


}
