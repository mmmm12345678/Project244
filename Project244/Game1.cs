﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using Microsoft.Xna.Framework.Audio;
using System;
using System.IO;
using System.Threading;

namespace Project244
{
    public class Game1 : Game
    {


        //Save score
        static string[] SaveScore;
        static string filnamnSC = "Save_Score.txt";
        static string startSave = "0";
        static int Hur_många = 20;

        //High Score
        static int High_Score;

        // musik
        static SoundEffect musik;
        static SoundEffect boom2;
        static SoundEffectInstance soundEffectInstance ;

        static GraphicsDeviceManager _graphics;
        static SpriteBatch _spriteBatch;
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        static Texture2D zebra;
        static Rectangle zebra2;
        static Rectangle zebra3;


        static Texture2D clouds1;
        static Rectangle clouds1XY;
        static Texture2D clouds2;
        static Rectangle clouds2XY;
        static Texture2D clouds3;
        static Rectangle clouds3XY;
        static Texture2D clouds4;
        static Rectangle clouds4XY;
        static Texture2D clouds5;
        static Rectangle clouds5XY;

        static bool scoreett = true;

        //Menu
        static Texture2D button;
        static bool button2 = false;
        static bool button22 = false;
        static bool buttonStart2 = false;
        static MouseState UpButtontMou = new MouseState();
        static MouseState UpButtontMou2 = new MouseState();

        // X Y button
        static Rectangle buttonXY;

        //Play Games
        static Texture2D PlayGame;
        static Rectangle PlayGameXY;
        static bool PlayGameBoll = false;
        static bool Play = false;
        static bool Play2 = false;

        static bool PlayAnima = false;

        static int PlayAnimaTime = 35;



        //GameOver
        
        static Texture2D GameOver;
        static Rectangle GameOverXY;
        static bool GameOverBoll = false;


        static Texture2D GameOverScore;
        static Rectangle GameOverScoreXY;


        static Texture2D GameOverStartGame;
        static Rectangle GameOverStartGameXY;


        //Animatiom bird
        static Texture2D bird1;
        static Texture2D bird2;
        static Texture2D bird3;
        static bool Anima1 = true;
        static bool Anima2 = false;
        static bool Anima3 = false;
        static int TmerAni;
        static int tmerbird = 5;

        static int TmerAni2 = 20 ;

        // X Y bird
        static Rectangle birdXY;

        // map tube
        static Texture2D tube;
        static Rectangle tubeXY;
        static Rectangle tubeXY2;
        static bool tune2 = false;
        static bool tubeplay = false;

        static Texture2D tubedan;
        static Rectangle tubedanXY;
        static Rectangle tubedanXY2;

        static int tubeYLength = 380;
        static int tubedanY = -140;

        static int tubeYLength2 = 170;
        static int tubedanY2 = -350;




        //game play
        static KeyboardState oldState;
        static KeyboardState oldStateF11;
        static KeyboardState oldStateLF11;
        static int TmerGravity;
        static bool AnimationJump = false;
        static bool FallGravity;
        static int TimeGravity;

        // back Ground
        static Texture2D BackGround;
        static Rectangle BackGroundXY;
        static Texture2D BackGround3;
        static Rectangle BackGroundXY3;
        static Rectangle BackGroundXY32;
        static Rectangle BackGroundXY322;

        //back Ground Animation
        static Texture2D BackGround2;
        static Rectangle BackGroundXY2;
        static Rectangle BackGroundXY22;
        static Texture2D GroundGrass;
        static Rectangle GroundGrass2;
        static Rectangle GroundGrass22;


        //TEXT Score
        static SpriteFont TextScore;
        static string TextScoreNumber;
        static Vector2 TextScoreXY = new Vector2(20, 20);
        //TEXT High Score 
        static SpriteFont TextScore2;
        
        static string TextScoreNumber2 = "0";
        static Vector2 TextScore2XY = new Vector2(250, 200);

        static SpriteFont TextScore3;
        static Vector2 TextScore22XY = new Vector2(550, 280);

        //FullScreen
        static int ScreenWidth;
        static int ScreenHeight;
        static bool Screen = true;
        static bool Screen2 = true;
        static bool ScreenHikbox = false;
        static int ScreenInet;

        static double Preferred_Width;
        static double Preferred_Height;

        static float bird_X;
        static float bird_Y;
        static double bird_Width;
        static double bird_Height;

        static float button_X;
        static float button_Y;
        static double button_Width;
        static double button_Height;

        static double button_WidthBig;
        static double button_HeightBig;



        static float GroundGrass_X;
        static float GroundGrass_Y;
        static double GroundGrass_Width;
        static double GroundGrass_Height;

        static float GroundGrass2_X;
        static float GroundGrass2_Y;
        static double GroundGrass2_Width;
        static double GroundGrass2_Height;


        static float zebra2_X;
        static float zebra2_Y;
        static double zebra2_Width;
        static double zebra2_Height;

        static float zebra3_X;
        static float zebra3_Y;
        static double zebra3_Width;
        static double zebra3_Height;


        static float tubeXY_X;
        static float tubeXY_Y;
        static double tubeXY_Width;
        static double tubeXY_Height;

        static float tubeXY2_X;
        static float tubeXY2_Y;
        static double tubeXY2_Width;
        static double tubeXY2_Height;

        static float tubedanXY_X;
        static float tubedanXY_Y;
        static double tubedanXY_Width;
        static double tubedanXY_Height;

        static float tubedanXY2_X;
        static float tubedanXY2_Y;
        static double tubedanXY2_Width;
        static double tubedanXY2_Height;



        static float BackGroundXY_X;
        static float BackGroundXY_Y;
        static double BackGroundXY_Width;
        static double BackGroundXY_Height;

        static float BackGroundXY3_X;
        static float BackGroundXY3_Y;
        static double BackGroundXY3_Width;
        static double BackGroundXY3_Height;


        static float PlayGame_X;
        static float PlayGame_Y;
        static double PlayGame_Width;
        static double PlayGame_Height;

        static float BackGroundXY2_X;
        static float BackGroundXY2_Y;
        static double BackGroundXY2_Width;
        static double BackGroundXY2_Height;

        static float BackGroundXY22_X;
        static float BackGroundXY22_Y;
        static double BackGroundXY22_Width;
        static double BackGroundXY22_Height;

        // back ground delet
        static double Back_Ground_Delete_Save = -800;
        static double Back_Ground_Delete;

        // back ground Raspond
        static double Back_Ground_Raspond_Save = 785;
        static double Back_Ground_Raspond;

        // back ground Speed
        static double Back_Ground_Speed_Save = 3;
        static double Back_Ground_Speed;


        //points
        static double points_Delete_Save = -120;
        static double points_Delete;

        //points zoom y

        static double points_zoom_Save = 100;
        static double points_zoom;


        //  tubeXY deletw
        static double tubeXY_Delete_Save = -120;
        static double tubeXY_Delete;


        // tubeXY Raspond
        static double tubeXY_Raspond_Save = 810;
        static double tubeXY_Raspond;

        // tubeXY Speed
        static double tubeXY_Speed_Save = 3;
        static double tubeXY_Speed;


        // tubeXY  random
        static double tubeXY_random_Save = -115;
        static double tubeXY_random;

        static bool tubeXY_randomTelerF;
        static double tubeXYwww_Save = 250;
        static double tubeXYwww;

        // birdxy.y

