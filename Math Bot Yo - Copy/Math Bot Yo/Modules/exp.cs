using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord.Commands;

namespace Math_Bot_Yo.Modules
{
    public class exp : ModuleBase<SocketCommandContext>
    {
        [Command("exponent")]
        public async Task Exp(double num, double e)
        {
            var result = Convert.ToString(Math.Pow(num, e));
            await Context.Channel.SendMessageAsync("Your Number raised to the power " + e + " is: " + result);
        }
    }
}
