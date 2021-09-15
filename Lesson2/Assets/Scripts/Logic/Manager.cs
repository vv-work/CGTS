
using System;
using System.Collections.Generic;

namespace Logic
{
    public class Manager<T> :IManager<T>
    {
        public event Action<string> OnItemPicked;
        public event Action<string> OnItemDroped;
        public event Action<IData<T>> OnSpecsUpdate;


        private List<IPickable<T>> _items;

        public Manager()
        {
            _items = new List<IPickable<T>>();
        }

        public void Pick(IPickable<T> item)
        {
            _items.Add(item);
            OnItemPicked?.Invoke(item.GetData().Name);

        }

        public void Drop(int index)
        {
            throw new NotImplementedException();
        }

        public IData<T> GetSpecs()
        {
            throw new NotImplementedException();
        }

        public IData<T>[] Items { get; }
    }
}
