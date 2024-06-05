namespace Day33Concepts
{
    public class OverRideToStringExamples
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        
        public override string ToString()
        {
            return this.firstName + " " + this.lastName;
        }
    }

    public class ConvertToStringAndToStringExamples
    {
        public string name { get; set; }
    }
}
