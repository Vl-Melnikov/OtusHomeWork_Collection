using System.Collections.ObjectModel;

namespace RegularCustomer
{
    public class Shop
    {
        public readonly ObservableCollection<Item> Items = new ObservableCollection<Item>();

        public void Add(Item item)
        {
            Items.Add(item);
        }

        public void Remove(Item item)
        {
            Items.Remove(item);
        }
    }
}