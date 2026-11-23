using System;

class Program
{
    static void Main(string[] args)
    {

        List<Video> _videos = new List<Video>();

        Video video1 = new Video("Gethsemane | October 2024 General Conference", "General Conference of The Church of Jesus Christ", 194);
        Comment gethsemane1 = new Comment("@The_Man_Chidi", "For every like or comment, I'll come back to listen. These are angels singing.");
        Comment gethsemane2 = new Comment("@dj-wurst", "Never in my life have I heard anything comparable to this childrens choir singing this beautiful hymn. You could hear the angels of the Lord singing with them!");
        Comment gethsemane3 = new Comment("@scottbergman1506", "I suspect that ALL of Heaven paused, listened and wept while these angels sang this praise to the Savior.");
        Comment gethsemane4 = new Comment("@MwendaMusa-pu2pq", "I will live this comment here so that whenever someone likes it, I come back to watch this video");
        video1.AddComment(gethsemane1);
        video1.AddComment(gethsemane2);
        video1.AddComment(gethsemane3);
        video1.AddComment(gethsemane4);
        _videos.Add(video1);

        Video video2 = new Video("Nearer, My God, to Thee", "The Church of Jesus Christ of Latter-day Saints", 228);
        Comment nearer1 = new Comment("@margaretkrings4807", "I had this played at my husbands funeral 3rd September 2021 he died from Alzheimers. I miss him terribly.I play this when visiting his grave and feel closer to him somehow ..We were together over 52 years.");
        Comment nearer2 = new Comment("@briangreen6927", "I am going to play this at my wife’s funeral, she was taken from my very suddenly on 5th April 2024, we were very happily married for over 63 1/2 years the only one. I miss her very much and her funeral is being held on 9th May 2024 bye bye my darling see you again sometime");
        Comment nearer3 = new Comment("@ThyraLouise", "”Gentlemen, it has been a privilege playing with you tonight.”");
        Comment nearer4 = new Comment("@markwinschibesa1776", "The song was my spiritual anthem during my time in prison and still is in times of trouble. After all problems bring us close to God. Thank you");
        video2.AddComment(nearer1);
        video2.AddComment(nearer2);
        video2.AddComment(nearer3);
        video2.AddComment(nearer4);
        _videos.Add(video2);

        Video video3 = new Video("Silent Night", "The Church of Jesus Christ of Latter-day Saints", 295);
        Comment silent1 = new Comment("@dhakshan", "The fact that a lot of non-christians (including me) like this song prove that music can transcend any boundaries");
        Comment silent2 = new Comment("@munalama9145", "If human beings can sing like this imagine how angels in heaven sing");
        Comment silent3 = new Comment("@mountrushmore6425", "I gave my wife an engagement ring and asked her to marry me on the second verse of this song Christmas Eve, 1986 at our church service.  We will celebrate our 34th engagement anniversary this week.  I love this song!");
        Comment silent4 = new Comment("@TienNguyen-ym5db", "I'm 23 years old and listening to this hymn again reminds me of my homeland and my childhood connected to my Catholic parish in Vietnam. Now I'm in Japan, I'm very lonely here. Hymns are a joy that comfort me when I'm sad and also strengthen my Catholic faith");
        video3.AddComment(silent1);
        video3.AddComment(silent2);
        video3.AddComment(silent3);
        video3.AddComment(silent4);
        _videos.Add(video3);

        Video video4 = new Video("A Piano’s Purpose", "The Church of Jesus Christ of Latter-day Saints", 494);
        Comment piano1 = new Comment("@ShannonJ-jz3kl", "I'm in tears. I don't know how it is possible to feel identified with a piano but this touched my heart.");
        Comment piano2 = new Comment("@dj-wurst", "I don't know why so many of you think this is sad.  That old, loved piano was resurrected and loved again, just as we will be.  Yes, I'm a pianist too");
        Comment piano3 = new Comment("@imaallex", "I don't know why but when The grandmothers doll fell out the box, I started to cry");
        Comment piano4 = new Comment("@FancyThatwithCandice", "As a pianist myself, this really touched my heart!!");
        video4.AddComment(piano1);
        video4.AddComment(piano2);
        video4.AddComment(piano3);
        video4.AddComment(piano4);
        _videos.Add(video4);

        foreach (Video video in _videos)
        {
            Console.WriteLine(video.GetValues());
            Console.WriteLine("");
        }




    }
}