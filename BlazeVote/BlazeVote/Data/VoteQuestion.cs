using System.Collections.Generic;
using System;

namespace BlazeVote.Data
{
    public class VoteQuestion
    {

        public int VoteId { get; set; }

        public string Question { get; set; }

        public VoteGroup Group { get; set; }

        public List<string> Answers { get; set; }

        public List<Vote> Votes { get; set; }

        public bool AllowMultiple { get; set; }

        public DateTime OpenUntil { get; set; }

        public Dictionary<string, int> CountVotes()
        {
            var dict = new Dictionary<string, int>();

            Answers.ForEach(option =>
            {
                int count = 0;
                Votes.ForEach(vote =>
                {
                    if (vote.Choises.Contains(option)) count++;
                });
                dict.Add(option, count);
            });

            return dict;
        }
    }
}