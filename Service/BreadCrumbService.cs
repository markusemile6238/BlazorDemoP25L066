using BlazorDemoP25L066.Components.Models;

namespace BlazorDemoP25L066.Service
{
    public class BreadCrumbService
    {
        public event Action? OnChange;

        public List<BreadCrumbItem> Items { get; set; } = new();

        public void Set(params BreadCrumbItem[] items)
        {
            Items = items.ToList();
            OnChange?.Invoke();
        }

        public void Clear()
        {
            Items.Clear();
            OnChange?.Invoke();
        }

    }
}
