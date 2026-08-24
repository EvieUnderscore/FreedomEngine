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

            base.Initialize();
        }


        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }

        public override void Destroy()
        {
            base.Destroy();
        }

        public override void Draw()
        {
            base.Draw();
        }
    }
}
