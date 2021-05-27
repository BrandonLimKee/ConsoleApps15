using System;
using System.Collections.Generic;
using System.Text;
using ConsoleAppProject.Helpers;

namespace ConsoleAppProject.App04
{
    public class NetworkApp
    {
        private NewsFeed news = new NewsFeed();

        //private String[] choices = { "Add Message", "Add Photo", "Display All", "Quit" };
        private String[] choices =
        {
                "Add Message",
                "Add Photo",
                "Display all",
                "Quit"
        };

        private string message;
        private string author;
        private string caption;
        private string filename;

        public void Run()
        {
            ConsoleHelper.OutputHeading("Social Netowrk");
            ConsoleHelper.SelectChoice(choices);
        }

        private void AddMessage()
        {
            Console.Write("\tPlease Enter Your Name: ");
            author = Console.ReadLine();
            
            Console.Write("\n\tPlease Enter Your Message: ");
            message = Console.ReadLine();

            MessagePost post = new MessagePost(author, message);
            news.AddMessagePost(post);

            post.Display();
        }
        private void AddPhoto()
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

    
    }
}
