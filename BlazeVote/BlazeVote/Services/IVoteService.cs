using BlazeVote.Data;

namespace BlazeVote.Services
{
    public interface IVoteService
    {
        public VoteGroup GenerateNewVoteGroup(string id = null);

        public VoteGroup GetVoteGroup(string id);
    }
}
