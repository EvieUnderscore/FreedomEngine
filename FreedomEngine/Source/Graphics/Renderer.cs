using FreedomEngine.Objects;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace FreedomEngine.Graphics
{
    public class Renderer
    {
        private ContentManager content;
        private GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch;

        public Renderer(ContentManager content, GraphicsDeviceManager graphics)
        {
            this.content = content;
            this.graphics = graphics;
        }
        public void LoadContent()
        {
            spriteBatch = new SpriteBatch(graphics.GraphicsDevice);
        }

        public void DrawTexture(Texture2D texture, Vector2 position)
        {
            spriteBatch.Begin(SpriteSortMode.Deferred, BlendState.AlphaBlend);

            spriteBatch.Draw(texture, position, Color.White);

            spriteBatch.End();
        }

        public void DrawSprite2D(Sprite2D sprite)
        {
            spriteBatch.Begin(SpriteSortMode.Deferred, BlendState.AlphaBlend);

            spriteBatch.Draw(sprite.texture, sprite.transform.position, sprite.color);

            spriteBatch.End();
        }

    }
}