        static double birdY_Save = 13;
        static float birdY_Raspond;

        static double birdYJU_Save = 35;
        static float birdYJU_Raspond;

        // levl
        static double IF_levl = 10;
        static double levl = 0;

        // gar
        static double birdY = 0;
        static double tim = 2 ;

        //death
        static bool death = false;


        //Score
        static int score;
        static int scorexy;
        static int död = 40;



        //hiddem wall collect points
        static Rectangle HiddenWall;
        static Rectangle HiddenWall2;

        static Color parrotColor = Color.White;

        static MouseState mus = Mouse.GetState();

        public Game1()
        {
            if (File.Exists(filnamnSC))
            {
                SaveScore = File.ReadAllLines(filnamnSC);

            }
            else
            {
                SaveScore = new string[Hur_många];
                for (int i = 0; i < SaveScore.Length; i++)
                {
                    SaveScore[i] = startSave;
                }
                File.WriteAllLines(filnamnSC, SaveScore);
            }



            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            Window.AllowUserResizing = true;
            ScreenWidth = _graphics.GraphicsDevice.Viewport.Width;
            ScreenHeight = _graphics.GraphicsDevice.Viewport.Height;



            // _graphics.PreferredBackBufferWidth = 1920;
            // _graphics.PreferredBackBufferHeight = 1080;
            // _graphics.IsFullScreen = true;
            // _graphics.ApplyChanges();
            IsMouseVisible = true;



            base.Initialize();
        }

