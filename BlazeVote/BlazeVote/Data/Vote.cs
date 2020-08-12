using System.Linq;
using System.Collections.Generic;

namespace BlazeVote.Data
{

    public class Vote
    {
        public int VoteId { get; set; }

        public VoteQuestion Question { get; set; }

        public HiddenKey Key { get; set; }

        public List<string> Choises { get; set; }
    }

}