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
                Health = Level * 50;
                Magic = Level + 10;
                Stamina = Level * 25;
                break;
            case Type.Wizard:
                Health = Level * 3;
                Magic = Level * 100;
                Stamina = Level * 10;
                break;
            case Type.Archer:
                Health = Level * 15;
                Magic = Level * 5;
                Stamina = Level * 50;
                break;
        }
        }
    }

