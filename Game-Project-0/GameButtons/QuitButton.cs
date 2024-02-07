using Game_Project_0.Collisions;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Project_0.GameButtons
{
    /// <summary>
    /// A class that represents the menu buttons.
    /// </summary>
    public class QuitButton
    {
        private BoundingRectangle bounds = new BoundingRectangle(new Vector2(305-19.0625f, 240), 92*2.3f, 31 * 2.3f);
        private Texture2D _texture;
        private Vector2 _position = new Vector2(305, 240);

        /// <summary>
        /// The bounding rectangle of the QuitButton
        /// </summary>
        public BoundingRectangle Bounds => bounds;
        public Color Shade = Color.White;
        public bool InitialClick = false;


        public void LoadContent(ContentManager content)
        {
            _texture = content.Load<Texture2D>("woodgui");
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(_texture, _position, new Rectangle(130, 545, 92, 31), Shade, 0, new Vector2(8, 0), 2.3f, SpriteEffects.None, 1);
        }
    }
}
