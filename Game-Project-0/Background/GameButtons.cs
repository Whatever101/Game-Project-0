using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Project_0.Background
{
    /// <summary>
    /// A class that represents the menu buttons.
    /// </summary>
    public class GameButtons
    {

        private Texture2D _texture;

        public void LoadContent(ContentManager content)
        {
            _texture = content.Load<Texture2D>("woodgui");
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(_texture, new Vector2(305,240), new Rectangle(130,545, 92, 31), Color.White, 0, new Vector2(8, 0), 2.3f, SpriteEffects.None, 1);
            spriteBatch.Draw(_texture, new Vector2(293, 160), new Rectangle(123, 1128, 101, 31), Color.White, 0, new Vector2(8, 0), 2.3f, SpriteEffects.None, 1);

        }
    }
}
