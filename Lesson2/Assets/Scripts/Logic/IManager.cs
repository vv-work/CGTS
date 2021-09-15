using System;

namespace Logic
{
    public interface IManager<T>
    {

        event Action<string> OnItemPicked;
        event Action<string> OnItemDroped;
        event Action<IData<T>> OnSpecsUpdate;

        void Pick(IPickable<T> item);
        void Drop(int index);
        IData<T> GetSpecs();
        IData<T>[] Items {get;}

    }
}