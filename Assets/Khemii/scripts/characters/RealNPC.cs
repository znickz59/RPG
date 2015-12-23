using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


    public class RealNPC : NPC
    {
        public new uint Level;
        public Type type;
        void Start()
        {
        switch (type)
        {
            case Type.Warrrior:
                health = Level * 50;
                magic = Level + 10;
                stamina = Level * 25;
                break;
            case Type.Wizard:
                health = Level * 3;
                magic = Level * 100;
                stamina = Level * 10;
                break;
            case Type.Archer:
                health = Level * 15;
                magic = Level * 5;
                stamina = Level * 50;
                break;
        }
        }
    }

