using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Collections.ObjectModel;

namespace RegularCustomer
{
    public class Customer
    {
        private string _name;
        private Shop _shop;
        public Customer(string name)
        {
            _name = name;
        }

        public void Subscribe(Shop shop)
        {
            _shop = shop;
            _shop.Items.CollectionChanged += Item_CollectionChanged;
        }

        private void Item_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case System.Collections.Specialized.NotifyCollectionChangedAction.Add:
                    if (e.NewItems?[0] is Item newItem)
                        Console.WriteLine($"Добавлен: {newItem.Name} с идентификатором {newItem.Id}");
                    break;
                case System.Collections.Specialized.NotifyCollectionChangedAction.Remove:
                    if (e.OldItems?[0] is Item oldItem)
                        Console.WriteLine($"Удален: {oldItem.Name} с идентификатором {oldItem.Id}");
                    break;
            }
        }
    }
}
