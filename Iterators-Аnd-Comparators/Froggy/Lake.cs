using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Froggy
{
    public class Lake : IEnumerable<int>
    {
        public Lake(int[] numbers)
        {
            this.stones = new List<int>(numbers);
        }
        public List<int> stones { get; set; }

        public IEnumerator<int> GetEnumerator()
        {
            if(stones.Count % 2 == 0)
            {
                for (int i = 0; i < stones.Count - 1; i++)
                {
                    yield return stones[i];
                    i++;
                }

                stones.Reverse();

                for (int i = 0; i < stones.Count - 1; i++)
                {
                    yield return stones[i];
                    i++;
                }
            }
            else
            {
                for (int i = 0; i < stones.Count - 1; i++)
                {
                    yield return stones[i];
                    i++;
                }

                yield return stones[stones.Count - 1];

                stones.Reverse();

                for (int i = 1; i < stones.Count - 1; i++)
                {
                    yield return stones[i];
                    i++;
                }
            }
        }
        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }
}
