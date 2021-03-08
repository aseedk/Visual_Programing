using System;

namespace Quiz_2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        }

        public class WorkItem : object
        {
            public WorkItem()
            {
            }

            public WorkItem(int id, string title, TimeSpan jobLength)
            {
                Id = id;
                this.Title = title;
                this.JobLength = jobLength;
            }

            public int Id { get; set; }

            public string Title { get; set; }

            public TimeSpan JobLength { get; set; }

            public void Update()
            {
            }
        }

        public class ChangeRequest : WorkItem
        {
            public ChangeRequest()
            {
            }

            public ChangeRequest(int originalItemId)
            {
                OriginalItemId = originalItemId;
            }

            public ChangeRequest(int id, string title, TimeSpan jobLength, int originalItemId) : base(id, title,
                jobLength)
            {
                OriginalItemId = originalItemId;
            }

            public int OriginalItemId { get; set; }
        }
    }
}