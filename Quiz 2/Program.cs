using System;

namespace Quiz_2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var workItem = new WorkItem();
            var changeRequest = new ChangeRequest();
            Console.WriteLine(workItem);
            Console.WriteLine(changeRequest);
        }

        public class WorkItem : object
        {
            public WorkItem()
            {
            }

            public WorkItem(int id, string title, TimeSpan jobLength)
            {
                Id = id;
                Title = title;
                JobLength = jobLength;
            }

            public int Id { get; set; }

            public string Title { get; set; }

            public TimeSpan JobLength { get; set; }

            public override string ToString()
            {
                return "I am in Work Item";
            }

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

            /*public override string ToString()
            {
                return "I am in Change Request";
            }*/

            public int OriginalItemId { get; set; }
        }
    }
}