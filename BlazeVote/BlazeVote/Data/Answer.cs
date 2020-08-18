namespace BlazeVote.Data
{
    public class Answer
    {
        public string AnswerId { get; set; }

        public string Text { get; set; }

        public Answer()
        {
            AnswerId = Util.IdGenerator.RandomString(25);
        }
    }
}