using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace BlazorServerState.Services
{
    public class LocalStorageService
    {
        private readonly IJSRuntime js;
        private readonly CounterStateService Model;

        public LocalStorageService(IJSRuntime js, CounterStateService Model)
        {
            this.js = js;
            this.Model = Model;

        }

        public async Task SaveAsycn()
        {
            var data = JsonSerializer.Serialize(Model);
            await js.InvokeAsync<object>(
                "stateManager.save", nameof(CounterStateService), data);

        }

        public async Task LoadAsync()
        {

            string data;
            data = await js.InvokeAsync<string>("stateManager.load", nameof(CounterStateService));
            if (!string.IsNullOrEmpty(data))
            {
                try
                {
                    var m = JsonSerializer.Deserialize<CounterStateService>(data);
                    if (m != null)
                    {
                        Model.CounterCount = m.CounterCount;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }

        }

    }
}
