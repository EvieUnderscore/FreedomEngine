using Microsoft.Xna.Framework;

using FreedomEngine.Math;
using Microsoft.Xna.Framework.Graphics;
using FreedomEngine.Graphics;

namespace FreedomEngine.Objects
{
    public class Sprite2D : GameObject2D
    {
        public Sprite2D(Transform2D transform = null) : base(transform)
        {
            System.Diagnostics.Debug.WriteLine("Mywifee ");
        }

        public Texture2D texture;
        public Color color = Color.White;

        public void LoadTexture(Texture2D texture)
        {
            this.texture = texture;
        }

        public override void Draw(Renderer renderer)
        {
            renderer.DrawSprite2D(this);

            base.Draw(renderer);
        }
    }
}
