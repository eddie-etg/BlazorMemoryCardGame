namespace MemoryFlipCardGame.Models
{
    public class Card
    {
        public string Id { get; set; }
        public int Value { get; set; }
        public bool IsFlipped { get; set; }
        public bool IsMatched { get; set; }
        public string FrontImage { get; set; }
        public string BackImage { get; set; }

        public Card(string id, int value, string frontImage, string backImage)
        {
            Id = id;
            Value = value;
            FrontImage = frontImage;
            BackImage = backImage;
        }
    }
    
}
