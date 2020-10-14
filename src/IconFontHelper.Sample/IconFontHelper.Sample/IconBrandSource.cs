using IconFontHelper;

namespace IconFontHelper.Sample
{
    public class IconBrandSource : IconImageSource<IconBrand>
    {
        public const string fontAlias = "BrandAlias";

        public IconBrandSource() : base(fontAlias) { }

        public IconBrandSource(IconBrand icon) : base(icon, fontAlias) { }
    }
}