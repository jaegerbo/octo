﻿using Octo.Basics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Octo.Objects
{
   public interface IMove
   {
      structRectangle BorderRectangle { get; set; }

      void move(clsGameObjectMoveable obj, TimeSpan deltaTime);
   }
}
