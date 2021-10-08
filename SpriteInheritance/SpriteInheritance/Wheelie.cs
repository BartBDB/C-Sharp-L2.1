using System.Drawing;

namespace Eindopdracht
{
    class Wheelie : Sprite
    {

        public Wheelie(RectangleF screenPosition)
        {
            this.screenPosition = screenPosition;
            imageFrame = new Rectangle(95, 259, 16, 16);
        }
    }
}



