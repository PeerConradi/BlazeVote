using System.Linq;
using System.Collections.Generic;

namespace BlazeVote.Data
{

    public class Vote
    {
        public int VoteId { get; set; }

        public HiddenKey Key { get; set; }

        /// <summary>
        /// List of options that this hidden Key has selected.
        /// Could be just one if only one option has been selected
        /// and also none if the user voted abstention!
        /// </summary>
        public List<string> Choises { get; set; }
    }

}