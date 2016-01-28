using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework3
{
    public class Task2
    {
        public void DoSomething()
        {
            Player player = new Player();
            player.Play();
            (player as IPlayable).Pause();
            (player as IPlayable).Stop();

            player.Record();
            (player as IRecordable).Pause();
            (player as IRecordable).Stop();
            Console.ReadKey();
        }

        public interface IPlayable
        {
            void Play();
            void Pause();
            void Stop();
        }

        public interface IRecordable
        {
            void Record();
            void Pause();
            void Stop();
        }

        public class Player : IPlayable , IRecordable
        {
            public void Play()
            {
                Console.WriteLine("Play");
            }
            void IPlayable.Pause()
            {
                Console.WriteLine("Pause play");
            }
            void IPlayable.Stop()
            {
                Console.WriteLine("Stop play");
            }

            public void Record()
            {
                Console.WriteLine("Record");
            }
            void IRecordable.Pause()
            {
                Console.WriteLine("Pause record");
            }
            void IRecordable.Stop()
            {
                Console.WriteLine("Stop record");
            }
        }
    }
}
