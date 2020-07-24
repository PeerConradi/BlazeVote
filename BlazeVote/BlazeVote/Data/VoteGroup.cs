public class VoteGroup
{
    public string VoteGroupId { get; set; }

    public string Secret { get; set; }

    public List<PublicKey> PublicKeys { get; set; }

    public List<HiddenKey> HiddenKeys { get; set; }

    public List<VoteQuestion> Votes { get; set; }

    public VoteGroup()
    {
        PublicKeys = new List<PublicKey>();
        HiddenKeys = new List<HiddenKey>();
        Votes = new List<VoteQuestion>();
    }
}