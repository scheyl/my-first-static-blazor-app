using BlazorApp.Client.Store.State;
using Fluxor;

namespace BlazorApp.Client.Store.Features.Counter
{
    public static class CounterReducer
    {
        [ReducerMethod]
        public static CounterState OnAddCounter(CounterState state, AddCounter action)
        {
            return state with
            {
                Count = state.Count + 1
            };
        }
    }
}