        protected override void LoadContent()
        {
            High_Score = SaveScore[0].Length;
            musik = Content.Load<SoundEffect>("musk/mustScore");
            boom2 = Content.Load<SoundEffect>("musk/bird");
            //soundEffectInstance = boom2.CreateInstance();

            spriteBatch = new SpriteBatch(GraphicsDevice);

            // hiddem wall points
            zebra = Content.Load<Texture2D>("zebra");
            zebra2 = new Rectangle(300, 170, 20, 100);
            zebra3 = new Rectangle(300, 170, 20, 100);



            // clouds //
            clouds1 = Content.Load<Texture2D>("clouds/clouds1");
            clouds1XY = new Rectangle(1500, 20, 100, 100);
            clouds2 = Content.Load<Texture2D>("clouds/clouds2");
            clouds2XY = new Rectangle(3000, 230, 100, 100);
            clouds3 = Content.Load<Texture2D>("clouds/clouds3");
            clouds3XY = new Rectangle(850, 260, 100, 100);
            clouds4 = Content.Load<Texture2D>("clouds/clouds4");
            clouds4XY = new Rectangle(2000, 100, 100, 100);
            clouds5 = Content.Load<Texture2D>("clouds/clouds5");
            clouds5XY = new Rectangle(1000, 50, 100, 100);

            // hiddem wall points  FullScreen
            zebra2_X = zebra2.X;
            zebra2_Y = zebra2.Y;
            zebra2_Width = zebra2.Width;
            zebra2_Height = zebra2.Height;

            zebra3_X = zebra3.X;
            zebra3_Y = zebra3.Y;
            zebra3_Width = zebra3.Width;
            zebra3_Height = zebra3.Height;


            button = Content.Load<Texture2D>("Play");
            buttonXY = new Rectangle(300, 120, 200, 200);

            PlayGame = Content.Load<Texture2D>("PlayGAMESO/playGame");
            PlayGameXY = new Rectangle(300, 120, 200, 200);


            PlayGame_X = PlayGameXY.X;
            PlayGame_Y = PlayGameXY.Y;
            PlayGame_Width = PlayGameXY.Width;
            PlayGame_Height = PlayGameXY.Height;




            //GameOver

            GameOver = Content.Load<Texture2D>("GameOver/GameOver");
            GameOverXY = new Rectangle(275, 30, 300, 200);

            GameOverScore = Content.Load<Texture2D>("GameOver/Score");
            GameOverScoreXY = new Rectangle(200, 250, 130, 100);

            GameOverStartGame = Content.Load<Texture2D>("GameOver/startgame");
            GameOverStartGameXY = new Rectangle(375, 250, 100, 100);



            //button FullScreen 
            button_X = buttonXY.X;
            button_Y = buttonXY.Y;
            button_Width = buttonXY.Width;
            button_Height = buttonXY.Height;

            //bird an1
            bird1 = Content.Load<Texture2D>("gaemsplay/bird1");
            bird2 = Content.Load<Texture2D>("gaemsplay/bird");
            bird3 = Content.Load<Texture2D>("gaemsplay/bird3");
            birdXY = new Rectangle(300, 100, 45, 45);

            // bird FullScreen 
            bird_X = birdXY.X;
            bird_Y = birdXY.Y;
            bird_Width = birdXY.Width;
            bird_Height = birdXY.Height;

            // 2,4 108
            // 2.25 101,25

            //enemy 1
            tube = Content.Load<Texture2D>("tube/tube");
            tubeXY = new Rectangle(810, tubeYLength, 67, 404);
            tubeXY2 = new Rectangle(810, tubeYLength2, 67, 404);

            tubeXY_X = tubeXY.X;
            tubeXY_Y = tubeXY.Y;
            tubeXY_Width = tubeXY.Width;
            tubeXY_Height = tubeXY.Height;

            tubeXY2_X = tubeXY2.X;
            tubeXY2_Y = tubeXY2.Y;
            tubeXY2_Width = tubeXY2.Width;
            tubeXY2_Height = tubeXY2.Height;

            tubedan = Content.Load<Texture2D>("tube/tubedan");
            tubedanXY = new Rectangle(810, tubedanY, 67, 404);
            tubedanXY2 = new Rectangle(810, tubedanY2, 67, 404);

            tubedanXY_X = tubedanXY.X;
            tubedanXY_Y = tubedanXY.Y;
            tubedanXY_Width = tubedanXY.Width;
            tubedanXY_Height = tubedanXY.Height;


            tubedanXY2_X = tubedanXY2.X;
            tubedanXY2_Y = tubedanXY2.Y;
            tubedanXY2_Width = tubedanXY2.Width;
            tubedanXY2_Height = tubedanXY2.Height;

            //Back Ground 
            BackGround = Content.Load<Texture2D>("BackGround/BackGround2");
            BackGroundXY = new Rectangle(0, 0, 800, 480);
            BackGround3 = Content.Load<Texture2D>("BackGround/BackGround");
            BackGroundXY3 = new Rectangle(0, 0, 800, 480);
            BackGroundXY32 = new Rectangle(800, 0, 800, 480);
            BackGroundXY322 = new Rectangle(1600, 0, 800, 480);



            BackGroundXY_X = BackGroundXY.X;
            BackGroundXY_Y = BackGroundXY.Y;
            BackGroundXY_Width = BackGroundXY.Width;
            BackGroundXY_Height = BackGroundXY.Height;

            BackGroundXY3_X = BackGroundXY3.X;
            BackGroundXY3_Y = BackGroundXY3.Y;
            BackGroundXY3_Width = BackGroundXY3.Width;
            BackGroundXY3_Height = BackGroundXY3.Height;

            //back Ground Animation 1
            BackGround2 = Content.Load<Texture2D>("BackGround/BackGround3");
            BackGroundXY2 = new Rectangle(0, 10, 830, 480);
            BackGroundXY22 = new Rectangle(785, 10, 830, 480);


            BackGroundXY2_X = BackGroundXY2.X;
            BackGroundXY2_Y = BackGroundXY2.Y;
            BackGroundXY2_Width = BackGroundXY2.Width;
            BackGroundXY2_Height = BackGroundXY2.Height;

            BackGroundXY22_X = BackGroundXY22.X;
            BackGroundXY22_Y = BackGroundXY22.Y;
            BackGroundXY22_Width = BackGroundXY22.Width;
            BackGroundXY22_Height = BackGroundXY22.Height;





            GroundGrass = Content.Load<Texture2D>("BackGround/groundgrass");
            GroundGrass2 = new Rectangle(0, 400, 830, 136);
            GroundGrass22 = new Rectangle(785, 400, 830, 136);

            //back Ground FullScreen
            GroundGrass_X = GroundGrass2.X;
            GroundGrass_Y = GroundGrass2.Y;
            GroundGrass_Width = GroundGrass2.Width;
            GroundGrass_Height = GroundGrass2.Height;

            GroundGrass2_X = GroundGrass22.X;
            GroundGrass2_Y = GroundGrass22.Y;
            GroundGrass2_Width = GroundGrass22.Width;
            GroundGrass2_Height = GroundGrass22.Height;



            //TEXT 
            TextScore = Content.Load<SpriteFont>("File");
            TextScore2 = Content.Load<SpriteFont>("HighScore");
            TextScore3 = Content.Load<SpriteFont>("Score");

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {

            High_Score = SaveScore[0].Length;
            // FullScreen 
            if ((ScreenWidth != _graphics.GraphicsDevice.Viewport.Width) || (ScreenHeight != _graphics.GraphicsDevice.Viewport.Height))
            {
                if (Screen == true)
                {
                    Screen1080();
                }

            }
            else if (Screen2 == true)
            {
                Screen400();
            }


            // tx
            if (Keyboard.GetState().IsKeyDown(Keys.Escape))
            {

                Exit();

            }


            if (IF_levl == score)
            {
                IF_levl += 5;
                levl += 0.5;


            }

            // F11 Fullscrren elle inte.
            KeyboardState kb2 = Keyboard.GetState();
            if (kb2.IsKeyDown(Keys.F11) && oldStateF11.IsKeyUp(Keys.F11) && _graphics.IsFullScreen == false)
            {

                _graphics.IsFullScreen = false;
                _graphics.PreferredBackBufferWidth = 1920;
                _graphics.PreferredBackBufferHeight = 1080;
                _graphics.ApplyChanges();

            }
            oldStateF11 = kb2;

            KeyboardState kb3 = Keyboard.GetState();
            if (kb3.IsKeyDown(Keys.F11) && oldStateLF11.IsKeyUp(Keys.F11) && _graphics.IsFullScreen == true)
            {
                _graphics.PreferredBackBufferWidth = ScreenWidth;
                _graphics.PreferredBackBufferHeight = ScreenHeight;
                _graphics.IsFullScreen = false;
                _graphics.ApplyChanges();
                Screen400();
            }

            oldStateLF11 = kb3;




            mus = Mouse.GetState();
            TextScoreNumber = "Score: ";
            TextScoreNumber += score.ToString();


            StartGameButton();

            if (buttonXY.Contains(mus.Position) == true && button2 == false && button22 == false)
            {
                parrotColor = Color.Green;
                buttonXY.Width = (int)button_WidthBig + 5;
                buttonXY.Height = (int)button_HeightBig + 5;

                MouseState currentStatemus = Mouse.GetState();
                if (mus.LeftButton == ButtonState.Pressed && UpButtontMou.LeftButton == ButtonState.Released)
                {
                    PlayGameBoll = true;
                    button2 = true;
                    tubeplay = true;
                    TmerAni = tmerbird;
                    TmerGravity = 5;
                    Play2 = true;
                }
                UpButtontMou = currentStatemus;
            }
            else
            {
                parrotColor = Color.White;
                buttonXY.Width = (int)button_WidthBig;
                buttonXY.Height = (int)button_HeightBig;
            }

            //Animation background
            if (GameOverBoll == false)
            {

                BackGroundXY2.X -= (int)(Back_Ground_Speed + levl);
                if (BackGroundXY2.X <= (int)Back_Ground_Delete)
                {
                    BackGroundXY2.X = (int)Back_Ground_Raspond;

                }
                BackGroundXY22.X -= (int)(Back_Ground_Speed + levl);
                if (BackGroundXY22.X <= (int)Back_Ground_Delete)
                {
                    BackGroundXY22.X = (int)Back_Ground_Raspond;
                }


            }



            // Animation groundgrass


            if (GameOverBoll == false)
            {


                GroundGrass2.X -= (int)(Back_Ground_Speed + levl);

                if (GroundGrass2.X <= (int)Back_Ground_Delete)
                {
                    GroundGrass2.X = (int)Back_Ground_Raspond;

                }

                GroundGrass22.X -= (int)(Back_Ground_Speed + levl);
                if (GroundGrass22.X <= (int)Back_Ground_Delete)
                {
                    GroundGrass22.X = (int)Back_Ground_Raspond;
                }

            }


            //score
            HiddenWall = tubeXY;
            HiddenWall2 = tubeXY2;

            if (tubeXY.X > (int)(points_Delete))
            {
                zebra2.Y = tubeXY.Y;
                zebra2.X = tubeXY.X + 34;
                zebra2.Y -= (int)(points_zoom);
            }
            if (tubeXY2.X > (int)(points_Delete))
            {
                zebra3.Y = tubeXY2.Y;
                zebra3.X = tubeXY2.X + 34;
                zebra3.Y -= (int)(points_zoom);
            }

            //map
            map();



            //Enemy
            if (tubeXY.Intersects(birdXY) || tubeXY2.Intersects(birdXY) || tubedanXY.Intersects(birdXY) || tubedanXY2.Intersects(birdXY) || GroundGrass2.Intersects(birdXY) || GroundGrass22.Intersects(birdXY))
            {
                död--;

                if (GameOverBoll == false)
                {

                 birdXY.X -= (int)(tubeXY_Speed + levl);
                 
                }



                if (död == 0)
                {
                    

                 GameOverBoll = true;
                    död = 40;
                }

                death = true;
                buttonStart2 = true;
                ScreenInet = Int32.Parse(TextScoreNumber2);
                if (score >= ScreenInet)
                {

                    SaveScore[0] = score.ToString();
                   
                    File.WriteAllLines(filnamnSC, SaveScore);



                }


            }

            // Collection score
            TextScoreNumber2 = SaveScore[0];



            if (zebra2.Intersects(birdXY) && ScreenHikbox == false || zebra3.Intersects(birdXY) && ScreenHikbox == false)
            {

                score++;
                ScreenHikbox = true;

            }
            else if (!zebra2.Intersects(birdXY) && !zebra3.Intersects(birdXY))
            {
                ScreenHikbox = false;
            }

            if (GameOverBoll == false)
            {
                clouds();

            }
          
            //random map
            random();
            random2();

            //games pay

            
            Gameplay();


            if (PlayGameBoll == true)
            {
             PlayAnimaTime--;
             if (PlayAnimaTime == 15)
             {
                PlayAnima = false;
             }
              else if (PlayAnimaTime == 0)
              {
                PlayAnima = true;
                PlayAnimaTime = 35;
              }


                // games pl<y Ar
                TmerAni2--;
                if (TmerAni2 == 0)
                {
                    TmerAni2 = 20;
                    
                }

                if (TmerAni2 == 20 || TmerAni2 == 4)
                {

                    Anima1 = true;
                    Anima2 = false;
                }

                if (TmerAni2 == 16 || TmerAni2 == 8)
                {
                    Anima1 = false;
                    Anima2 = true;
                    Anima3 = false;


                }

                if (TmerAni2 == 12)
                {
                    Anima2 = false;
                    Anima3 = true;
                   

                }

            }


            










                base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);


            spriteBatch.Begin();
            spriteBatch.Draw(BackGround, BackGroundXY, Color.White);
            spriteBatch.End();

            spriteBatch.Begin();
            spriteBatch.Draw(BackGround3, BackGroundXY3, Color.White);
            spriteBatch.End();

           
            
            spriteBatch.Begin();
            spriteBatch.Draw(BackGround3, BackGroundXY32, Color.White);
            spriteBatch.End();

            spriteBatch.Begin();
            spriteBatch.Draw(BackGround3, BackGroundXY322, Color.White);
            spriteBatch.End();





            //cclouds
            if (clouds1XY.X > tubeXY_Delete)
            {
                spriteBatch.Begin();
                spriteBatch.Draw(clouds1, clouds1XY, Color.White);
                spriteBatch.End();

            }


            if (clouds2XY.X > tubeXY_Delete)
            {
                spriteBatch.Begin();
                spriteBatch.Draw(clouds2, clouds2XY, Color.White);
                spriteBatch.End();

            }

            if (clouds3XY.X > tubeXY_Delete)
            {
                spriteBatch.Begin();
                spriteBatch.Draw(clouds3, clouds3XY, Color.White);
                spriteBatch.End();

            }


            if (clouds4XY.X > tubeXY_Delete)
            {

                spriteBatch.Begin();
                spriteBatch.Draw(clouds4, clouds4XY, Color.White);
                spriteBatch.End();
            }

            if (clouds5XY.X > tubeXY_Delete)
            {
                spriteBatch.Begin();
                spriteBatch.Draw(clouds5, clouds5XY, Color.White);
                spriteBatch.End();

            }

            // test score
            spriteBatch.Begin();
            spriteBatch.Draw(zebra, zebra2, Color.White);
            spriteBatch.End();

            spriteBatch.Begin();
            spriteBatch.Draw(zebra, zebra3, Color.White);
            spriteBatch.End();


            if (BackGroundXY2.X > (int)Back_Ground_Delete)
            {

                spriteBatch.Begin();
                spriteBatch.Draw(BackGround2, BackGroundXY2, Color.White);
                spriteBatch.End();
            }

            if (BackGroundXY22.X > (int)Back_Ground_Delete)
            {
                spriteBatch.Begin();
                spriteBatch.Draw(BackGround2, BackGroundXY22, Color.White);
                spriteBatch.End();
            }

            //  Animation groundgrass

            if (GroundGrass2.X > (int)Back_Ground_Delete)
            {

                spriteBatch.Begin();
                spriteBatch.Draw(GroundGrass, GroundGrass2, Color.White);
                spriteBatch.End();
            }

            if (GroundGrass22.X > (int)Back_Ground_Delete)
            {
                spriteBatch.Begin();
                spriteBatch.Draw(GroundGrass, GroundGrass22, Color.White);
                spriteBatch.End();
            }







            if (button2 == false && button22 == false)
            {
                spriteBatch.Begin();
                spriteBatch.Draw(button, buttonXY, parrotColor);
                spriteBatch.End();
            }


            if (button2 == true)
            {
                if( PlayGameBoll == true && PlayAnima == false)
                {
                spriteBatch.Begin();
                spriteBatch.Draw(PlayGame, PlayGameXY, parrotColor);
                spriteBatch.End();

                }
                



                if (Anima1 == true)
                {
                    spriteBatch.Begin();
                    spriteBatch.Draw(bird1, birdXY, parrotColor);
                    spriteBatch.End();
                }

                if (Anima2 == true)
                {
                    spriteBatch.Begin();
                    spriteBatch.Draw(bird2, birdXY, parrotColor);
                    spriteBatch.End();
                }

                if (Anima3 == true)
                {
                    spriteBatch.Begin();
                    spriteBatch.Draw(bird3, birdXY, parrotColor);
                    spriteBatch.End();
                }

                if (tubeXY.X > (int)tubeXY_Delete)
                {

                    spriteBatch.Begin();
                    spriteBatch.Draw(tube, tubeXY, Color.Green);
                    // svcore

                    spriteBatch.End();


                }

                if (tune2 == true && tubeXY2.X > (int)tubeXY_Delete)
                {

                    spriteBatch.Begin();
                    spriteBatch.Draw(tube, tubeXY2, Color.Green);

                    // svcore

                    spriteBatch.End();

                }


                if (tubedanXY.X > (int)tubeXY_Delete)
                {
                    spriteBatch.Begin();
                    spriteBatch.Draw(tubedan, tubedanXY, Color.Green);
                    spriteBatch.End();

                }


                if (tune2 == true && tubedanXY2.X > (int)tubeXY_Delete)
                {

                    spriteBatch.Begin();
                    spriteBatch.Draw(tubedan, tubedanXY2, Color.Green);
                    spriteBatch.End();
                }


                if (GameOverBoll == true)
                {

                  spriteBatch.Begin();
                  spriteBatch.Draw(GameOver, GameOverXY, Color.White);   
                  spriteBatch.Draw(GameOverScore, GameOverScoreXY, Color.White);
                  spriteBatch.Draw(GameOverStartGame, GameOverStartGameXY, parrotColor);
                  
                  spriteBatch.DrawString(TextScore2, TextScoreNumber2, TextScore2XY, Color.Red);
                  spriteBatch.DrawString(TextScore3, score.ToString(), TextScore22XY, Color.GreenYellow);

                    
                  spriteBatch.End();
                }
                spriteBatch.Begin();
                spriteBatch.DrawString(TextScore, TextScoreNumber, TextScoreXY, Color.GreenYellow);
                spriteBatch.End();







            }

            base.Draw(gameTime);
        }

