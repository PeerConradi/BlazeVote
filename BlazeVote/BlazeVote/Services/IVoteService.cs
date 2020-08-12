using BlazeVote.Data;

public interface IVoteService
{
    public VoteGroup GenerateNewVoteGroup(string id = null);

    public VoteGroup GetVoteGroup(string id);
}