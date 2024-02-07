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
    public class StartButton
    {

        private Texture2D _texture;

        private BoundingRectangle bounds => new BoundingRectangle(new Vector2(293-18.3125f, 160), 101 * 2.3f, 31 * 2.3f);
        private Vector2 _position => new Vector2(293, 160);
        public Color Shade = Color.White;
        public bool InitialClick = false;


        /// <summary>
        /// The bounding rectangle of the StartButton
        /// </summary>
        public BoundingRectangle Bounds => bounds;

        public void LoadContent(ContentManager content)
        {
            _texture = content.Load<Texture2D>("woodgui");
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(_texture, _position, new Rectangle(123, 1128, 101, 31), Shade, 0, new Vector2(8, 0), 2.3f, SpriteEffects.None, 1);

        }
    }

}
