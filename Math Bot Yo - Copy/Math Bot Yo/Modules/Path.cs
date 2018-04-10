using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord.Commands;

namespace Math_Bot_Yo.Modules
{
    public class Path : ModuleBase<SocketCommandContext>
    {
        [Command("pythag")]
        public async Task path(int sideA, int sideB)
        {
            var s1Result = sideA * sideA;
            var s2Result = sideB * sideB;
            var total = s1Result + s2Result;
            var sideC = Math.Sqrt(total);
            await Context.Channel.SendMessageAsync("The hypotenuse of the triangle is: " + sideC);

        }
    }
}
