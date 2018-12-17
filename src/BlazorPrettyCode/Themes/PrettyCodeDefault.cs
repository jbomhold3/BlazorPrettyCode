﻿using Blazorous;

namespace BlazorPrettyCode.Themes
{
    public class PrettyCodeDefault : ICodeTheme
    {
        public string Name => "Pretty Code - Default";
        public ICss Pre => Css.CreateNew().AddRule("background-color", "rgba(238,238,238,0.92)").AddFontface(css =>
        {
            css.AddRule("fontFamily", "Fira Code")
                .AddRule("fontStyle", "normal")
                .AddRule("fontWeight", 400)
                .AddRule("src", "url('https://cdn.jsdelivr.net/gh/tonsky/FiraCode@1.206/distr/eot/FiraCode-Regular.eot')")
                .AddRule("src", "url('https://cdn.jsdelivr.net/gh/tonsky/FiraCode@1.206/distr/eot/FiraCode-Regular.eot') format('embedded-opentype'), url('https://cdn.jsdelivr.net/gh/tonsky/FiraCode@1.206/distr/woff2/FiraCode-Regular.woff2') format('woff2'), url('https://cdn.jsdelivr.net/gh/tonsky/FiraCode@1.206/distr/woff/FiraCode-Regular.woff') format('woff'), url('https://cdn.jsdelivr.net/gh/tonsky/FiraCode@1.206/distr/ttf/FiraCode-Regular.ttf') format('truetype')")
                .AddRule("unicodeRange", "U+0000-00FF, U+0131, U+0152-0153, U+02BB-02BC, U+02C6, U+02DA, U+02DC, U+2000-206F, U+2074, U+20AC, U+2122, U+2191, U+2193, U+2212, U+2215, U+FEFF, U+FFFD");
        }).AddFontface(css =>
        {
            css.AddRule("fontFamily", "Fira Code")
                .AddRule("fontStyle", "normal")
                .AddRule("fontWeight", 700)
                .AddRule("src", "url('https://cdn.jsdelivr.net/gh/tonsky/FiraCode@1.206/distr/eot/FiraCode-Bold.eot')")
                .AddRule("src", "url('https://cdn.jsdelivr.net/gh/tonsky/FiraCode@1.206/distr/eot/FiraCode-Bold.eot') format('embedded-opentype'), url('https://cdn.jsdelivr.net/gh/tonsky/FiraCode@1.206/distr/woff2/FiraCode-Bold.woff2') format('woff2'), url('https://cdn.jsdelivr.net/gh/tonsky/FiraCode@1.206/distr/woff/FiraCode-Bold.woff') format('woff'), url('https://cdn.jsdelivr.net/gh/tonsky/FiraCode@1.206/distr/ttf/FiraCode-Bold.ttf') format('truetype')")
                .AddRule("unicodeRange", "U+0000-00FF, U+0131, U+0152-0153, U+02BB-02BC, U+02C6, U+02DA, U+02DC, U+2000-206F, U+2074, U+20AC, U+2122, U+2191, U+2193, U+2212, U+2215, U+FEFF, U+FFFD");
        });
        public ICss TagSymbols => Css.CreateNew().AddRule("color", "#03c");
        public ICss TagName => Css.CreateNew().AddRules("color", "#03c", "font-weight", "bold");
        public ICss AttributeName => Css.CreateNew().AddRules("color", "#36c", "font-style", "italic");
        public ICss AttributeValue => Css.CreateNew().AddRule("color", "#093");
        public ICss Text => Css.CreateNew().AddRule("color", "#000");
    }
}
