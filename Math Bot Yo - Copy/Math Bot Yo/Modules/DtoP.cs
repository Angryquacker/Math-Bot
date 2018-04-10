using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord.Commands;

namespace Math_Bot_Yo.Modules
{
    public class DtoP : ModuleBase<SocketCommandContext>
    {
        [Command("D->P")]
        public async Task dToP(double deci)
        {
            var result = deci * 100;
            await Context.Channel.SendMessageAsync("Decimal " + deci + " in percentage form is: " + result + "%");
        }
    }
}
