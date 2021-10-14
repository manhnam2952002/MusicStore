using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore.Model
{
     public class SoundManager
    {
        public static void GetAllSound(ObservableCollection<Sound> sounds)
        {
            var allSound = GetSounds();
            sounds.Clear();
            allSound.ForEach(p => sounds.Add(p));
        }

        public static void GetSoundsByCategory(ObservableCollection<Sound> sounds, SoundCategory soundCategory)
        {
            var allSound = GetSounds();
            var filteredSounds = allSound.Where(p => p.Category == soundCategory).ToList();
            sounds.Clear();
            filteredSounds.ForEach(p => sounds.Add(p));
        }

        private static List<Sound> GetSounds()
        {
            var sounds = new List<Sound>();

            sounds.Add(new Sound("alanwalker", SoundCategory.EDM));
            sounds.Add(new Sound("martingarrix", SoundCategory.EDM));

            sounds.Add(new Sound("IU", SoundCategory.KPOP));
            sounds.Add(new Sound("BlackPink", SoundCategory.KPOP));

            sounds.Add(new Sound("Lofi1", SoundCategory.Lofi));
            sounds.Add(new Sound("Lofi2", SoundCategory.Lofi));

            sounds.Add(new Sound("SonTung", SoundCategory.VPOP));
            sounds.Add(new Sound("PhuongLy", SoundCategory.VPOP));


            return sounds;
        }
    }
}
