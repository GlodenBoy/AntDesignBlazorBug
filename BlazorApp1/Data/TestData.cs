namespace BlazorApp1.Data
{
    public class TestData
    {

        public int Id { get; set; }
        public string Text { get; set; }

        public string Tips { get; set; }

        public DateTime Start { get; set; }

        public DateTime End { get; set; }

        public List<TestData> Children { get; set; }
    }
}
