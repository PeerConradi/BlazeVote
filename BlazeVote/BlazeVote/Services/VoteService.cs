using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazeVote.Data;

namespace BlazeVote.Services
{
    public class VoteService : IVoteService
    {
        private List<VoteGroup> _voteGroups = new List<VoteGroup>();

        public VoteGroup GenerateNewVoteGroup(string id = null)
        {
            var group = new VoteGroup();
            // Allows the user to give a custom vote Group id by the given value if its available
            if (id != null)
            {
                if (!_voteGroups.Any(n => n.VoteGroupId == id))
                    group.VoteGroupId = id;
            }
                
            return group;
        }

        public VoteGroup GetVoteGroup(string id)
        {
            return _voteGroups.FirstOrDefault(n => n.VoteGroupId == id);
        }

        public PublicKey GeneratePublicKey(VoteGroup group)
        {
            var key = new PublicKey();
            key.IsRegistered = false;
            key.PublicKeyId = Util.IdGenerator.RandomString(25);
            group.PublicKeys.Add(key);
            return key;
        }

        public HiddenKey GenerateHiddenKey(VoteGroup group, string publicKey)
        {
            var publicKeyElement = group.PublicKeys.FirstOrDefault(n => n.PublicKeyId == publicKey);
            if (publicKeyElement == null || publicKeyElement.IsRegistered)
                return null;

            publicKeyElement.IsRegistered = true;
            var hiddenKey = new HiddenKey();
            hiddenKey.HiddenKeyId = Util.IdGenerator.RandomString(32);
            return hiddenKey;
        }
    }
}