        private static void StartGameButton()
        {
            if (GameOverStartGameXY.Contains(mus.Position) == true && buttonStart2 == true)
            {

                parrotColor = Color.Green;
                GameOverStartGameXY.Width =  105;
                GameOverStartGameXY.Height = 105;


                MouseState currentStatemus2 = Mouse.GetState();
                if (mus.LeftButton == ButtonState.Pressed && UpButtontMou2.LeftButton == ButtonState.Released)
                {
                     score = 0;
                     buttonStart2 = false;
                     GameOverBoll = false;
                     death = false;
                     
                     Play = false;
                     PlayGameBoll = false;
                     button2 = false;
                      
                     tubeplay = false;
                     birdXY = new Rectangle(300, 100, 45, 45);

                     tubeXY = new Rectangle(810, tubeYLength, 67, 404);
                     tubeXY2 = new Rectangle(810, tubeYLength2, 67, 404);
                     tubedanXY = new Rectangle(810, tubedanY, 67, 404);
                     tubedanXY2 = new Rectangle(810, tubedanY2, 67, 404);
                }
                UpButtontMou2 = currentStatemus2;
            }
            else
            {
                parrotColor = Color.White;
                GameOverStartGameXY.Width = 100;
                GameOverStartGameXY.Height = 100;

            }

        }
        private static void Gameplay()
        {


            TimeGravity--;
            KeyboardState kb = Keyboard.GetState();
            if (kb.IsKeyDown(Keys.Space) && oldState.IsKeyUp(Keys.Space) || mus.LeftButton == ButtonState.Pressed && UpButtontMou.LeftButton == ButtonState.Released )
            {
               // soundEffectInstance.IsLooped = true;

              //  soundEffectInstance.Play();
                boom2.Play();
                AnimationJump = true;
                FallGravity = false;
                TimeGravity = 5;

               
               if (Play2 == true)
               {

                   PlayGameBoll = false;

                  if (PlayGameBoll == false)
                  {
                    Play = true;
                  }
                  ////
                    birdY = 0;
                    birdY += birdY_Raspond/2;
                }



            }
            else if (TimeGravity == 0)
            {
                FallGravity = true;
            }


            UpButtontMou = mus;
            oldState = kb;
            if (death == false && Play == true)
            {

                

                if (FallGravity == true)
                {
                    TmerGravity--;
                    if (TmerGravity == 4)
                    {
                        ///
                        tim--;
                        if (birdY < birdY_Raspond && tim == 1)
                        {

                            birdY++;
                            tim = 2;
                        }

                        if (tim <= 0)
                        {
                            tim = 0;
                            tim = 2;
                        }

                        
                        birdXY.Y += (int)(birdY + levl);


                    }
                    if (TmerGravity == 0)
                    {
                        TmerGravity = 5;
                    }
                }

                //animation
                if (TmerAni >= 0 && AnimationJump == true)
                {
                    TmerAni--;
                }

                if (AnimationJump == true)
                {

                    if (TmerAni == 0)
                    {
                        TmerAni = tmerbird;
                        AnimationJump = false;
                    }

                    if (TmerAni == 5 || TmerAni == 1)
                    {

                        Anima1 = true;
                        Anima2 = false;
                    }

                    if (TmerAni == 4 || TmerAni == 2)
                    {
                        Anima1 = false;
                        Anima2 = true;
                        Anima3 = false;


                    }

                    if (TmerAni == 3)
                    {
                        Anima2 = false;
                        Anima3 = true;
                        birdXY.Y -= (int)(birdYJU_Raspond + levl);

                    }


                }



            }






        }

