// a social network application and want to add post creation functionality.
//As a user creates a post, the text "New post" should be automatically outputted so
//that then the user can add the text he/she wants to share.

using System;

namespace sololeran_csharp_practice.practice_programs
{
    class Social_network
    {
        static void Main(string[] args)
        {
            string postText = Console.ReadLine();

            Post post = new Post
            {
                Text = postText
            };
            post.ShowPost();

        }
    }

    class Post
    {
        private string text;

        //a constructor
        public Post()
        {
            Console.WriteLine("New post");
        }

        public void ShowPost()
        {
            Console.WriteLine(text);
        }

        //a property for member text
        public string Text
        {
            get { return text; }
            set { text = value; }
        }
    }
}
