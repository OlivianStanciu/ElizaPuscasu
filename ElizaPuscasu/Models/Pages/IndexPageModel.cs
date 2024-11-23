namespace ElizaPuscasu.Models.Pages
{
	public class IndexPageModel
	{
		public SectionOne SectionOne { get; set; }
		public SectionTwo SectionTwo { get; set; }
		public SectionThree SectionThree { get; set; }
		public SectionFour SectionFour { get; set; }
		public SectionFive SectionFive { get; set; }
		public SectionSix SectionSix { get; set; }
	}

	public class SectionOne
	{
		public string Title { get; set; }
		public string SecondTitle { get; set; }
		public List<SectionOneComponent> SectionOneComponents { get; set; }

		public class SectionOneComponent
		{
			public string TitlePart { get; set; }
			public string PictureUrl { get; set; }
		}
	}

	public class SectionTwo
	{
		public string Title { get; set;}
		public string Description { get; set;}
		public string PictureUrl { get; set; }
		public List<SectionTwoComponent> SectionTwoComponents { get; set; }

		public class SectionTwoComponent
		{
			public string Title { get; set; }
			public string Description { get; set; }
			public string IconUrl { get; set; }
		}
	}

	public class SectionThree
	{
		public string Title { get; set; }
		public List<SectionThreeComponent> SectionThreeComponents { get; set; }

		public class SectionThreeComponent
		{
			public string Title { get; set; }
			public string Description { get; set; }
			public string PictureUrl { get; set; }
		}
	}

	public class SectionFour
	{
		public string Title { get; set; }
		public List<SectionFourComponent> SectionFourComponents { get; set; }

		public class SectionFourComponent
		{
			public string Title { get; set; }
			public string Description { get; set; }
			public string PictureUrl { get; set; }
		}
	}

	public class SectionFive
	{
		public string Title { get; set; }
		public List<SectionFiveComponent> SectionFiveComponents { get; set; }

		public class SectionFiveComponent
		{
			public string Title { get; set; }
			public string Description { get; set; }
			public string SecondDescription { get; set; }
			public string PictureUrl { get; set; }
		}
	}

	public class SectionSix
	{
		public string Title { get; set; }
		public List<string> DescriptionParagraphs { get; set; }

		public string VideoUrl { get; set; }
		public List<string> BulletPointList { get; set; }
	}
}