        private static void Screen1080()
        {
            _graphics.PreferredBackBufferWidth = _graphics.GraphicsDevice.Viewport.Width;
            _graphics.PreferredBackBufferHeight = _graphics.GraphicsDevice.Viewport.Height;
            //_graphics.IsFullScreen = true;
            _graphics.ApplyChanges();


            Preferred_Width = _graphics.PreferredBackBufferWidth;
            Preferred_Height = _graphics.PreferredBackBufferHeight;

            Preferred_Width /= ScreenWidth;
            Preferred_Height /= ScreenHeight;

            // FullScreen  button
            buttonXY.X = (int)(button_X * Preferred_Width);
            buttonXY.Y = (int)(button_Y * Preferred_Height);
            buttonXY.Width = (int)(button_Width * Preferred_Width);
            buttonXY.Height = (int)(button_Height * Preferred_Height);

            button_WidthBig = buttonXY.Width;
            button_HeightBig = buttonXY.Height;
            // FullScreen bird
            birdXY.X = (int)(bird_X * Preferred_Width);
            birdXY.Y = (int)(bird_Y * Preferred_Height);
            birdXY.Width = (int)(bird_Width * Preferred_Width);
            birdXY.Height = (int)(bird_Height * Preferred_Height);

            //back Ground FullScreen

            GroundGrass2.X = (int)(GroundGrass_X * Preferred_Width);
            GroundGrass2.Y = (int)(GroundGrass_Y * Preferred_Height);
            GroundGrass2.Width = (int)(GroundGrass_Width * Preferred_Width);
            GroundGrass2.Height = (int)(GroundGrass_Height * Preferred_Height);

            GroundGrass22.X = (int)(GroundGrass2_X * Preferred_Width);
            GroundGrass22.Y = (int)(GroundGrass2_Y * Preferred_Height);
            GroundGrass22.Width = (int)(GroundGrass2_Width * Preferred_Width);
            GroundGrass22.Height = (int)(GroundGrass2_Height * Preferred_Height);

            // hiddem wall points  FullScreen
            zebra2.X = (int)(zebra2_X * Preferred_Width);
            zebra2.Y = (int)(zebra2_Y * Preferred_Height);
            zebra2.Width = (int)(zebra2_Width * Preferred_Width);
            zebra2.Height = (int)(zebra2_Height * Preferred_Height);

            zebra3.X = (int)(zebra3_X * Preferred_Width);
            zebra3.Y = (int)(zebra3_Y * Preferred_Height);
            zebra3.Width = (int)(zebra3_Width * Preferred_Width);
            zebra3.Height = (int)(zebra3_Height * Preferred_Height);

            // enemy
            tubeXY.X = (int)(tubeXY_X * Preferred_Width);
            tubeXY.Y = (int)(tubeXY_Y * Preferred_Height);
            tubeXY.Width = (int)(tubeXY_Width * Preferred_Width);
            tubeXY.Height = (int)(tubeXY_Height * Preferred_Height);

            tubeXY2.X = (int)(tubeXY2_X * Preferred_Width);
            tubeXY2.Y = (int)(tubeXY2_Y * Preferred_Height);
            tubeXY2.Width = (int)(tubeXY2_Width * Preferred_Width);
            tubeXY2.Height = (int)(tubeXY2_Height * Preferred_Height);



            tubedanXY.X = (int)(tubedanXY_X * Preferred_Width);
            tubedanXY.Y = (int)(tubedanXY_Y * Preferred_Height);
            tubedanXY.Width = (int)(tubedanXY_Width * Preferred_Width);
            tubedanXY.Height = (int)(tubedanXY_Height * Preferred_Height);

            tubedanXY2.X = (int)(tubedanXY2_X * Preferred_Width);
            tubedanXY2.Y = (int)(tubedanXY2_Y * Preferred_Height);
            tubedanXY2.Width = (int)(tubedanXY2_Width * Preferred_Width);
            tubedanXY2.Height = (int)(tubedanXY2_Height * Preferred_Height);


            //Back Ground 1 

            BackGroundXY.X = (int)(BackGroundXY_X * Preferred_Width);
            BackGroundXY.Y = (int)(BackGroundXY_Y * Preferred_Height);
            BackGroundXY.Width = (int)(BackGroundXY_Width * Preferred_Width);
            BackGroundXY.Height = (int)(BackGroundXY_Height * Preferred_Height);

            BackGroundXY3.X = (int)(BackGroundXY3_X * Preferred_Width);
            BackGroundXY3.Y = (int)(BackGroundXY3_Y * Preferred_Height);
            BackGroundXY3.Width = (int)(BackGroundXY3_Width * Preferred_Width);
            BackGroundXY3.Height = (int)(BackGroundXY3_Height * Preferred_Height);


            //back Ground Animation 1
            BackGroundXY2.X = (int)(BackGroundXY2_X * Preferred_Width);
            BackGroundXY2.Y = (int)(BackGroundXY2_Y * Preferred_Height);
            BackGroundXY2.Width = (int)(BackGroundXY2_Width * Preferred_Width);
            BackGroundXY2.Height = (int)(BackGroundXY2_Height * Preferred_Height);


            BackGroundXY22.X = (int)(BackGroundXY22_X * Preferred_Width);
            BackGroundXY22.Y = (int)(BackGroundXY22_Y * Preferred_Height);
            BackGroundXY22.Width = (int)(BackGroundXY22_Width * Preferred_Width);
            BackGroundXY22.Height = (int)(BackGroundXY22_Height * Preferred_Height);

            PlayGameXY.X = (int)(PlayGame_X * Preferred_Width);
            PlayGameXY.Y = (int)(PlayGame_Y * Preferred_Height);
           PlayGameXY.Width = (int)(PlayGame_Width * Preferred_Width);
            PlayGameXY.Height = (int)(PlayGame_Height * Preferred_Height);



            // back ground delet
            Back_Ground_Delete = Back_Ground_Delete_Save * Preferred_Width;

            // back ground Raspond
            Back_Ground_Raspond = Back_Ground_Raspond_Save * Preferred_Width;

            // back ground Speed
            Back_Ground_Speed = Back_Ground_Speed_Save * Preferred_Width;

            //points
            points_Delete = points_Delete_Save * Preferred_Width;

            //points zoom y
            points_zoom = points_zoom_Save * Preferred_Height;

            //´tubeXY deletw
            tubeXY_Delete = tubeXY_Delete_Save * Preferred_Width;

            // tubeXY Raspond
            tubeXY_Raspond = tubeXY_Raspond_Save * Preferred_Width;

            // tubeXY Speed
            tubeXY_Speed = tubeXY_Speed_Save * Preferred_Width;

            // tubeXY  random
            tubeXY_random = tubeXY_random_Save * Preferred_Width;
            tubeXY_randomTelerF = true;

            tubeXYwww = tubeXYwww_Save * Preferred_Width;

            // birdY
            birdY_Raspond = (float)(birdY_Save * Preferred_Width / 1.2);
            birdYJU_Raspond = (float)(birdYJU_Save * Preferred_Width / 1.3);

            _graphics.IsFullScreen = true;
            _graphics.ApplyChanges();



            Screen = false;
            Screen2 = true;

        }


