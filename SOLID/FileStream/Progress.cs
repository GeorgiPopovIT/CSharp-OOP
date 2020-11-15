namespace P01._FileStream_Before
{
    public class Progress
    {
        private readonly IResult file;

        public Progress(IResult file)
        {
            this.file = file;
        }

        public int CurrentPercent()
        {
            return this.file.Sent * 100 / this.file.Length;
        }
    }
}
