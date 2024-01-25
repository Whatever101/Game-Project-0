using Game_Project_0.Background;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Game_Project_0
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;


        private SkySprite _sky;
        private NorthernLightSprite _northernLight;
        private StarSprite[] _stars = new StarSprite[7];
        private MenuWood _wood;
        private GameButtons _buttons;
        private SpriteFont _arial;



        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {

            // TODO: Add your initialization logic here
            _sky = new SkySprite();
            _northernLight = new NorthernLightSprite();
            for (int i = 0; i < 7; i++)
            {
                _stars[i] = new StarSprite();
            }

            _buttons = new GameButtons();
            _wood = new MenuWood();


            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            _sky.LoadContent(Content);
            _northernLight.LoadContent(Content);
            for (int i = 0; i < 7; i++)
            { _stars[i].LoadContent(Content); }


            _wood.LoadContent(Content);



            _buttons.LoadContent(Content);
            _arial = Content.Load<SpriteFont>("arial");
            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            for (int i = 0; i < 7; i++)
            { _stars[i].Update(gameTime); }
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Transparent);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();
            _sky.Draw(_spriteBatch);
            _northernLight.Draw(_spriteBatch);


            for (int i = 0; i < 7; i++)
            {
                _stars[i].Draw(gameTime, _spriteBatch);
            }



            _wood.Draw(_spriteBatch, new Vector2(74, 48));

            _buttons.Draw(_spriteBatch);
            _spriteBatch.DrawString(_arial, "v1.0", new Vector2(0, 0), Color.White);
            _spriteBatch.DrawString(_arial, "Press ESC to quit game.", new Vector2(0, 18), Color.White);
            _spriteBatch.DrawString(_arial, "Button Functionality will be added.", new Vector2(0, 36), Color.White);



            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}