        private static void Screen400()
        {
            // Screen  button
            buttonXY.X = (int)button_X;
            buttonXY.Y = (int)button_Y;
            buttonXY.Width = (int)button_Width;
            buttonXY.Height = (int)button_Height;


            button_WidthBig = buttonXY.Width;
            button_HeightBig = buttonXY.Height;

            // Screen bird
            birdXY.X = (int)bird_X;
            birdXY.Y = (int)bird_Y;
            birdXY.Width = (int)bird_Width;
            birdXY.Height = (int)bird_Height;



            //back Ground Screen

            GroundGrass2.X = (int)GroundGrass_X;
            GroundGrass2.Y = (int)GroundGrass_Y;
            GroundGrass2.Width = (int)GroundGrass_Width;
            GroundGrass2.Height = (int)GroundGrass_Height;

            GroundGrass22.X = (int)GroundGrass2_X;
            GroundGrass22.Y = (int)GroundGrass2_Y;
            GroundGrass22.Width = (int)GroundGrass2_Width;
            GroundGrass22.Height = (int)GroundGrass2_Height;

            // hiddem wall points  FullScreen
            zebra2.X = (int)zebra2_X;
            zebra2.Y = (int)zebra2_Y;
            zebra2.Width = (int)zebra2_Width;
            zebra2.Height = (int)zebra2_Height;

            zebra3.X = (int)zebra3_X;
            zebra3.Y = (int)zebra3_Y;
            zebra3.Width = (int)zebra3_Width;
            zebra3.Height = (int)zebra3_Height;

            // enemy
            tubeXY.X = (int)tubeXY_X;
            tubeXY.Y = (int)tubeXY_Y;
            tubeXY.Width = (int)tubeXY_Width;
            tubeXY.Height = (int)tubeXY_Height;

            tubeXY2.X = (int)tubeXY2_X;
            tubeXY2.Y = (int)tubeXY2_Y;
            tubeXY2.Width = (int)tubeXY2_Width;
            tubeXY2.Height = (int)tubeXY2_Height;

            tubedanXY.X = (int)tubedanXY_X;
            tubedanXY.Y = (int)tubedanXY_Y;
            tubedanXY.Width = (int)tubedanXY_Width;
            tubedanXY.Height = (int)tubedanXY_Height;

            tubedanXY2.X = (int)tubedanXY2_X;
            tubedanXY2.Y = (int)tubedanXY2_Y;
            tubedanXY2.Width = (int)tubedanXY2_Width;
            tubedanXY2.Height = (int)tubedanXY2_Height;


            //Back Ground 1 
            BackGroundXY.X = (int)BackGroundXY_X;
            BackGroundXY.Y = (int)BackGroundXY_Y;
            BackGroundXY.Width = (int)BackGroundXY_Width;
            BackGroundXY.Height = (int)BackGroundXY_Height;

            BackGroundXY3.X = (int)BackGroundXY3_X;
            BackGroundXY3.Y = (int)BackGroundXY3_Y;
            BackGroundXY3.Width = (int)BackGroundXY3_Width;
            BackGroundXY3.Height = (int)BackGroundXY3_Height;


            //back Ground Animation 1
            BackGroundXY2.X = (int)BackGroundXY2_X;
            BackGroundXY2.Y = (int)BackGroundXY2_Y;
            BackGroundXY2.Width = (int)BackGroundXY2_Width;
            BackGroundXY2.Height = (int)BackGroundXY2_Height;

            BackGroundXY22.X = (int)BackGroundXY22_X;
            BackGroundXY22.Y = (int)BackGroundXY22_Y;
            BackGroundXY22.Width = (int)BackGroundXY22_Width;
            BackGroundXY22.Height = (int)BackGroundXY22_Height;


            PlayGameXY.X = (int)(PlayGame_X);
            PlayGameXY.Y = (int)(PlayGame_Y);
            PlayGameXY.Width = (int)(PlayGame_Width);
            PlayGameXY.Height = (int)(PlayGame_Height);

            // back ground delet
            Back_Ground_Delete = Back_Ground_Delete_Save;


            // back ground Raspond
            Back_Ground_Raspond = Back_Ground_Raspond_Save;


            // back ground Speed
            Back_Ground_Speed = Back_Ground_Speed_Save;

            //points
            points_Delete = points_Delete_Save;

            //points zoom y
            points_zoom = points_zoom_Save;

            //  tubeXY deletw
            tubeXY_Delete = tubeXY_Delete_Save;

            // tubeXY Raspond
            tubeXY_Raspond = tubeXY_Raspond_Save;

            // tubeXY Speed
            tubeXY_Speed = tubeXY_Speed_Save;


            // tubeXY  random
            tubeXY_random = tubeXY_random_Save;
            tubeXY_randomTelerF = false;


            // birdY
            birdY_Raspond = (float)birdY_Save;
            birdYJU_Raspond = (float)birdYJU_Save;


            tubeXYwww = tubeXYwww_Save;

            _graphics.IsFullScreen = false;

            Screen2 = false;
            Screen = true;

        }

