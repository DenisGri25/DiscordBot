using DSharpPlus;
using DSharpPlus.Entities;
using System;
using System.Threading.Tasks;

namespace DiscordBot.Bots.Handlers.Dialogue.Steps
{
    public interface IDialogueStep
    {
        Action<DiscordMessage> OnMessageAdded { get; set; }
        IDialogueStep NextStep { get; }
        Task<bool> ProcessStep(DiscordClient client, DiscordChannel channel, DiscordUser user);
    }
}
