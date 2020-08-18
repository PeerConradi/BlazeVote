using System.Collections.Generic;
using System;
using System.Linq;

namespace BlazeVote.Data
{
    public class VoteQuestion
    {
        public enum VoteStates
        {
            EDITING,
            OPEN,
            CLOSED,
            FINISHED
        }

        public string VoteQuestionId { get; set; }

        public string Question { get; set; }

        public VoteGroup Group { get; set; }

        public List<Answer> Options { get; set; }

        public List<Vote> Votes { get; set; }

        public bool AllowMultiple { get; set; }

        public DateTime OpenUntil { get; set; }

        public VoteStates State { get; set; } = VoteStates.EDITING;

        public Dictionary<Answer, int> CountVotes()
        {
            var dict = new Dictionary<Answer, int>();

            Options.ForEach(option =>
            {
                int count = 0;
                Votes.ForEach(vote =>
                {
                    if (vote.Choises.Any(n => n == option.AnswerId)) count++;
                });
                dict.Add(option, count);
            });

            return dict;
        }

        public VoteQuestion()
        {
            VoteQuestionId = Util.IdGenerator.RandomString(8);
            Options = new List<Answer>();
            Votes = new List<Vote>();
        }
    }
}