        private static void clouds()
        {

            Random myRandon = new Random();

            // clouds to Y Random
            int clouds1Y = myRandon.Next(20, 240);

            int clouds2Y = myRandon.Next(20, 120);

            int clouds3Y = myRandon.Next(20, 200);

            int clouds4Y = myRandon.Next(20, 250);

            int clouds5Y = myRandon.Next(20, 230);


            // clouds to X Random
            int clouds1X = myRandon.Next(0, 40);




            clouds1X--;
            if (clouds1XY.X  < tubeXY_Delete && clouds1X == 0) 
            {
                clouds1XY.X = 850;
                clouds1XY.Y = clouds1Y;
            }
          
            if (clouds2XY.X < tubeXY_Delete && clouds1XY.X == 150)
            {
                clouds2XY.X = 850;
                clouds2XY.Y = clouds2Y;
            }
         
            if (clouds3XY.X < tubeXY_Delete && clouds2XY.X == 180)
            {
                clouds3XY.X = 850;
                clouds3XY.Y = clouds3Y;
            }
            
            if (clouds4XY.X < tubeXY_Delete && clouds3XY.X == 190)
            {
                clouds4XY.X = 850;
                clouds4XY.Y = clouds4Y;
            }

           
            if (clouds5XY.X < tubeXY_Delete && clouds5XY.X == 200)
            {
                clouds5XY.X = 850;
                clouds5XY.Y = clouds5Y;
            }




            clouds1XY.X -= (int)(2 + levl);
            clouds2XY.X -= (int)(2 + levl);
            clouds3XY.X -= (int)(2 + levl);
            clouds4XY.X -= (int)(2 + levl);
            clouds5XY.X -= (int)(2 + levl);


            if (BackGroundXY3.X < -825)
            {
                BackGroundXY3.X = 810;
               
            }

            if (BackGroundXY32.X < -825)
            {
                BackGroundXY32.X = 810;

            }


            if (BackGroundXY322.X < -825)
            {
                BackGroundXY322.X = 810;

            }
            BackGroundXY32.X -= (int)(1 + levl);
            BackGroundXY3.X -= (int)(1 + levl);
            BackGroundXY322.X -= (int)(1 + levl);


        }

        private static void map()
        {




            if (tubeplay == true && GameOverBoll == false && Play == true)
            {
                tubeXY.X -= (int)(tubeXY_Speed + levl);
                tubedanXY.X -= (int)(tubeXY_Speed + levl);
                scorexy = HiddenWall.Y;

            }

            if (tubeXY.X <= (int)tubeXY_Delete)
            {

                tubeXY.X = (int)tubeXY_Raspond;
                HiddenWall.Y -= 40;
                scorexy = HiddenWall.Y;

            }

            if (tubeXY.X <= tubeXYwww)
            {
                tune2 = true;

            }

            else if (tubeXY2.X == (int)tubeXY_Raspond)
                tune2 = false;

            if (tubeXY2.X <= (int)tubeXY_Delete)
            {

                tubeXY2.X = (int)tubeXY_Raspond;
            }



            if (tune2 == true && GameOverBoll == false && Play == true)
            {
                tubeXY2.X -= (int)(tubeXY_Speed + levl);
                tubedanXY2.X -= (int)(tubeXY_Speed + levl);
            }


            if (tubedanXY.X <= (int)tubeXY_Delete)
            {

                tubedanXY.X = (int)tubeXY_Raspond;
            }

            if (tubedanXY2.X <= (int)tubeXY_Delete)
            {

                tubedanXY2.X = (int)tubeXY_Raspond;
            }
        }

