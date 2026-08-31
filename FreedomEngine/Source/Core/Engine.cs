using FreedomEngine.Funkin;
using FreedomEngine.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace FreedomEngine.Core
{
    public class Engine
    {
        public Renderer renderer;
        public Assets assets;

        public Engine(ContentManager content, GraphicsDeviceManager graphics)
        {
            renderer = new Renderer(content, graphics);
        }

        public void Initialize()
        {
            //TODO: shit
        }

        Texture2D bgTexture;

        public void LoadContent(GraphicsDevice graphicsDevice)
        {
            renderer.LoadContent();
            assets = new Assets(graphicsDevice);

            GameStateManager.Instance.AddState(new MainMenuState(renderer, assets));

            //bgTexture = assets.Image("menus/menuBG");
        }

        public void Update(GameTime gameTime)
        {
            //TODO: shit

            GameStateManager.Instance.Update((float)gameTime.ElapsedGameTime.TotalMilliseconds);
        }

        public void Draw(GameTime gameTime)
        {
            //TODO: shit

            GameStateManager.Instance.Draw();

            //renderer.DrawTexture(bgTexture, new Vector2(0, 0));
        }
    }
}
