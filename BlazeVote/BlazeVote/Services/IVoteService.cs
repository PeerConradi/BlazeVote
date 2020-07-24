using BlazeVote.Data;

public interface IVoteService
{
    public VoteGroup GenerateNewVoteGroup();

    public VoteGroup GetVoteGroup();
}