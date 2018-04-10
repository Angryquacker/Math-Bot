using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord.Commands;

namespace Math_Bot_Yo.Modules
{
    public class PI : ModuleBase<SocketCommandContext>
    {
        [Command("Pi")]
        public async Task pi(int digits)
        {
            double pi = 3.1415926535897932384626433832795028841971693993751058209749445923078164062862089986280348253421170679;
            if (digits > 14)
            {
                await Context.Channel.SendMessageAsync("HOLD ON! That is wayyyyyyyy too many digits you hippy!");
            } else {
                double mult = Math.Pow(10.0, digits);
                double result = Math.Truncate(mult * pi) / mult;
                await Context.Channel.SendMessageAsync("The first " + digits + " digit(s) of Pi are: " + result);
            }
        } 
    }
}
