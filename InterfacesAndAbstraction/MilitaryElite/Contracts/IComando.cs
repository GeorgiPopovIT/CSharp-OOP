using System;
using System.Collections.Generic;


namespace MilitaryElite
{
    public interface IComando
    {
        public List<Mission> Missions { get; set; }
    }
}
