using MauiAppMvvmCollections.MVVM.Models;

namespace MauiAppMvvmCollections.Selectors;
internal class PlayerTempSelector : DataTemplateSelector
{
    protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
    {
        var player = item as Player;
        if (!player.InProBowl)
        {
            Application
                .Current
                .Resources
                .TryGetValue("PlayerCarouselStyle", out var playerStyle);
            return playerStyle as DataTemplate;
        }
        else
        {
            Application
                .Current
                .Resources
                .TryGetValue("ProBowlCarouselStyle", out var proBowlStyle);
            return proBowlStyle as DataTemplate;
        }
    }
}
