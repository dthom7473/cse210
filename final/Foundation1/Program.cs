class Program
{
    static void Main()
    {
        var video1 = new Video("How to Make a YouTube Comment Program", "dthom1", 610/60);
        var video2 = new Video("Five Nights At Freddy's pt One", "Markiplier", 1500/60);
        var video3 = new Video("69 Reasons Why AI Will Take Over Southern California", "BeAware", 18540/60);

        video1.AddComment(new Comment("Jorge", "Well this was a dumb video"));
        video1.AddComment(new Comment("Weeb420", "First!"));
        video1.AddComment(new Comment("Gregory", "First"));

        video2.AddComment(new Comment("RyanWazHere", "part two when?"));
        video2.AddComment(new Comment("Willian Afton", "I Always Come Back"));
        video2.AddComment(new Comment("JustAnAverageGuy", "I wish I could be a youtuber"));
        video2.AddComment(new Comment("GetALife", "He liked my comment! Edit: Mom I'm Famous!!"));

        video3.AddComment(new Comment("DeletedAccount", "first"));
        video3.AddComment(new Comment("TheRealGoku", "Don'y say first it's cringy"));
        video3.AddComment(new Comment("DeletedAccount", "Don't*"));
        video3.AddComment(new Comment("JustWondering", "Do you actually read these??"));
        
        var videos = new List<Video> {video1, video2, video3};

        foreach (var video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}
