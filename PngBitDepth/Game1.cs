using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace PngBitDepth
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        private GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch;
        private Texture2D eightBitsPerPixelTexture;
        private Texture2D sixteenBitsPerPixelTexture;


        public Game1()
        {
            this.graphics = new GraphicsDeviceManager(this);
            this.Content.RootDirectory = "Content";
        }        

        protected override void LoadContent()
        {
            this.spriteBatch = new SpriteBatch(this.GraphicsDevice);
            this.eightBitsPerPixelTexture = this.Content.Load<Texture2D>("8bitpp");
            this.sixteenBitsPerPixelTexture = this.Content.Load<Texture2D>("16bitpp");
        }

        protected override void Draw(GameTime gameTime)
        {
            this.GraphicsDevice.Clear(Color.CornflowerBlue);

            this.spriteBatch.Begin();

            this.spriteBatch.Draw(this.eightBitsPerPixelTexture, new Rectangle(16, 16, 256, 256), null, Color.White);
            this.spriteBatch.Draw(this.sixteenBitsPerPixelTexture, new Rectangle(16 + 16 + 256, 16, 256, 256), null, Color.White);

            this.spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
