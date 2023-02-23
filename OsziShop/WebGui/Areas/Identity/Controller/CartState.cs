using Index = WebGui.Pages.Index;

namespace WebGui.Areas.Identity.Controller;

public class CartState
{
    public event Action OnChange;

    public void NotifyStateChanged() => OnChange?.Invoke();
}