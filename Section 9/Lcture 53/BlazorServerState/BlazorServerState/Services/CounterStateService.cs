using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServerState.Services
{
    public class CounterStateService
    {
        private int count;
        public event Action OnChange;
        public int CounterCount
        {
            get { return count; }
            set
            {
                count = value;
                NotifyChange();
            }
        }

        private void NotifyChange() => OnChange?.Invoke();

    }
}
