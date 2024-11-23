using ElizaPuscasu.Models.Pages;
using Humanizer;
using System.Diagnostics;
using System;
using static ElizaPuscasu.Models.Pages.SectionFive;
using static ElizaPuscasu.Models.Pages.SectionFour;
using static ElizaPuscasu.Models.Pages.SectionOne;
using static ElizaPuscasu.Models.Pages.SectionThree;
using static ElizaPuscasu.Models.Pages.SectionTwo;

namespace ElizaPuscasu.DataStores
{
	public class DebugDataStore
	{
		public IndexPageModel GetIndexPageModel() => new IndexPageModel()
		{
			SectionOne = new SectionOne()
			{
				Title = "Ador Să",
				SecondTitle = " Ilustrez ",
				SectionOneComponents = new List<SectionOneComponent>()
				{
					new SectionOneComponent()
					{
						TitlePart = "Sentimente",
						PictureUrl = "theme/images/feelings.jpg"
					},
					new SectionOneComponent()
					{
						TitlePart = "Visuri",
						PictureUrl = "theme/images/dreams.jpg"
					},
					new SectionOneComponent()
					{
						TitlePart = "Povești",
						PictureUrl = "theme/images/stories.jpg"
					},
					new SectionOneComponent()
					{
						TitlePart = "Cărți",
						PictureUrl = "theme/images/books.jpg"
					},
					new SectionOneComponent()
					{
						TitlePart = "Evenimente",
						PictureUrl = "theme/images/events.jpg"
					}
				}
			},

			SectionTwo = new SectionTwo()
			{
				Title = "Bine ai venit în micul meu univers!",
				Description = "Sunt Eliza și ador să ilustrez visuri, povești și sentimente! Ador să transmit bucurie, liniște, veselie, căldură și inspirație. Ceea ce creez eu îmi dă aripi, mă face să visez, mă poartă pe meleaguri de povești, pe file de cărți, pe câmpuri de flori și printre sentimente. Aprecierea frumosului din jur, grija față de natură și curajul de a visa sunt câteva aspecte pe care doresc să le transmit celor din jur prin ceea ce fac și ceea ce sunt.",
				PictureUrl = "/img/home/index/poza_sub_descriere.jpg",
				SectionTwoComponents = new List<SectionTwoComponent>()
				{
					new SectionTwoComponent()
					{
						Title = "DESPRE MINE",
						Description = "Cine sunt eu?",
						IconUrl = "img/home/index/my_gift.png"
					},
					new SectionTwoComponent()
					{
						Title = "PORTOFOLIU",
						Description = "Haide să vezi ce am creat până acum.",
						IconUrl = "img/home/index/portofoliu.png"
					},
					new SectionTwoComponent()
					{
						Title = "CONTACT",
						Description = "Te invit la o vorbă sau o cafea.",
						IconUrl = "img/home/index/contact.svg"
                    },
					new SectionTwoComponent()
					{
						Title = "SHOP",
						Description = "Produse realizate cu mult drag dupa ilustratiile personale.",
						IconUrl = "img/home/index/shop.png"
                    }
				}
			},

			SectionThree = new SectionThree()
			{
				Title = "Noutăți",
				SectionThreeComponents = new List<SectionThreeComponent>()
				{
					new SectionThreeComponent()
					{
						Title = "Title1",
						Description = "Description1",
						PictureUrl = "theme/images/hero-slider-1.jpg"
                    },
                    new SectionThreeComponent()
                    {
                        Title = "Title2",
                        Description = "Description2",
                        PictureUrl = "theme/images/hero-slider-2.jpg"
                    },
                    new SectionThreeComponent()
                    {
                        Title = "Title3",
                        Description = "Description3",
                        PictureUrl = "theme/images/hero-slider-3.jpg"
                    },
                    new SectionThreeComponent()
                    {
                        Title = "Title4",
                        Description = "Description4",
                        PictureUrl = "theme/images/hero-slider-4.jpg"
                    },
                    new SectionThreeComponent()
                    {
                        Title = "Title5",
                        Description = "Description5",
                        PictureUrl = "theme/images/hero-slider-5.jpg"
                    }
                }
            },

			SectionFour = new SectionFour()
			{
				Title = "Testimoniale",
				SectionFourComponents = new List<SectionFourComponent>()
				{
					new SectionFourComponent()
					{
						Title = "Luminiţa Cladoveanu",
						Description = "Eliza este foarteeee talentată ❤️ Este cu bun-simț și deschisă la provocări",
						PictureUrl = "img/home/index/user.png"
                    },
                    new SectionFourComponent()
                    {
                        Title = "Justiniana Stefan",
                        Description = "Draga Eliza, mulțumim pentru dedicare, viziune și sugestii!\r\nInvitatiile pentru nunta noastră sunt mai frumoase decât ne.am închipuit și asta se datorează talentului și profesionalismului de care dai dovada!\r\nDorințele noastre au prins cel mai frumos contur cu pensulele și culorile tale! 😊\r\nA fost o deosebita placere sa lucram cu tine!;",
                        PictureUrl = "img/home/index/user.png"
                    }
                }
            },

			SectionFive = new SectionFive()
			{
				Title = "Produse lucrate din suflet perfecte pentru a fi oferite și a aduce zâmbete sau culoare.",
				SectionFiveComponents = new List<SectionFiveComponent>()
				{
					new SectionFiveComponent()
					{
						Title = "Title 1",
						Description = "Description 1",
						PictureUrl = "theme/images/hero-slider-1.jpg"
                    },
                    new SectionFiveComponent()
                    {
                        Title = "Title 2",
                        Description = "Description 2",
                        PictureUrl = "theme/images/hero-slider-2.jpg"
                    },
                    new SectionFiveComponent()
                    {
                        Title = "Title 3",
                        Description = "Description 3",
                        PictureUrl = "theme/images/hero-slider-3.jpg"
                    },
                    new SectionFiveComponent()
                    {
                        Title = "Title 4",
                        Description = "Description 4",
                        PictureUrl = "theme/images/hero-slider-4.jpg"
                    }
                }
			},

			SectionSix = new SectionSix()
			{
                Title = "Take a look at Tour Video",
                //Description = "Far far away, behind the word mountains, far from the countries Vokalia and Consonantia, there live the blind texts. Separated they live in Bookmarksgrove right at the coast of the Semantics, a large language ocean. </br> A small river named Duden flows by their place and supplies it with the necessary regelialia. It is a paradisematic country, in which roasted parts of sentences fly into your mouth.",
				///SecondDescription = "",
				VideoUrl = "https://youtu.be/px3qlqskFu4",
				BulletPointList = new List<string>()
				{
					"Outdoor recreation activities",
					"Airlines",
					"Car Rentals",
					"Cruise Lines",
					"Hotels",
					"Railways",
					"Travel Insurance",
					"Package Tours",
					"Insurance",
					"Guide Books"
				}
			}
		};
	}
}