        private static void random()
        {
            Random myRandon = new Random();

            int level2 = myRandon.Next(1, 12);

            if (level2 == 1)
            {
                if (tubeXY.X <= tubeXY_random)
                {
                    if (tubeXY_randomTelerF == false)
                    {
                        tubeXY.Y = 240;
                        tubedanXY.Y = -350;


                    }

                    if (tubeXY_randomTelerF == true)
                    {
                        tubeXY.Y = (int)(240 * Preferred_Height);
                        tubedanXY.Y = (int)(-350 * Preferred_Height);


                    }
                }





            }


            if (level2 == 2)
            {
                if (tubeXY.X <= tubeXY_random)
                {

                    if (tubeXY_randomTelerF == false)
                    {

                        tubeXY.Y = 350;
                        tubedanXY.Y = -200;

                    }

                    if (tubeXY_randomTelerF == true)
                    {

                        tubeXY.Y = (int)(350 * Preferred_Height);
                        tubedanXY.Y = (int)(-200 * Preferred_Height);

                    }

                }


            }


            if (level2 == 3)
            {
                if (tubeXY.X <= tubeXY_random)
                {

                    if (tubeXY_randomTelerF == false)
                    {

                        tubeXY.Y = 240;
                        tubedanXY.Y = -350;

                    }

                    if (tubeXY_randomTelerF == true)
                    {

                        tubeXY.Y = (int)(240 * Preferred_Height);
                        tubedanXY.Y = (int)(-350 * Preferred_Height);

                    }
                }

            }


            if (level2 == 4)
            {
                if (tubeXY.X <= tubeXY_random)
                {

                    if (tubeXY_randomTelerF == false)
                    {

                        tubeXY.Y = 350;
                        tubedanXY.Y = -170;

                    }

                    if (tubeXY_randomTelerF == true)
                    {

                        tubeXY.Y = (int)(350 * Preferred_Height);
                        tubedanXY.Y = (int)(-170 * Preferred_Height);

                    }

                }

            }



            if (level2 == 5)
            {
                if (tubeXY.X <= tubeXY_random)
                {
                    if (tubeXY_randomTelerF == false)
                    {

                        tubeXY.Y = 400;
                        tubedanXY.Y = -120;

                    }

                    if (tubeXY_randomTelerF == true)
                    {


                        tubeXY.Y = (int)(400 * Preferred_Height);
                        tubedanXY.Y = (int)(-120 * Preferred_Height);
                    }

                }


            }



            if (level2 == 6)
            {
                if (tubeXY.X <= tubeXY_random)
                {
                    if (tubeXY_randomTelerF == false)
                    {

                        tubeXY.Y = 350;
                        tubedanXY.Y = -200;

                    }

                    if (tubeXY_randomTelerF == true)
                    {


                        tubeXY.Y = (int)(350 * Preferred_Height);
                        tubedanXY.Y = (int)(-200 * Preferred_Height);

                    }

                }


            }


            if (level2 == 7)
            {
                if (tubeXY.X <= tubeXY_random)
                {
                    if (tubeXY_randomTelerF == false)
                    {

                        tubeXY.Y = 380;
                        tubedanXY.Y = -140;

                    }

                    if (tubeXY_randomTelerF == true)
                    {

                        tubeXY.Y = (int)(380 * Preferred_Height);
                        tubedanXY.Y = (int)(-140 * Preferred_Height);

                    }

                }



            }



            if (level2 == 8)
            {
                if (tubeXY.X == tubeXY_random)
                {
                    if (tubeXY_randomTelerF == false)
                    {


                        tubeXY.Y = 320;
                        tubedanXY.Y = -200;

                    }

                    if (tubeXY_randomTelerF == true)
                    {
                        tubeXY.Y = (int)(320 * Preferred_Height);
                        tubedanXY.Y = (int)(-200 * Preferred_Height);


                    }

                }


            }



            if (level2 == 9)
            {
                if (tubeXY.X == tubeXY_random)
                {
                    if (tubeXY_randomTelerF == false)
                    {
                        tubeXY.Y = 220;
                        tubedanXY.Y = -300;


                    }

                    if (tubeXY_randomTelerF == true)
                    {

                        tubeXY.Y = (int)(220 * Preferred_Height);
                        tubedanXY.Y = (int)(-300 * Preferred_Height);

                    }

                }



            }



            if (level2 == 10)
            {
                if (tubeXY.X == tubeXY_random)
                {
                    if (tubeXY_randomTelerF == false)
                    {
                        tubeXY.Y = 370;
                        tubedanXY.Y = -150;


                    }

                    if (tubeXY_randomTelerF == true)
                    {

                        tubeXY.Y = (int)(370 * Preferred_Height);
                        tubedanXY.Y = (int)(-150 * Preferred_Height);

                    }

                }



            }



            if (level2 == 11)
            {
                if (tubeXY.X == tubeXY_random)
                {
                    if (tubeXY_randomTelerF == false)
                    {

                        tubeXY.Y = 190;
                        tubedanXY.Y = -330;

                    }

                    if (tubeXY_randomTelerF == true)
                    {

                        tubeXY.Y = (int)(190 * Preferred_Height);
                        tubedanXY.Y = (int)(-330 * Preferred_Height);

                    }

                }


            }




            if (level2 == 12)
            {
                if (tubeXY.X == tubeXY_random)
                {
                    if (tubeXY_randomTelerF == false)
                    {

                        tubeXY.Y = 380;
                        tubedanXY.Y = -140;

                    }

                    if (tubeXY_randomTelerF == true)
                    {

                        tubeXY.Y = (int)(380 * Preferred_Height);
                        tubedanXY.Y = (int)(-140 * Preferred_Height);

                    }

                }



            }


        }
        private static void random2()
        {
            Random myRandon = new Random();

            int level2 = myRandon.Next(1, 12);

            if (level2 == 1)
            {



                if (tubedanXY2.X <= tubeXY_random)
                {
                    if (tubeXY_randomTelerF == false)
                    {
                        tubeXY2.Y = 170;
                        tubedanXY2.Y = -350;

                    }

                    if (tubeXY_randomTelerF == true)
                    {
                        tubeXY2.Y = (int)(170 * Preferred_Height);
                        tubedanXY2.Y = (int)(-350 * Preferred_Height);
                    }
                }



            }


            if (level2 == 2)
            {

                if (tubedanXY2.X <= tubeXY_random)
                {
                    if (tubeXY_randomTelerF == false)
                    {
                        tubeXY2.Y = 350;
                        tubedanXY2.Y = -170;
                    }
                    if (tubeXY_randomTelerF == true)
                    {
                        tubeXY2.Y = (int)(350 * Preferred_Height);
                        tubedanXY2.Y = (int)(-170 * Preferred_Height);
                    }

                }


            }


            if (level2 == 3)
            {


                if (tubedanXY2.X <= tubeXY_random)
                {
                    if (tubeXY_randomTelerF == false)
                    {
                        tubeXY2.Y = 370;
                        tubedanXY2.Y = -150;
                    }
                    if (tubeXY_randomTelerF == true)
                    {
                        tubeXY2.Y = (int)(370 * Preferred_Height);
                        tubedanXY2.Y = (int)(-150 * Preferred_Height);
                    }


                }

            }


            if (level2 == 4)
            {

                if (tubedanXY2.X <= tubeXY_random)
                {

                    if (tubeXY_randomTelerF == false)
                    {
                        tubeXY2.Y = 350;
                        tubedanXY2.Y = -170;
                    }
                    if (tubeXY_randomTelerF == true)
                    {
                        tubeXY2.Y = (int)(350 * Preferred_Height);
                        tubedanXY2.Y = (int)(-170 * Preferred_Height);
                    }

                }

            }



            if (level2 == 5)
            {


                if (tubedanXY2.X <= tubeXY_random)
                {
                    if (tubeXY_randomTelerF == false)
                    {
                        tubeXY2.Y = 140;
                        tubedanXY2.Y = -370;
                    }
                    if (tubeXY_randomTelerF == true)
                    {
                        tubeXY2.Y = (int)(140 * Preferred_Height);
                        tubedanXY2.Y = (int)(-370 * Preferred_Height);
                    }


                }

            }



            if (level2 == 6)
            {

                if (tubedanXY2.X <= tubeXY_random)
                {
                    if (tubeXY_randomTelerF == false)
                    {
                        tubeXY2.Y = 350;
                        tubedanXY2.Y = -170;
                    }
                    if (tubeXY_randomTelerF == true)
                    {
                        tubeXY2.Y = (int)(350 * Preferred_Height);
                        tubedanXY2.Y = (int)(-170 * Preferred_Height);
                    }

                }

            }


            if (level2 == 7)
            {

                if (tubedanXY2.X <= tubeXY_random)
                {

                    if (tubeXY_randomTelerF == false)
                    {
                        tubeXY2.Y = 320;
                        tubedanXY2.Y = -200;
                    }
                    if (tubeXY_randomTelerF == true)
                    {
                        tubeXY2.Y = (int)(320 * Preferred_Height);
                        tubedanXY2.Y = (int)(-200 * Preferred_Height);
                    }

                }

            }



            if (level2 == 8)
            {

                if (tubedanXY2.X == tubeXY_random)
                {
                    if (tubeXY_randomTelerF == false)
                    {
                        tubeXY2.Y = 190;
                        tubedanXY2.Y = -330;
                    }
                    if (tubeXY_randomTelerF == true)
                    {
                        tubeXY2.Y = (int)(190 * Preferred_Height);
                        tubedanXY2.Y = (int)(-330 * Preferred_Height);
                    }

                }

            }



            if (level2 == 9)
            {


                if (tubedanXY2.X == tubeXY_random)
                {
                    if (tubeXY_randomTelerF == false)
                    {
                        tubeXY2.Y = 300;
                        tubedanXY2.Y = -220;
                    }
                    if (tubeXY_randomTelerF == true)
                    {
                        tubeXY2.Y = (int)(300 * Preferred_Height);
                        tubedanXY2.Y = (int)(-220 * Preferred_Height);
                    }

                }

            }



            if (level2 == 10)
            {



                if (tubedanXY2.X == tubeXY_random)
                {
                    if (tubeXY_randomTelerF == false)
                    {
                        tubeXY2.Y = 400;
                        tubedanXY2.Y = -120;
                    }
                    if (tubeXY_randomTelerF == true)
                    {
                        tubeXY2.Y = (int)(400 * Preferred_Height);
                        tubedanXY2.Y = (int)(-120 * Preferred_Height);
                    }

                }

            }



            if (level2 == 11)
            {

                if (tubedanXY2.X == tubeXY_random)
                {
                    if (tubeXY_randomTelerF == false)
                    {
                        tubeXY2.Y = 220;
                        tubedanXY2.Y = -300;
                    }
                    if (tubeXY_randomTelerF == true)
                    {
                        tubeXY2.Y = (int)(220 * Preferred_Height);
                        tubedanXY2.Y = (int)(-300 * Preferred_Height);
                    }


                }

            }




            if (level2 == 12)
            {


                if (tubedanXY2.X == tubeXY_random)
                {
                    if (tubeXY_randomTelerF == false)
                    {
                        tubeXY2.Y = 320;
                        tubedanXY2.Y = -200;
                    }
                    if (tubeXY_randomTelerF == true)
                    {
                        tubeXY2.Y = (int)(320 * Preferred_Height);
                        tubedanXY2.Y = (int)(-200 * Preferred_Height);
                    }

                }

            }
        }
    }
}
// haasasasasas