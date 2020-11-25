using System;
using System.Collections.Generic;
using System.Text;

namespace FakeAxeAndDummy.Contracts
{
    public interface ITarget
    {
        //int Health { get; }
        bool IsDead();
        int GiveExperience();
        void TakeAttack(int attackPoints);
    }
}
