using System;
using System.Collections.Generic;

namespace ConsoleAppProject.App04
{
    public class Post
    {
        public int PostId { get; set; }

        //username of the post's author
        public String Username { get; set; }
        public DateTime Timestamp { get; set; }

        public int likes;

        public readonly List<String> comments;

        

        /// <summary>
        /// The creator of a post
        /// </summary>
        public Post(String author)
        {
            this.Username = author;

            likes = 0;
            comments = new List<String>();

            this.Timestamp = DateTime.Now;
        }


        /// <summary>
        /// Record one more 'Like' indication from a user.
        /// </summary>
        public void Like()
        {
            likes++;
        }

        ///<summary>
        /// Record that a user has withdrawn his/her 'Like' vote.
        ///</summary>
        public void Unlike()
        {
            if (likes > 0)
            {
                likes--;
            }
        }

        ///<summary>
        /// Add a comment to this post.
        /// </summary>
        /// <param name="text">
        /// The new comment to add.
        /// </param>        
        public void AddComment(String text)
        {
            comments.Add(text);
        }
        ///<summary>
        /// Display the details of this post.
        /// 
        /// (Currently: Print to the text terminal. This is simulating display 
        /// in a web browser for now.)
        ///</summary>
        public virtual void Display()
        {
            Console.WriteLine();
            Console.WriteLine($"\tID:{PostId}");

            Console.WriteLine($"\tAuthor: {Username}");
            Console.WriteLine($"\tTime Elpased: {FormatElapsedTime(Timestamp)}");
            Console.WriteLine();

            if (likes > 0)
            {
                Console.WriteLine($"\tLikes:  {likes}  people like this.");
            }
            else
            {
                Console.WriteLine();
            }

            if (comments.Count == 0)
            {
                Console.WriteLine("\tNo comments.");
            }
            else
            {
                Console.WriteLine("\tComments\n");
                for(int i = 0; i < comments.Count; i++)
                {
                    Console.WriteLine($"\t{i+1}.{comments[i]}");
                }
            }
        }
        ///<summary>
        /// Create a string describing a time point in the past in terms 
        /// relative to current time, such as "30 seconds ago" or "7 minutes ago".
        /// Currently, only seconds and minutes are used for the string.
        /// </summary>
        /// <param name="time">
        ///  The time value to convert (in system milliseconds)
        /// </param> 
        /// <returns>
        /// A relative time string for the given time
        /// </returns>      
        private String FormatElapsedTime(DateTime time)
        {
            DateTime current = DateTime.Now;
            TimeSpan timePast = current - time;

            long seconds = (long)timePast.TotalSeconds;
            long minutes = seconds / 60;

            if (minutes > 0)
            {
                return minutes + " minutes ago";
            }
            else
            {
                return seconds + " seconds ago";
            }
        }
    }
}
