using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace WindowsFormsApp6Final
{
    class Animal
    {
        public string userName { get; set; }

        public string soundFilePath;

        public Animal(string userName, string soundFilePath)
        {
            this.userName = userName;
            this.soundFilePath = soundFilePath;
        }

        public void playAnimalSound()
        {
            SoundPlayer splayer = new SoundPlayer(this.soundFilePath);
            splayer.Play();
        }
    }
}
