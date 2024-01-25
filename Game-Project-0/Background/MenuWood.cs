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

        public void LoadContent(ContentManager content)
        {
            _texture = content.Load<Texture2D>("menuwood");
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 vector2)
        {
            var source = new Rectangle(450, 642, 93, 93);

            spriteBatch.Draw(_texture, vector2, null, Color.White, 0, new Vector2(8, 0), 1f, SpriteEffects.None, 1);
        }
    }
}
