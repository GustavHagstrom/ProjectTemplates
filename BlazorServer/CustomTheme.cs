using MudBlazor;

namespace BlazorServer_MudBlazor;

public static class CustomThemes
{
    public static MudTheme Default = new MudTheme()
    {
        Palette = new PaletteLight()
        {
            AppbarBackground = "#ffffff",
            AppbarText = "#594ae2",
            Secondary = "#1ec8a5",
            SecondaryLighten = "#2adfbb",
            SecondaryDarken = "#19a98c",
            Tertiary = "#00FFFF ",
            TertiaryLighten = "#E0FFFF ",
            TertiaryDarken = "#008B8B",
        },
        PaletteDark = new PaletteDark()
        {
            Secondary = "#1ec8a5",
            SecondaryLighten = "#2adfbb",
            SecondaryDarken = "#19a98c",
            Tertiary = "#00FFFF ",
            TertiaryLighten = "#E0FFFF ",
            TertiaryDarken = "#008B8B",
        },
        LayoutProperties = new LayoutProperties()
        {
            AppbarHeight = "40px",
            DefaultBorderRadius = "0px",
        },
        Shadows = new Shadow(),
        PseudoCss = new PseudoCss(),
        Typography = new Typography(),
        ZIndex = new ZIndex(),
    };
}
