﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RPS_Game
{
    class Game
    {
        public List<Round> Rounds = new List<Round>();
        public Player p1 { get; set; }
        public Player p2 { get; set; }
    }
}
