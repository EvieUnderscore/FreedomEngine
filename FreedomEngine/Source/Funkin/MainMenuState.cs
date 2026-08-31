using Microsoft.Xna.Framework;

using FreedomEngine.Core;
using FreedomEngine.Graphics;
using FreedomEngine.Objects;
using System;

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
            Add(bg);

            base.Initialize();
        }


        public float et = 0;
        public override void Update(float delta)
        {
            et += delta;
            bg.transform.position.X = MathF.Sin(et/200)*10;

            base.Update(delta);
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
