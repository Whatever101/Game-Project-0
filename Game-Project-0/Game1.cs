using Game_Project_0.Background;
using Game_Project_0.GameButtons;
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
        private StartButton _startButton;
        private QuitButton _quitButton;

        private SpriteFont _arial;
        private InputManager _inputManager;

        MouseState currentMouseState;
        MouseState priorMouseState;



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

            _startButton = new StartButton();
            _quitButton = new QuitButton();
            _inputManager = new InputManager();
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



            _startButton.LoadContent(Content);
            _quitButton.LoadContent(Content);
            _arial = Content.Load<SpriteFont>("arial");
            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            _inputManager.Update(gameTime);

            if (_inputManager.Exit == true)
            { Exit(); }
            // TODO: Add your update logic here

            //balls[2].Position += _inputManager.Direction;
            if (_quitButton.Bounds.CollidesWith(_inputManager.Cursor) && _inputManager.Clicked)
                _quitButton.InitialClick = true;

            if (_quitButton.Bounds.CollidesWith(_inputManager.Cursor) && _quitButton.InitialClick)
            {
                if (_inputManager.Clicking)
                {
                    _quitButton.Shade = Color.DarkGray;

                }
                else
                {
                    _quitButton.Shade = Color.White;
                }
                if (_inputManager.CurrentMouseState.LeftButton == ButtonState.Released)
                {
                    _quitButton.InitialClick = false;
                    Exit();
                }
            }
            else
            {
                if (_inputManager.CurrentMouseState.LeftButton == ButtonState.Released)
                {
                    _quitButton.InitialClick = false;
                }
                _quitButton.Shade = Color.White;
            }

            if (_startButton.Bounds.CollidesWith(_inputManager.Cursor) && _inputManager.Clicked)
                _startButton.InitialClick = true;

            if (_startButton.Bounds.CollidesWith(_inputManager.Cursor) && _startButton.InitialClick)
            {
                if (_inputManager.Clicking)
                {
                    _startButton.Shade = Color.DarkGray;

                }
                else
                {
                    _startButton.Shade = Color.White;
                }
                if (_inputManager.CurrentMouseState.LeftButton == ButtonState.Released)
                {
                    _startButton.InitialClick = false;
                }

            }
            else
            {
                if (_inputManager.CurrentMouseState.LeftButton == ButtonState.Released)
                {
                    _startButton.InitialClick = false;
                }
                _startButton.Shade = Color.White;
            }

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

            _startButton.Draw(_spriteBatch);

            _quitButton.Draw(_spriteBatch);
            _spriteBatch.DrawString(_arial, "v1.0", new Vector2(0, 0), Color.White);
            _spriteBatch.DrawString(_arial, "Press Quit button using Left-Click on the Mouse or press ESC to quit game.", new Vector2(0, 18), Color.White);
            //_spriteBatch.DrawString(_arial, "Button Functionality will be added.", new Vector2(0, 36), Color.White);



            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}