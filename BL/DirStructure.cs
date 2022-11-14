using BL.Enums;

namespace BL
{
	public struct DirStructure
	{
		public string Name { get; set; }
		public string FullName { get; set; }
		public string Type { get; set; }
		public string Size { get; set; }
		public DateTime Date { get; set; }
		public string Attribute { get; set; }
		public TypeObject TypeObject { get; set; }
	}
}
