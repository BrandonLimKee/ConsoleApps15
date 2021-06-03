using System;
using System.Collections.Generic;


namespace ConsoleAppProject.App04
{
    ///<summary>
    /// The NewsFeed class stores news posts for the news feed in a social network 
    /// application.
    /// 
    /// Display of the posts is currently simulated by printing the details to the
    /// terminal. (Later, this should display in a browser.)
    /// 
    /// This version does not save the data to disk, and it does not provide any
    /// search or ordering functions.
    ///</summary>
    ///<author>
    ///  Michael Kölling and David J. Barnes
    ///  version 0.1
    ///</author> 
    public class NewsFeed
    {
        private  List<Post> postList;
        private int max;



        ///<summary>
        /// Construct an empty news feed.
        ///</summary>
        public NewsFeed()
        {
            postList = new List<Post>();
            //MessagePost message = new MessagePost("Brandon", "Hello")
            //{
            //    PostId = 1
            //};

            //postList.Add(message);

            //PhotoPost photo = new PhotoPost("John", "Photo.jpg", "My Dog")
            //{
            //    PostId = 2,

            //};

            //postList.Add(photo);
        }


        ///<summary>
        /// Add a text post to the news feed.
        /// 
        /// @param text  The text post to be added.
        ///</summary>
        public void AddMessagePost(MessagePost message)
        {  
            if(postList == null)
            {
                message.PostId = 1;
            }
            else
            {
                foreach (Post post in postList)
                {
                     max = post.PostId;
                    if (max < post.PostId)
                    {
                        max = post.PostId;
                    }
                }

                message.PostId = max + 1;
            }
            postList.Add(message);
        }

        ///<summary>
        /// Add a photo post to the news feed.
        /// 
        /// @param photo  The photo post to be added.
        ///</summary>
        public void AddPhotoPost(PhotoPost photo)
        {
            if (postList == null)
            {
                photo.PostId = 1;
            }
            else
            {
                foreach (Post post in postList)
                {
                    max = post.PostId;
                    if (max < post.PostId)
                    {
                        max = post.PostId;
                    }
                }

                photo.PostId = max + 1;
            }
            postList.Add(photo);
        }

        ///<summary>
        /// Show the news feed. Currently: print the news feed details to the
        /// terminal. (To do: replace this later with display in web browser.)
        ///</summary>
        public void Display()
        {
            // display all text posts
            foreach (Post post in postList)
            {
                post.Display();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\t---------------------");   // space between posts
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
            }
        }

        public void DisplayUsersPost(string author)
        {
            foreach(Post post in postList)
            {
                if(post.Username == author)
                {
                    post.Display();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\t---------------------");   // space between posts
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                }
            }
        }

        public Post FindPost(int id)
        {
           return postList[id - 1];
        }

        public void RemovePost(int id)
        {
            Post post = FindPost(id);
            postList.Remove(post);
        }



    }

}
