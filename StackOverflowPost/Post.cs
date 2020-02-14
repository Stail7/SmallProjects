using System;

namespace StackOverflowPost {
    public class Post
    {
        /// <summary>
        /// Post title.
        /// </summary>
        public string Title { get; private set; }

        /// <summary>
        /// Post text.
        /// </summary>
        public string Description { get; private set; }

        /// <summary>
        /// Post creation time.
        /// </summary>
        public DateTime Created { get; private set; }

        /// <summary>
        /// Post vote count.
        /// </summary>
        public int Votes { get; private set; }
        
        public Post(string title, string description)
        {
            this.Title = title;
            this.Description = description;
            Created = DateTime.Now;
        }

        /// <summary>
        /// Up votes post +1.
        /// </summary>
        public void UpVote()
        {
            Votes += 1;
        }

        /// <summary>
        /// Down votes post -1.
        /// </summary>
        public void DownVote()
        {
            Votes -= 1;
        }

        /// <summary>
        /// Modifies post.
        /// </summary>
        public void Modify(string title, string description)
        {
            this.Title = title;
            this.Description = description;
            Created = DateTime.Now;
        }
    }
}