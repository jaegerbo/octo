﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Octo.Basics
{
   public struct structRectangle
   {
      public structRectangle(float X, float Y, float Width, float Height) {
         this.X = X;
         this.Y = Y;
         this.Width = Width;
         this.Height = Height;
      }

      public float X;
      public float Y;
      public float Width;
      public float Height;
   }
}
