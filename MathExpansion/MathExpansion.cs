using Exiled.API.Features;
using PlaceholderAPI.API.Abstract;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathExpansion
{
    public class MathExpansion : PlaceholderExpansion
    {
        public override string Author { get; set; } = "NotZer0Two";
        public override string Identifier { get; set; } = "math";
        public override string RequiredPlugin { get; set; } = null;

        public override string OnRequest(Player player, string param)
        {
            string parsed = PlaceholderAPI.API.PlaceholderAPI.SetBracketsPlaceholders(player, param);
            string expression = parsed.Split('_')[0];

            return Convert.ToDouble(new DataTable().Compute(expression, null)).ToString();
        }

        public override string OnOfflineRequest(string param)
        {
            string parsed = PlaceholderAPI.API.PlaceholderAPI.SetBracketsPlaceholders(param);
            string expression = parsed.Split('_')[0];

            return Convert.ToDouble(new DataTable().Compute(expression, null)).ToString();
        }
    }
}
