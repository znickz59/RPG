using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

    class Fighter : Skill
    {
        public Stage stage;            
    void Start()
    {
        Effect = 1d + (double)stage / 10;
        double result = Hero.Damage.PhysicalDamage * Effect;
        Hero.Damage.PhysicalDamage = (uint)result;
    }
    void FixedUpdate()
    {

    }
    }

