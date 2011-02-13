namespace Pong
{
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Content;
    using Microsoft.Xna.Framework.Graphics;
    using System;

    public class Bat
    {
        private Vector2 position;
        private float moveSpeed;
        private Rectangle size;
        private int points;
        private int yHeight;
        private Texture2D texture;

        public Bat(ContentManager content, Vector2 screenSize, bool side)
        {
            moveSpeed = 6f;
            points = 0;
            texture = content.Load<Texture2D>("bat");
            size = new Rectangle(0, 0, texture.Width, texture.Height);
            if (side) position = new Vector2(30, screenSize.Y / 2 - size.Height / 2);
            else position = new Vector2(screenSize.X - 30, screenSize.Y / 2 - size.Height / 2);
            yHeight = (int)screenSize.Y;
        }

        public void IncreaseSpeed()
        {
            moveSpeed += 0.6f;
        }

        public Rectangle GetSize()
        {
            return size;
        }

        public void IncrementPoints()
        {
            points++;
        }

        public int GetPoints()
        {
            return points;
        }

        private void SetPosition(Vector2 position)
        {
            if (position.Y < 0)
            {
                position.Y = 0;
            }
            if (position.Y > yHeight - size.Height)
            {
                position.Y = yHeight - size.Height;
            }
            this.position = position;
        }

        public Vector2 GetPosition()
        {
            return position;
        }

        public void MoveUp()
        {
            SetPosition(position + new Vector2(0, -moveSpeed));
        }

        public void MoveDown()
        {
            SetPosition(position + new Vector2(0, moveSpeed));
        }

        public virtual void UpdatePosition(Ball ball)
        {
            size.X = (int)position.X;
            size.Y = (int)position.Y;
        }

        public void ResetPosition()
        {
            SetPosition(new Vector2(GetPosition().X, yHeight / 2 - size.Height));
        }

        public void Draw(SpriteBatch batch)
        {
            batch.Draw(texture, position, Color.White);
        }
    }
}
