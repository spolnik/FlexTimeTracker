using System;
using System.Xml.Serialization;

namespace FlexTimeTracker
{
    [Serializable]
    public class FlexTaskEntity
    {
        public FlexTaskEntity()
        {
            this.Duration = new TimeSpan(0, 0, 0);
            this.CreatedOn = DateTime.Now.Date;
        }

        public string Name { get; set; }

        [XmlIgnore]
        public TimeSpan Duration { get; private set; }

        public DateTime CreatedOn { get; set; }

        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        public void TickOneSecond()
        {
            this.Duration += TimeSpan.FromSeconds(1);
            this.Hours = this.Duration.Hours;
            this.Minutes = this.Duration.Minutes;
            this.Seconds = this.Duration.Seconds;
        }
    }
}