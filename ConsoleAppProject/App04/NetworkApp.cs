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
                "Remove Post"
                
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
                    case 4: RemovePost(); break;
                    case 5: quit = true; break;
                }
            } while (!quit);
            
        }

        private void DisplayAll()
        {
            news.Display();
        }

        private void PostMessage()
        {
            Console.Write("\tPlease Enter Your Name: ");
            author = Console.ReadLine();
            
            Console.Write("\n\tPlease Enter Your Message: ");
            message = Console.ReadLine();

            MessagePost post = new MessagePost(author, message);
            news.AddMessagePost(post);

            post.Display();
        }
        private void PostPhoto()
        {
            Console.Write("\tPlease Enter Your Name: ");
            author = Console.ReadLine();
            
            Console.Write("\n\tPlease Enter Your Photo filename: ");
            message = Console.ReadLine();
            
            Console.Write("\n\tPlease Enter Your Caption: ");
            caption = Console.ReadLine();

            PhotoPost post = new PhotoPost(author, filename,caption);
            news.AddPhotoPost(post);

            post.Display();
        }

        

        private void RemovePost()
        {
            ConsoleHelper.OutputTitle("Removing Post");

            int id = (int)ConsoleHelper.InputNumber("Please Enter The Post ID");
            Post post = news.FindPost(id);

            if(post!= null)
            {
                Console.WriteLine($"Removing Post Number {post.PostId}");
                news.RemovePost(id);
            }
            else
            {
                Console.WriteLine("Post Number Does Not Exsist");
            }
        }

    
    }
}
