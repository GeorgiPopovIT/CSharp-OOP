using System;
using System.Collections.Generic;
using System.Text;

namespace FootballGenerator
{
    public class Stats
    {
        private const string InvalidStatMessage = "{0} should be between 0 and 100.";
        private double endurance;
        private double sprint;
        private double dribble;
        private double passing;
        private double shooting;
        public Stats(double endurance, double sprint, double dribble, double passing, double shooting)
        {
            Endurance = endurance;
            Sprint = sprint;
            Dribble = dribble;
            Passing = passing;
            Shooting = shooting;
        }
        public double Endurance
        {
            get => endurance;
            private set
            {
                ValidateState(nameof(Endurance), value);
                endurance = value;
            }
        }
        public double Sprint
        {
            get => sprint;
            private set
            {
                ValidateState(nameof(Sprint), value);
                sprint = value;
            }
        }

        public double Dribble
        {
            get => dribble;
            private set
            {
                ValidateState(nameof(Dribble), value);
                dribble = value;
            }
        }
        public double Passing
        {
            get => passing;
            private set
            {
                ValidateState(nameof(Passing), value);
                passing = value;
            }
        }
        public double Shooting
        {
            get => shooting;
            private set
            {
                ValidateState(nameof(Shooting), value);
                shooting = value;
            }
        }
        private void ValidateState(string name, double value)
        {
            if (value < 0 || value > 100)
            {
                throw new Exception(String.Format(InvalidStatMessage, name));
            }
        }
        public double CalculateRating => (Endurance + Dribble
                + Passing + Shooting + Sprint) / 5;
    }
}
