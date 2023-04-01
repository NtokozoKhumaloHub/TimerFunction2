using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Practice1
{
    internal class VideoPost : Post
    {
        public string videoURL { get; set; }
        public int Length { get; set; }
        public bool isPlaying = false;
        public int currDuration { get; set; }

        Timer timer;


        public VideoPost() { }
        public VideoPost(string title, string Name, string VideoURL, bool isPublec, int length) 
        {
            this.Id = GetNextId();
            this.Title = title;
            this.Name = Name;
            this.videoURL = VideoURL;
            this.IsPublic = isPublec;  
            this.Length = length;
        }

        public override string ToString()
        {
            return String.Format($"{this.Id} - {this.Title} - {this.videoURL} - {this.Name}");
        }

        public void Play()
        {
            if (!this.isPlaying)
            {
                this.isPlaying = true;
                Console.WriteLine("Playing");
                timer = new Timer(TimerCallback, null, 0, 1000);
            }
            
        }

        private void TimerCallback(object o)
        {
            if (currDuration < Length)
            {
                currDuration++;
                Console.WriteLine("Video at {0}", currDuration);
                GC.Collect();
            }else
            {
                Stop();
            }
        }
        public void Stop()
        {
            if (this.isPlaying)
            {
                this.isPlaying = false;
                Console.WriteLine("Stopped at {0}", currDuration);
                currDuration = 0;
                timer.Dispose();
            }
            
        }


    }
}
