using System;
using ConsoleAppProject.Helpers;

namespace ConsoleAppProject.App04
{
    public class NetworkApp
    {
        private NewsFeed news = new NewsFeed();


        private String[] choices =
        {
                "Post Message",
                "Post Photo",
                "Display all",
                "Comment",
                "Like",
                "Unlike",
                "Remove Post",
                "Display Users Post",
                "Quit"

        };

        private string message;
        private string author;
        private string caption;
        private string filename;
        private bool quit;

        public void Run()
        {
            quit = false;
            do
            {
                ConsoleHelper.OutputHeading("Social Network");
                int choice = ConsoleHelper.SelectChoice(choices);
                switch (choice)
                {
                    case 1: PostMessage(); break;
                    case 2: PostPhoto(); break;
                    case 3: DisplayAll(); break;
                    case 4: AddComment(); break;
                    case 5: LikePost(); break;
                    case 6: UnlikePost(); break;
                    case 7: RemovePost(); break;
                    case 8: DisplayUsersPost(); break;
                    case 9: quit = true; break;
                }
            } while (!quit);
            
        }

        private void DisplayUsersPost()
        {
            Console.Write("\n\tPlease enter a Username: ");
            author = Console.ReadLine();

            ConsoleHelper.OutputTitle($"Displaying {author}'s Post");
            news.DisplayUsersPost(author);
        }

        private void DisplayAll()
        {
            ConsoleHelper.OutputTitle("Displaying All Posts");
            news.Display();
        }

        private void PostMessage()
        {
            Console.Write("\n\tPlease Enter Your Name: ");
            author = Console.ReadLine();
            
            Console.Write("\n\tPlease Enter Your Message: ");
            message = Console.ReadLine();

            MessagePost post = new MessagePost(author, message);
            news.AddMessagePost(post);

            ConsoleHelper.OutputTitle("Message Posted");
        }
        private void PostPhoto()
        {
            Console.Write("\n\tPlease Enter Your Name: ");
            author = Console.ReadLine();
            
            Console.Write("\n\tPlease Enter Your Photo filename: ");
            filename = Console.ReadLine();
            
            Console.Write("\n\tPlease Enter Your Caption: ");
            caption = Console.ReadLine();

            PhotoPost post = new PhotoPost(author, filename,caption);
            news.AddPhotoPost(post);

            ConsoleHelper.OutputTitle("Photo Posted");
        }
       
        private void RemovePost()
        {
            ConsoleHelper.OutputTitle("Removing Post");

            int id = (int)ConsoleHelper.InputNumber("\tPlease Enter The Post ID: ");
            Post post = news.FindPost(id);

            if(post!= null)
            {
                Console.WriteLine($"\tRemoving Post Number {post.PostId}");
                news.RemovePost(id);
            }
            else
            {
                Console.WriteLine("\tPost Number Does Not Exsist");
            }

            ConsoleHelper.OutputTitle("Post Removed");
        }

        private void AddComment()
        {
            int id = (int)ConsoleHelper.InputNumber("\n\tPlease Enter The ID of the Post you wish to Comment on: ");
            Post post = news.FindPost(id);

            if (post != null)
            {
                Console.Write("\n\tPlease Enter Your Comment: ");
                string comment = Console.ReadLine();
                post.AddComment(comment);
            }
            else
            {
                Console.WriteLine("Post Number Does Not Exsist");
            }

            ConsoleHelper.OutputTitle("Comment Added");
        }

        private void LikePost()
        {
            int id = (int)ConsoleHelper.InputNumber("\n\tPlease Enter The ID of the Post you wish to Like: ");
            Post post = news.FindPost(id);

            post.Like();
        }
        private void UnlikePost()
        {
            int id = (int)ConsoleHelper.InputNumber("\n\tPlease Enter The ID of the Post you wish to Unlike: ");
            Post post = news.FindPost(id);

            post.Unlike();
        }
    
    }
}
