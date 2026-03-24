// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        // Place your variables here:
        Vector2 position;

        float secondsElapsed = Time.SecondsElapsed;

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("Holder");
            Window.SetSize(800, 600);


        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(Color.OffWhite);


            

            position += Vector2.Zero * 100 * Time.DeltaTime;

            Draw.FillColor = Color.Red;
            Draw.LineColor = Color.Black;
            Draw.Square(100, 800, 80);
           
        }
    }

}
