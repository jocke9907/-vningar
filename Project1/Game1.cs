using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic; //Behövs för att använda listor

namespace Project1
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch;
        Texture2D boll;
        Vector2 pos1 = Vector2.Zero;
        Vector2 pos2 = new Vector2(100, 100);
        Texture2D tex;
        //Vector2 posA;
        //Vector2 posB;
        //Vector2 posC;
        int stopX;
        int stopY;
        
        List<Vector2> posList; //Deklarerar en lista åt mina pos
        //Ghost ghost;

        List<Ghost> ghostlist;
        Random rnd;





        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
            
            
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        protected override void LoadContent()
        {
            Texture2D tex = Content.Load<Texture2D>("mau_logo_trans");
            stopX = Window.ClientBounds.X - tex.Width;
            stopY = Window.ClientBounds.Y - tex.Height;
            spriteBatch = new SpriteBatch(GraphicsDevice);
            rnd=new Random();
            ghostlist = new List<Ghost>();
            for (int i = 0; i < 100; i++) // hur många man ska spawna. nu spawnar den 100 logor
            {
                
                int randX = rnd.Next(0, stopX);
                int randY = rnd.Next(0, stopY);
                Vector2 pos = new Vector2(randX, randY);
                Ghost ghost1 = new Ghost(tex, pos, stopX, stopY);
                ghostlist.Add(ghost1);
            }



            
















            
                
                //Vector2 pos1 = Vector2.Zero;

                //ghost = new Ghost(mauTranstex, pos1, stopX, stopY);
                //posList = new List<Vector2>();
                //boll = Content.Load<Texture2D>(@"ball");


                //pos2.X = Window.ClientBounds.Width / 2 - mauTranstex.Width / 2;
                //pos2.Y = Window.ClientBounds.Height / 2 - mauTranstex.Height / 2;
                //stopX = Window.ClientBounds.Width - mauTranstex.Width;
                //stopY= Window.ClientBounds.Height - mauTranstex.Height;
                //for (int i = 0; i < 3; i++)
                //{
                //    int randX = rnd.Next(0,stopX);
                //    int randY = rnd.Next(0, stopX);
                //    Vector2 pos = new Vector2(randX,randY);
                //    posList.Add(pos);
                //}




                //int randX = rnd.Next(0, stopX);
                //int randY = rnd.Next(0,stopY);
                //posA = new Vector2(randX,randY);

                //randX = rnd.Next(0,stopX);
                //randY = rnd.Next(0, stopY);
                //posB = new Vector2(randX, randY);

                //randX=rnd.Next(0,stopX);
                //randY=rnd.Next(0,stopY);
                //posC = new Vector2(randX,randY);

                //mauTranstex=Content.Load<Texture2D>
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            foreach (Ghost ghost in ghostlist)
            {
                ghost.Update();
            }

            // pos1.X = pos1.X + 3;
            ////pos2.X = pos2.X + 1;
            ////pos2.Y = pos2.Y + 1;

            //int stopX = Window.ClientBounds.Width - mauTranstex.Width;
            //int stopY=Window.ClientBounds.Height - mauTranstex.Height;

            //if (pos1.X< stopX)
            //{
            //    pos1.X = pos1.X + 2;
            //}
            //if (pos2.Y< stopY)
            //{
            //    pos2.X=pos2.X + 2;
            //    pos2.Y=pos2.Y + 2;
            //}

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {

            GraphicsDevice.Clear(Color.CornflowerBlue);
            spriteBatch.Begin();
            foreach (Ghost ghost in ghostlist)
            {
                ghost.Draw(spriteBatch);
            }

            
            
            
            //spriteBatch.Draw(boll, pos1, null, Color.White, 0f, Vector2.Zero, 1f, SpriteEffects.FlipHorizontally, 0f);
            //spriteBatch.Draw(mauTranstex, pos2, Color.White);
            
            //spriteBatch.Draw(mauTranstex, posA, Color.White);
            //spriteBatch.Draw(mauTranstex, posB, Color.Lavender);
            //spriteBatch.Draw(mauTranstex, posC, Color.Salmon);
            //foreach (var pos in posList)
            //{
            //    spriteBatch.Draw(mauTranstex, pos, Color.WhiteSmoke);
               

            //}
            

            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
} //Hej