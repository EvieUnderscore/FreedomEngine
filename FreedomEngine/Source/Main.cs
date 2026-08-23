using FreedomEngine.Core;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace FreedomEngine
{
    public class Main : Game
    {
        public GraphicsDeviceManager graphics;
        private Engine engine;

        //I LOVE HELPER FUNCTIONS I LOVE HELPER FUNCTIONS I LOVE HELPER FUNCTIONS I LOVE
        public void CenterWindow()
        {
            Window.Position = new Point(
                (GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Width / 2) - (graphics.PreferredBackBufferWidth / 2),
                (GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height / 2) - (graphics.PreferredBackBufferHeight / 2)
            );
        }

        public Main()
        {
            graphics = new GraphicsDeviceManager(this);

            graphics.PreferredBackBufferWidth = 1280;
            graphics.PreferredBackBufferHeight = 720;

            Content.RootDirectory = "Content";
            IsMouseVisible = true;

            engine = new Engine(Content, graphics);
        }

        protected override void Initialize()
        {
            CenterWindow();

            engine.Initialize();

            base.Initialize();
        }

        protected override void LoadContent()
        {
            engine.LoadContent(graphics.GraphicsDevice);
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            engine.Update(gameTime);

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.DarkSlateGray);

            engine.Draw(gameTime);

            base.Draw(gameTime);
        }
    }
}
