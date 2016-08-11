using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using dgTvSvc.Models;
using Dapper;
using System.Data.SqlClient;

namespace dgTvSvc.data
{
    public class EpisodeRepository
    {

        public IEnumerable<Episode> GetAllEpisode()
        {

            var connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\development\dgtv\dgtvSvc\dgTvSvc\App_Data\dgtvdb.mdf;Integrated Security=True";
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();

                var sql = "Select * from Episodes";

                //var cmd = conn.CreateCommand();
                //cmd.CommandText = sql;

                //cmd.CommandType = System.Data.CommandType.Text;

                //var results = cmd.ExecuteReader();

                return conn.Query<Episode>(sql);

            }

        }

        public Episode GetEpisodeById(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Episode> GetMockEpisodes()
        {
            List<Episode> episodeList = new List<Episode>();

            episodeList.Add(new Episode()
            {
                Id = 440,
                Title = "Bridget Kromhout on CloudFoundry",
                Description = @"
            <p>Bridget Kromhout describes CloudFoundry - an open source project that assists companies managing DevOps by abstracting away the cloud provider or host on which applications are deployed.</p>
            ",
                Location = "Orlando, FL",
                DateRecorded = Convert.ToDateTime("2016-07-19"),
                VideoUrl = "https://channel9.msdn.com/Blogs/Technology-and-Friends/tf437/player",
                VideoPlayer = "https://channel9.msdn.com/Blogs/Technology-and-Friends/tf437/player",
                LowResVideo = "http://video.ch9.ms/ch9/2ba5/0a3f6140-8776-41d4-9942-4bbdbb502ba5/tf440.mp4",
                HighResVideo = "http://video.ch9.ms/ch9/2ba5/0a3f6140-8776-41d4-9942-4bbdbb502ba5/tf440_high.mp4",
                Guests = new string[]
                    { "Bridget Kromhout" },
                Links = new Link[]
                    { new Link()
                        {
                        Url = "http://bridgetkromhout.com/",
                        Title = "Bridget's blog"}
                    },
                EpisodeNumber = 440,
            }
        );

            episodeList.Add(new Episode()
            {
                Id = 439,
                Title = "Adam Granicz on WebSharper",
                Description = @"
            <p> Adam Granicz discusses WebSharper - a tool that allows you to write F# code to create web applications - generating both client-side and server-side code.
            @",
                Location = "Chicago, IL",
                DateRecorded = Convert.ToDateTime("2016-06-28"),
                VideoUrl = "https://channel9.msdn.com/Blogs/Technology-and-Friends/tf437/player",
                VideoPlayer = "https://channel9.msdn.com/Blogs/Technology-and-Friends/tf437/player",
                LowResVideo = "http://video.ch9.ms/ch9/866d/ee4b71dc-9333-41ae-ba8f-f0614979866d/tf439.mp4",
                HighResVideo = "http://video.ch9.ms/ch9/866d/ee4b71dc-9333-41ae-ba8f-f0614979866d/tf439_high.mp4",
                Guests = new string[]
                    { "Adam Granicz" },
                Links = new Link[]
                    { new Link()
            {
                        Url = "http://websharper.com/",
                        Title = "WebSharper home"
                    }
                    },

                EpisodeNumber = 439
            }
                    );

            episodeList.Add(new Episode()
            {
                Id = 438,
                Title = "Angela Dugan on Project Retrospectives",
                Description = @"
        <div>
             <p> Angela Dugan discusses the role of a Project Retrospective and how it can improve the quality of your software.</p>
            </div>
        ",
                Location = "Chicago, IL",
                DateRecorded = Convert.ToDateTime("2016-06-15"),
                VideoUrl = "https://channel9.msdn.com/Blogs/Technology-and-Friends/tf437/player",
                VideoPlayer = "https://channel9.msdn.com/Blogs/Technology-and-Friends/tf437/player",
                LowResVideo = "http://video.ch9.ms/ch9/866d/ee4b71dc-9333-41ae-ba8f-f0614979866d/tf439.mp4",
                HighResVideo = "http://video.ch9.ms/ch9/120b/e5d84a14-9692-489a-b44a-d8759373120b/tf438_high.mp4",
                Guests = new string[]
                { "Angela Dugan" },
                Links = new Link[]
                    {
                        new Link()
                            {
                                Url = "https://twitter.com/oakparkgirl",
                                Title = "Angela on Twitter"
                            },
                     new Link()
                        {
                            Url = "http://www.slideshare.net/angelabinkowski",
                            Title = "Angela's slides"
                        }
                    },
                EpisodeNumber = 438,
            }
                    );


            episodeList.Add(new Episode()
            {
                Id = 437,
                Title = "Shawn Wildermuth on the Hello World Road Trip",
                Description = @"
                    <p> Since 2013, Shawn Wildermuth has been recording his 'Hello World' podcast - asking programmers how they got started in technology.Recently, he went on the road and scheduled interviews in different cities around the world.Shawn describes the experience of traveling, shares some of the stories of his trip and interviews, and reveals how he plans to end the show. </p>
                    ",
                Location = "Chicago, IL",
                DateRecorded = Convert.ToDateTime("2016-06-15"),
                VideoUrl = "https://channel9.msdn.com/Blogs/Technology-and-Friends/tf437/player",
                VideoPlayer = "https://channel9.msdn.com/Blogs/Technology-and-Friends/tf437/player",
                LowResVideo = "http://video.ch9.ms/ch9/68fb/0845d81a-c219-4b4e-88e0-20a67f3b68fb/tf437.mp4",
                HighResVideo = "http://video.ch9.ms/ch9/68fb/0845d81a-c219-4b4e-88e0-20a67f3b68fb/tf437_high.mp4",
                Guests = new string[]
                            { "Shawn Wildermuth" },
                Links = new Link[]
                    {
                        new Link()
                            {
                                Url = "http://www.hwroadtrip.com/",
                                Title = "Hello World Road Trip"
                            },
                     new Link()
                        {
                            Url = "https://wildermuth.com/hwpod",
                            Title = "Hello World podcast"
                        }
                    },
                EpisodeNumber = 437,
            }
        );

            episodeList.Add(new Episode()
            {
                Id = 436,
                Title = "Kevin Remde on Security and Windows 10",
                Description = @"
                        <p> Microsoft Technical Evangelist Kevin Remde tells us how Windows 10 makes your data more secure.</p>
                    ",
                Location = "Bloomington, MN",
                DateRecorded = Convert.ToDateTime("2016-06-15"),
                DateReleased = Convert.ToDateTime("2016-07-15"),
                VideoUrl = "https://channel9.msdn.com/Blogs/Technology-and-Friends/tf436",
                VideoPlayer = "https://channel9.msdn.com/Blogs/Technology-and-Friends/tf436/player",
                LowResVideo = "http://video.ch9.ms/ch9/1254/cfc2f5a1-11c0-449f-bd14-9d29e2f21254/tf436.mp4",
                HighResVideo = "http://video.ch9.ms/ch9/1254/cfc2f5a1-11c0-449f-bd14-9d29e2f21254/tf436_high.mp4",
                Guests = new string[]
                            { "Kevin Remde" },
                Links = new Link[]
                    {
                        new Link()
                            {
                                Url = "https://blogs.technet.microsoft.com/kevinremde/",
                                Title = "Kevin's blog"
                            },
                        new Link()
                            {
                                Url = "https://www.facebook.com/KevinRemdeIsFullOfIT/",
                                Title = "Kevin on Facebook"
                            },
                     new Link()
                        {
                            Url = "https://twitter.com/kevinremde",
                            Title = "Kevin on Twitter"
                        }
                    },
                EpisodeNumber = 436,
            }
        );


            episodeList.Add(new Episode()
            {
                Id = 435,
                Title = "Kassandra Perch on Auth0",
                Description = @"
                        <p> Kassandra Perch describes how to use Auth0 to quickly add authentication to your applications </p>
                    ",
                Location = "Bloomington, MN",
                DateRecorded = Convert.ToDateTime("2016-06-15"),
                DateReleased = Convert.ToDateTime("2016-07-15"),
                VideoUrl = "https://channel9.msdn.com/Blogs/Technology-and-Friends/tf435",
                VideoPlayer = "https://channel9.msdn.com/Blogs/Technology-and-Friends/tf435/player",
                LowResVideo = "http://video.ch9.ms/ch9/8500/037cb80a-f5d0-431c-ac59-b18eedb58500/tf435.mp4",
                HighResVideo = "http://video.ch9.ms/ch9/8500/037cb80a-f5d0-431c-ac59-b18eedb58500/tf435_high.mp4",
                Guests = new string[]
                            { "Kassandra Perch" },
                Links = new Link[]
                    {
                        new Link()
                            {
                                Url = "https://auth0.com/",
                                Title = "Auth0 home"
                            },
                        new Link()
                            {
                                Url = "https://jwt.io/",
                                Title = "JSON Web Tokens"
                            },
                        new Link()
                            {
                                Url = "https://twitter.com/nodebotanist",
                                Title = "Kassandra on Twitter"
                            },
                     new Link()
                        {
                            Url = "http://openid.net/",
                            Title = "Open ID"
                        }
                    },
                EpisodeNumber = 435,
            }
        );


            episodeList.Add(new Episode()
            {
                Id = 434,
                Title = "Jakub Jedryszek on the Azure Portal",
                Description = @"
                        <p> Jakub Jedryszek describes what went into creating the Azure Portal </p><p> Links:</p>
                    ",
                Location = "Bloomington, MN",
                DateRecorded = Convert.ToDateTime("2016-06-15"),
                DateReleased = Convert.ToDateTime("2016-07-15"),
                VideoUrl = "https://channel9.msdn.com/Blogs/Technology-and-Friends/tf434",
                VideoPlayer = "https://channel9.msdn.com/Blogs/Technology-and-Friends/tf434/player",
                LowResVideo = "http://video.ch9.ms/ch9/866d/ee4b71dc-9333-41ae-ba8f-f0614979866d/tf439.mp4",
                HighResVideo = "http://video.ch9.ms/ch9/9148/5305b4e6-ab17-42fb-8981-86d7cc719148/tf434_high.mp4",
                Guests = new string[]
                            { "Jakub Jedryszek" },
                Links = new Link[]
                    {
                        new Link()
                            {
                                Url = "http://aka.ms/azureportalfeedback",
                                Title = "Azure Portal feedback"
                            },
                        new Link()
                            {
                                Url = "http://youtube.com/jakubjedryszek",
                                Title = "Jakub's videos"
                            },
                        new Link()
                            {
                                Url = "http://aka.ms/azuretipsandtricks",
                                Title = "Azure Tips and Tricks"
                            },
                     new Link()
                        {
                            Url = "http://jj09.net/",
                            Title = "Jakub's blog"
                        }
                    },
                EpisodeNumber = 434,
            }
                                    );

            episodeList.Add(new Episode()
            {
                Id = 433,
                Title = "Mike Benkovich on Visual Studio Team Services",
                Description = "<p>Mike Benkovich describes the power of Visual Studio Team Services to manage the source code, testing, and deployment of applications. </p>",
                Location = "Bloomington, MN",
                DateRecorded = Convert.ToDateTime("2016-06-15"),
                DateReleased = Convert.ToDateTime("2016-07-15"),
                VideoUrl = "https://channel9.msdn.com/Blogs/Technology-and-Friends/tf433",
                VideoPlayer = "https://channel9.msdn.com/Blogs/Technology-and-Friends/tf433/player",
                LowResVideo = "http://video.ch9.ms/ch9/866d/ee4b71dc-9333-41ae-ba8f-f0614979866d/tf439.mp4",
                HighResVideo = "",
                Guests = new string[]
                            { "Mike Benkovich" },
                Links = new Link[]
                                {
                                         new Link()
                        {
                            Url = "http://www.benkotips.com",
                            Title = "Mike's blog"
                        }
                                         },
                EpisodeNumber = 433,
            }
                                );

            episodeList.Add(new Episode()
            {
                Id = 432,
                Title = "Rocky Lhotka and Jason Bock on Open Source",
                Description = "<p>Rocky Lhotka and Jason Bock of Magenic discuss the history of open source software and their contributions to it.</p>",
                Location = "Bloomington, MN",
                DateRecorded = Convert.ToDateTime("2016-06-15"),
                DateReleased = Convert.ToDateTime("2016-07-15"),
                VideoUrl = "https://channel9.msdn.com/Blogs/Technology-and-Friends/tf432",
                VideoPlayer = "https://channel9.msdn.com/Blogs/Technology-and-Friends/tf432/player",
                LowResVideo = "http://video.ch9.ms/ch9/866d/ee4b71dc-9333-41ae-ba8f-f0614979866d/tf439.mp4",
                HighResVideo = "",
                Guests = new string[]
                            { "Rocky Lhotka", "Jason Bock" },
                Links = new Link[]
                    {
                        new Link()
                            {
                                Url = "http://jasonbock.net/",
                                Title = "Jason's blog"
                            },
                        new Link()
                            {
                                Url = "https://twitter.com/jasonbock",
                                Title = "Jason on Twitter"
                            },
                        new Link()
                            {
                                Url = "https://github.com/jasonbock",
                                Title = "Jason's GitHub repo"
                            },
                        new Link()
                            {
                                Url = "http://lhotka.net/",
                                Title = "Rocky's blog"
                            },
                     new Link()
                        {
                            Url = "https://twitter.com/rockylhotka",
                            Title = "Rocky on Twitter"
                        },
                new Link()
                {
                    Url = "https://github.com/rockfordlhotka",
                        Title = "Rocky's GitHub repo"
                    }
            },
                EpisodeNumber = 432,
            }
            );

            episodeList.Add(new Episode()
            {
                Id = 431,
                Title = "Jason Farrell on Xamarin Test Cloud",
                Description = "<p>Jason Farrell describes how he uses Xamarin Test Cloud to test his mobile application on multiple hardware configurations. </p>",
                Location = "Downers Grove, IL",
                DateRecorded = Convert.ToDateTime("2016-06-15"),
                DateReleased = Convert.ToDateTime("2016-07-15"),
                VideoUrl = "https://channel9.msdn.com/Blogs/Technology-and-Friends/tf431",
                VideoPlayer = "https://channel9.msdn.com/Blogs/Technology-and-Friends/tf431/player",
                LowResVideo = "http://video.ch9.ms/ch9/866d/ee4b71dc-9333-41ae-ba8f-f0614979866d/tf439.mp4",
                HighResVideo = "",
                Guests = new string[]
                            { "Jason Farrell" },
                Links = new Link[]
                    {
                        new Link()
                            {
                                Url = "https://testcloud.xamarin.com/",
                                Title = "Test Cloud home"
                            },
                        new Link()
                            {
                                Url = "https://jfarrell.net/",
                                Title = "Jason's blog"
                            },
                        new Link()
                            {
                                Url = "http://chicagocoderconference.com/",
                                Title = "Chicago Coder Conference"
                            }
                    },
                EpisodeNumber = 431,
            }
                                );


            episodeList.Add(new Episode()
            {
                Id = 430,
                Title = "Lwin and Min Maung on Microcontrollers",
                Description = "<p>Brothers Min and Lwin Maung describe the uses of microcontrollers, the projects they have built, and how to get started. </p>",
                Location = "Downers Grove, IL",
                DateRecorded = Convert.ToDateTime("2016-06-15"),
                DateReleased = Convert.ToDateTime("2016-07-15"),
                VideoUrl = "https://channel9.msdn.com/Blogs/Technology-and-Friends/tf430",
                VideoPlayer = "https://channel9.msdn.com/Blogs/Technology-and-Friends/tf430/player",
                LowResVideo = "http://video.ch9.ms/ch9/866d/ee4b71dc-9333-41ae-ba8f-f0614979866d/tf439.mp4",
                HighResVideo = "",
                Guests = new string[]
                            { "Lwin Maung", "Min Maung" },
                Links = new Link[] { },
                EpisodeNumber = 430,
            }
);

            episodeList.Add(new Episode()
            {
                Id = 429,
                Title = "George Saadeh on Angular 2",
                Description = "<p>Angular 2 is now in RC and George Saadeh is using it to build production applications. George discusses the advantages of Angular 2, its connection with NativScript, and how to get started writing apps.</p>",
                Location = "Cluj-Napoca, Romania",
                DateRecorded = Convert.ToDateTime("2016-06-15"),
                DateReleased = Convert.ToDateTime("2016-07-15"),
                VideoUrl = "https://channel9.msdn.com/Blogs/Technology-and-Friends/tf429",
                VideoPlayer = "https://channel9.msdn.com/Blogs/Technology-and-Friends/tf429/player",
                LowResVideo = "http://video.ch9.ms/ch9/08db/d0a33b76-7701-4199-9492-0627f3d008db/tf429.mp4",
                HighResVideo = "http://video.ch9.ms/ch9/08db/d0a33b76-7701-4199-9492-0627f3d008db/tf429_high.mp4",
                Guests = new string[]
                                { "George Saadeh" },
                Links = new Link[]
                    {
                        new Link()
                            {
                                Url = "https://angular.io/",
                                Title = "Angular 2 home"
                            },
                        new Link()
                            {
                                Url = "http://blog.falafel.com/",
                                Title = "Falafel blog"
                            }
                    },
                EpisodeNumber = 429,
            }
        );

            episodeList.Add(new Episode()
            {
                Id = 428,
                Title = "Jayson Street on Security Threats",
                Description = "<p>Jayson Street discusses the scariest threats to network security, how he protects organization, and why hackers are not bad people.</p>",
                Location = "Cluj-Napoca, Romania",
                DateRecorded = Convert.ToDateTime("2016-06-15"),
                DateReleased = Convert.ToDateTime("2016-07-15"),
                VideoUrl = "https://channel9.msdn.com/Blogs/Technology-and-Friends/tf428",
                VideoPlayer = "https://channel9.msdn.com/Blogs/Technology-and-Friends/tf428/player",
                LowResVideo = "http://video.ch9.ms/ch9/8e7f/6413c6ae-ac73-4560-beb2-0a3139328e7f/tf428.mp4",
                HighResVideo = "http://video.ch9.ms/ch9/8e7f/6413c6ae-ac73-4560-beb2-0a3139328e7f/tf428_high.mp4",
                Guests = new string[]
                                { "Jayson Street" },
                Links = new Link[] { },
                EpisodeNumber = 428,
            }
                                    );
            episodeList.Add(new Episode()
            {
                Id = 427,
                Title = "Laurent Ellerbach on an IoT Garden",
                Description = "<p>Laurent Ellerbach describes how he built a smart garden using hardware, such as Arduinos and Raspberry Pis and connecting to Azure IoT hubs.</p>",
                Location = "Cluj-Napoca, Romania",
                DateRecorded = Convert.ToDateTime("2016-06-15"),
                DateReleased = Convert.ToDateTime("2016-07-15"),
                VideoUrl = "https://channel9.msdn.com/Blogs/Technology-and-Friends/tf427",
                VideoPlayer = "https://channel9.msdn.com/Blogs/Technology-and-Friends/tf427/player",
                LowResVideo = "http://video.ch9.ms/ch9/3495/16794005-09b1-43b3-a5a7-b2d3ad4e3495/tf429.mp4",
                HighResVideo = "http://video.ch9.ms/ch9/3495/16794005-09b1-43b3-a5a7-b2d3ad4e3495/tf429_high.mp4",
                Guests = new string[]
                                { "Laurent Ellerbach" },
                Links = new Link[]
                    {
                        new Link()
                            {
                                Url = "https://blogs.msdn.microsoft.com/laurelle",
                                Title = "Laurent's blog"
                            },
                        new Link()
                            {
                                Url = "https://github.com/ellerbach",
                                Title = "Laurent's GitHub"
                            },
                        new Link()
                            {
                                Url = "https://github.com/Azure",
                                Title = "Azure on GitHub"
                            }
                    },
                EpisodeNumber = 427,
            }
                                    );
            episodeList.Add(new Episode()
            {
                Id = 426,
                Title = "Raffaele Rialdi on Security in ASP.NET Core",
                Description = "<p>ASP.NET core is a complete rewrite of the previous version. One big change is the inclusion of claims-based authorization. Raffaele Rialdi explains how it works.</p>",
                Location = "Cluj-Napoca, Romania",
                DateRecorded = Convert.ToDateTime("2016-06-15"),
                DateReleased = Convert.ToDateTime("2016-07-15"),
                VideoUrl = "https://channel9.msdn.com/Blogs/Technology-and-Friends/tf426",
                VideoPlayer = "https://channel9.msdn.com/Blogs/Technology-and-Friends/tf426/player",
                LowResVideo = "http://video.ch9.ms/ch9/9016/51793ec1-75f4-4cd9-918f-4f8b1e649016/tf426.mp4",
                HighResVideo = "http://video.ch9.ms/ch9/9016/51793ec1-75f4-4cd9-918f-4f8b1e649016/tf426_high.mp4",
                Guests = new string[]
                                { "Raffaele Rialdi" },
                Links = new Link[]
                    {
                        new Link()
                            {
                                Url = "https://twitter.com/raffaeler",
                                Title = "Raffael on Twitter"
                            },
                        new Link()
                            {
                                Url = "https://docs.asp.net/en/latest",
                                Title = "ASP.NET Core home"
                            }
                    },
                EpisodeNumber = 426,
            }
                                    );

            episodeList.Add(new Episode()
            {
                Id = 425,
                Title = "J Tower on Extreme Remote Working",
                Description = @"<p> In 2014, J Tower bought an RV, rented out his home in Grand Rapids, MI, and traveled to each of the lower 48 states.His wife took a leave of absence from her job to home school their 2 children, but J kept working while traveling.He recounts his adventures, his preparation, and the challenges in this interview. </p>",
                Location = "Chicago, IL",
                DateRecorded = Convert.ToDateTime("2016-06-15"),
                DateReleased = Convert.ToDateTime("2016-07-15"),
                VideoUrl = "https://channel9.msdn.com/Blogs/Technology-and-Friends/tf425",
                VideoPlayer = "https://channel9.msdn.com/Blogs/Technology-and-Friends/tf425/player",
                LowResVideo = "http://video.ch9.ms/ch9/15a5/ab602470-95d7-486b-b718-80d24c9f15a5/tf425.mp4",
                HighResVideo = "http://video.ch9.ms/ch9/15a5/ab602470-95d7-486b-b718-80d24c9f15a5/tf425_high.mp4",
                Guests = new string[]
                                { "J Tower" },
                Links = new Link[]
                                    { new Link()
                            { Url = "http://48statesproject.com", Title = "48statesproject.com"}
                                    },
                EpisodeNumber = 425,
            }
                                    );
            episodeList.Add(new Episode()
            {
                Id = 424,
                Title = "Lance Larsen on Microsoft Hololens",
                Description = "<p>Lance Larsen describes the new Microsoft HoloLens augmented reality device and how to start building applications for it. </p>",
                Location = "Chicago, IL",
                DateRecorded = Convert.ToDateTime("2016-06-15"),
                DateReleased = Convert.ToDateTime("2016-07-15"),
                VideoUrl = "https://channel9.msdn.com/Blogs/Technology-and-Friends/tf424",
                VideoPlayer = "https://channel9.msdn.com/Blogs/Technology-and-Friends/tf424/player",
                LowResVideo = "http://video.ch9.ms/ch9/6298/0b014147-cd32-465f-a3ae-58c6cf966298/tf424.mp4",
                HighResVideo = "http://video.ch9.ms/ch9/6298/0b014147-cd32-465f-a3ae-58c6cf966298/tf424_high.mp4",
                Guests = new string[]
                                { "Lance Larsen" },
                Links = new Link[] { },
                EpisodeNumber = 424,
            }
            );

            episodeList.Add(new Episode()
            {
                Id = 423,
                Title = "JD Marymee on IoT, Students, and the International Space Station",
                Description = @"<p> JD Marymee works with <a href = 'http://thequestinstitute.com/'> The Quest Institute</ a > to help high school and junior high school students develop experiments that will be deployed on the International Space Station.Microsoft has built IoT devices running Windows 10 to be used in these experiments and deployed to space in May.</p>
                                     < p > JD describes the program and how students and teachers can get involved.</ p >",
                Location = "Redmond, WA",
                DateRecorded = Convert.ToDateTime("2016-06-15"),
                DateReleased = Convert.ToDateTime("2016-07-15"),
                VideoUrl = "https://channel9.msdn.com/Blogs/Technology-and-Friends/tf423",
                VideoPlayer = "https://channel9.msdn.com/Blogs/Technology-and-Friends/tf423/player",
                LowResVideo = "http://video.ch9.ms/ch9/0d6d/856f388e-a8a1-44b8-95fe-514b8dc40d6d/tf423.mp4",
                HighResVideo = "http://video.ch9.ms/ch9/0d6d/856f388e-a8a1-44b8-95fe-514b8dc40d6d/tf423_high.mp4",
                Guests = new string[]
                                { "JD Marymee" },
                Links = new Link[]
                                    { new Link()
                            { Url = "http://thequestinstitute.com/", Title = "The Quest Institute"} },
                EpisodeNumber = 423,
            }
                                    );

            episodeList.Add(new Episode()
            {
                Id = 422,
                Title = "Daniel Rings and Michael Donner on Hacking with Alexa and Oxford",
                Description = "<p>At the SpartaHack hackathon in East Lansing, MI, students Daniel Rings and Michael Donner created StoryTime - an application that converts pictures of text into words; then reads that text aloud in response to voice commands. It combines an iPhone app, Project Oxford, an Amazon Echo and the Alexa service, and a Firebase database. Daniel and Michael demo the application and describe how they built it.</p>",
                Location = "East Lansing, MI",
                DateRecorded = Convert.ToDateTime("2016-06-15"),
                DateReleased = Convert.ToDateTime("2016-07-15"),
                VideoUrl = "https://channel9.msdn.com/Blogs/Technology-and-Friends/tf422",
                VideoPlayer = "https://channel9.msdn.com/Blogs/Technology-and-Friends/tf422/player",
                LowResVideo = "http://video.ch9.ms/ch9/541b/84ebc40e-f652-405b-a8eb-86e536a8541b/tf422.mp4",
                HighResVideo = "http://video.ch9.ms/ch9/541b/84ebc40e-f652-405b-a8eb-86e536a8541b/tf422_high.mp4",
                Guests = new string[]
                                { "Daniel Rings", "Michael Donner" },
                Links = new Link[] { },
                EpisodeNumber = 422,
            }
            );

            episodeList.Add(new Episode()
            {
                Id = 421,
                Title = "Paul Cutsinger on Alexa and Echo",
                Description = "<p>Amazon Evangelist Paul Cutsinger shows Alexa, the platform that allows you to use the Amazon Echo device to accept voice commands to call a web service.</p>",
                Location = "East Lansing, MI",
                DateRecorded = Convert.ToDateTime("2016-06-15"),
                DateReleased = Convert.ToDateTime("2016-07-15"),
                VideoUrl = "https://channel9.msdn.com/Blogs/Technology-and-Friends/tf421",
                VideoPlayer = "https://channel9.msdn.com/Blogs/Technology-and-Friends/tf421/player",
                LowResVideo = "http://video.ch9.ms/ch9/3970/6fe82f77-9557-4d34-9de0-d19dfa5a3970/tf421.mp4",
                HighResVideo = "http://video.ch9.ms/ch9/3970/6fe82f77-9557-4d34-9de0-d19dfa5a3970/tf421_high.mp4",
                Guests = new string[]
                                { "Paul Cutsinger" },
                Links = new Link[] { },
                EpisodeNumber = 421,
            }
            );

            episodeList.Add(new Episode()
            {
                Id = 420,
                Title = "Nick Landry on .NET Framework and .NET Core",
                Description = "<p>Nick Landry describes the differences between .NET Core and the .NET Framework, why Microsoft created .NET Core, and when you should use each.</p>",
                Location = "Redmond, WA",
                DateRecorded = Convert.ToDateTime("2016-06-15"),
                DateReleased = Convert.ToDateTime("2016-07-15"),
                VideoUrl = "https://channel9.msdn.com/Blogs/Technology-and-Friends/tf420",
                VideoPlayer = "https://channel9.msdn.com/Blogs/Technology-and-Friends/tf420/player",
                LowResVideo = "http://video.ch9.ms/ch9/bc23/f64bef4d-a39e-40cd-accf-e0bb4e67bc23/tf420.mp4",
                HighResVideo = "http://video.ch9.ms/ch9/bc23/f64bef4d-a39e-40cd-accf-e0bb4e67bc23/tf420_high.mp4",
                Guests = new string[]
                                { "Nick Landry" },
                Links = new Link[] { },
                EpisodeNumber = 420,
            }
            );

            return episodeList;

        }
    }
}