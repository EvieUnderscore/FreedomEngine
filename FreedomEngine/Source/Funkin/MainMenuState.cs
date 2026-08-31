using Microsoft.Xna.Framework;

using FreedomEngine.Core;
using FreedomEngine.Graphics;
using FreedomEngine.Objects;
using System;

namespace FreedomEngine.Funkin
{
    internal class MainMenuState : GameState
    {

        public MainMenuState(Renderer renderer, Assets assets) : base(renderer, assets)
        {
        }

        public Sprite2D bg;

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
