namespace Domain.Entities.Dto
{
    public class WrapSkinDto
    {
        public AssetDto[] assets { get; set; }
        public SkinDto[] descriptions { get; set; }
    }

    public class AssetDto
    {
        public string classid { get; set; }
    }
    public class SkinDto
    {
        public string classid { get; set; }
        public string icon_url { get; set; }
        public string name { get; set; }
        public string name_color { get; set; }
        public SkinDescriptionDto[] descriptions { get; set; }
    }

    public class SkinDescriptionDto
    {
        public string value { get; set; }
        public string color { get; set; }
    }
}