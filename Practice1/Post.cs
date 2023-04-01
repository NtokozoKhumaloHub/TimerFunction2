using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    internal class Post
    {
        private static int NextID { get; set; }

        protected int Id { get; set; }
        protected string Title { get; set; }
        protected string Name { get; set; }
        protected bool IsPublic { get; set; }  

        public Post() { }

        public Post(string title, string name, bool IsPublic)
        {
            this.Id = GetNextId();
            this.IsPublic = IsPublic;
            this.Title = title;
            this.Name = name;
        }           

        public int GetNextId()
        {
            return ++NextID;
        }

        public override string ToString()
        {
            return String.Format($"{this.Id} - {this.Title} - {this.Name}");
        }

    }
}
