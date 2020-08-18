using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazeVote.Services;
using Microsoft.AspNetCore.SignalR;

namespace BlazeVote.Hubs
{
    public class VoteHub : Hub
    {
        public const string ADD_PUBLIC_KEY = nameof(AddPublicKey);

        public const string JOIN_VOTE_GROUP = nameof(AddToGroup);

        private VoteService _voteService;

        public async Task AddPublicKey(string groupId, Data.PublicKey key)
        {
            await Clients.Group(groupId).SendAsync("AddPublicKey", key);
        }

        public async Task AddToGroup(string groupId, string secret)
        {
            var group = _voteService.GetVoteGroup(groupId);
            if (group != null)
            {
                if (group.Secret == secret)
                {
                    await Groups.AddToGroupAsync(Context.ConnectionId, groupId);
                }
            }
        }

        public VoteHub(VoteService voteService)
        {
            _voteService = voteService;
        }

    }
}
