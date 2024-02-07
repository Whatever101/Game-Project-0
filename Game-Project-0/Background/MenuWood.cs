using Game_Project_0.Collisions;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using SharpDX.Direct3D9;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Project_0.Background
{
    /// <summary>
    /// This class represents the wooden background menu. 
    /// </summary>
    public class MenuWood
    {
        private Texture2D _texture;
        private Vector2 _position = new Vector2(74, 48);
        private BoundingRectangle bounds = new BoundingRectangle(new Vector2(133, 52), 518, 373);
        public BoundingRectangle Bounds => bounds;
        public Color Shade = Color.White;
        public void LoadContent(ContentManager content)
        {
            _texture = content.Load<Texture2D>("menuwood");
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(_texture, _position, null, Shade, 0, new Vector2(8, 0), 1f, SpriteEffects.None, 1);
        }
    }
}
