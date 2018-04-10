using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord.Commands;

namespace Math_Bot_Yo.Modules
{
    public class Commands : ModuleBase<SocketCommandContext> 
    {
        [Command("help")]
        public async Task Help()
        {
            string[] com = { "cosine", "absolute", "sqrt", "exponent", "round", "help", "D->P", "Pi", "sine", "tangent", "pythag", "SquareA", "SquareV", "SquareP", "SquareSA", "helpF", "formula"};
            await Context.Channel.SendMessageAsync("Commands are as follows: " + string.Join(", ", com));
        }
    }
}
