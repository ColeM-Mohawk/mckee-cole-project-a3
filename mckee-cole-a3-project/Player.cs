using System;
using System.Numerics;

namespace MohawkGame2D
{
    public class Player
    {
        public Vector2 input = Vector2.Zero;

        public void GetPlayerInput()
        {
            if (Input.IsKeyboardKeyDown(KeyboardInput.Up) || Input.IsKeyboardKeyDown(KeyboardInput.W))
            {
                input.Y -= 1;
            }

            if (Input.IsKeyboardKeyDown(KeyboardInput.Down) || Input.IsKeyboardKeyDown(KeyboardInput.S))
            {
                input.Y += 1;
            }

            if (Input.IsKeyboardKeyDown(KeyboardInput.Left) || Input.IsKeyboardKeyDown(KeyboardInput.A))
            {
                input.X -= 1;
            }

            if (Input.IsKeyboardKeyDown(KeyboardInput.Right) || Input.IsKeyboardKeyDown(KeyboardInput.D))
            {
                input.X += 1;
            }
        }
    }
}
