using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using StardewValley;
using StardewValley.Menus;

namespace MermaidIsland.UI
{
    public class BundleMenu : IClickableMenu
    {
        static readonly int UIWidth = 632;
        static readonly int UIHeight = 600;
        static readonly int XPos = (int)(Game1.viewport.Width * Game1.options.zoomLevel * (1 / Game1.options.uiScale)) / 2 - UIWidth / 2;
        static readonly int YPos = (int)(Game1.viewport.Height * Game1.options.zoomLevel * (1 / Game1.options.uiScale)) / 2 - UIHeight / 2;

        readonly ClickableComponent TitleLabel;

        public BundleMenu(string bundle)
        {
            initialize(XPos, YPos, UIWidth, UIHeight);

            TitleLabel = new ClickableComponent(new Rectangle(XPos + 200, YPos + 96, UIWidth - 400, 64), bundle);
        }

        public override void receiveLeftClick(int x, int y, bool playSound = true)
        {
            if (TitleLabel.containsPoint(x, y))
            {
                // handle user clicking on the title. More practical use-case would be with buttons
            }
        }

        public override void draw(SpriteBatch b)
        {
            //draw screen fade
            b.Draw(Game1.fadeToBlackRect, Game1.graphics.GraphicsDevice.Viewport.Bounds, Color.Black * 0.75f);

            // draw menu dialogue box
            Game1.drawDialogueBox(XPos, YPos, UIWidth, UIHeight, false, true);

            // draw the TitleLabel
            Utility.drawTextWithShadow(b, TitleLabel.name, Game1.dialogueFont, new Vector2(TitleLabel.bounds.X, TitleLabel.bounds.Y), Color.Black);

            // draw cursor at last
            drawMouse(b);
        }
    }
}