using Microsoft.VisualBasic.CompilerServices;
using System.Collections.Generic;
using System.Collections.ObjectModel;


namespace BlazeVote.Data
{
    public class VoteGroup
    {
        public string VoteGroupId { get; set; }

        public string Secret { get; set; }

        public string Name { get; set; }

        /// <summary>
        /// The Public Keys can be seen by the admin. The user with the PublicKey and the VoteGroupId can
        /// generate a hidden Key that only him/her and the platform know.
        /// </summary>
        public List<PublicKey> PublicKeys { get; set; }

        /// <summary>
        /// HiddenKeys are only know to the platform. These are used to acutally vote.
        /// </summary>
        public List<HiddenKey> HiddenKeys { get; set; }

        public List<VoteQuestion> Votes { get; set; }

        public VoteGroup()
        {
            PublicKeys = new List<PublicKey>();
            HiddenKeys = new List<HiddenKey>();
            Votes = new List<VoteQuestion>();
            VoteGroupId = BlazeVote.Util.IdGenerator.RandomString(16);
            Secret = BlazeVote.Util.IdGenerator.RandomString(32);
        }
    }

}