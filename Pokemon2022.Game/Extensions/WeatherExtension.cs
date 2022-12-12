using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Entities.Names;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon2022.Game.Extensions
{
    public static class WeatherExtension
    {
        public static double GetDamagePercentageValue(this Weather weather)
        {
            return weather switch
            {
                Weather.None => 0,
                Weather.Rain => 0,
                Weather.Sun => 0,
                Weather.Hail => 1.0 / 16,
                Weather.Sand => 1.0 / 16,
                Weather.HeavyRain => 0,
                Weather.HarshSun => 0,
                Weather.DeltaStream => 0,
                _ => throw new ArgumentException("The given weather was not a valid weather."),
            };
        }
    }
}
