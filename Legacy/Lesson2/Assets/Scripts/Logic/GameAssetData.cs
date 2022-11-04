using UnityEngine;
using UnityEngine.UI;

namespace Logic
{
    public class GameAssetData:ScriptableObject,IData<Image>
    {
        public Image Sptrite { get; }
        public string Name { get; }
        public int HP { get; }
        public int Armor { get; }
        public int Speed { get; }
    }
}