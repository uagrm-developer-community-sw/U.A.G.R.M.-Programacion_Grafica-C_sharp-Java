﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;

namespace RepreGraficaOpenGlMesa
{
    class Game : GameWindow
    {
        private Figura fig;

        public Game(int width, int height, string tittle) : base(width, height, GraphicsMode.Default, tittle)
        {
            fig = new Figura();
        }

        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            KeyboardState input = OpenTK.Input.Keyboard.GetState();
            if (input.IsKeyDown(Key.Escape))
            {
                Exit();
            }

        }

        protected override void OnLoad(EventArgs e)
        {

            base.OnLoad(e);
        }

        protected override void OnRenderFrame(FrameEventArgs e)
        {

            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            GL.ClearColor(1.2f, 1.3f, 1.3f, 1.0f);

            fig.dibujarMesa();

            Context.SwapBuffers();
            base.OnRenderFrame(e);
        }

        protected override void OnResize(EventArgs e)
        {
            GL.Viewport(0, 0, Width, Height);
            base.OnResize(e);
        }

        protected override void OnUnload(EventArgs e)
        {

            base.OnUnload(e);
        }
    }
}
