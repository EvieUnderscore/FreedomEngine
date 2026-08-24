using Microsoft.Xna.Framework;

using FreedomEngine.Core;
using FreedomEngine.Graphics;
using FreedomEngine.Objects;
using FreedomEngine.Math;

namespace FreedomEngine.Funkin
{
    internal class MainMenuState : GameState
    {

        public Sprite2D bg;

        public MainMenuState(Renderer renderer, Assets assets) : base(renderer, assets)
        {
        }

        public override void Initialize()
        {
            bg = new Sprite2D();
            bg.LoadTexture(assets.Image("menus/menuBG"));
            bg.transform.position.X = 200;
            Add(bg);
        }


        public override void Update(GameTime gameTime)
        {
            bg.Update(gameTime);
        }

        public override void Destroy()
        {

        }

        public override void Draw()
        {
            foreach (IGameObject obj in objects)
            {
                obj.Draw(renderer);
            }
        }
    }
}
