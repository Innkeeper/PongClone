namespace Pong
{
    using System;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Content;

    public class AIBat : Bat
    {
        public AIBat(ContentManager content, Vector2 screenSize, bool side) : base(content, screenSize, side)
        {
        }

        public override void UpdatePosition(Ball ball)
        {
            if (ball.GetDirection() > 1.5 * Math.PI || ball.GetDirection() < 0.5 * Math.PI)
            {
                if (ball.GetPosition().Y - 5 > GetPosition().Y + GetSize().Height / 2)
                {
                    MoveDown();
                }
                else if (ball.GetPosition().Y == GetPosition().Y + GetSize().Height / 2)
                {
                }
                else if (ball.GetPosition().Y + 5 < GetPosition().Y + GetSize().Height / 2)
                {
                    MoveUp();
                }
            }
            base.UpdatePosition(ball);
        }
    }
}
