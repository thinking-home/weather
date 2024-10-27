using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ThinkingHome.Weather.Api.Model.Enum
{
    public enum PrecType
    {
        Clear = 0,
        Rain = 1,
        RainWithSnow = 2,
        Snow = 3,
        Hail = 4
    }
}
