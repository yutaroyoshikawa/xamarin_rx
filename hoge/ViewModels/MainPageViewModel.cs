using hoge.Models;
using Prism.Mvvm;
using Reactive.Bindings;
using Reactive.Bindings.Extensions;
using System;

namespace hoge.ViewModels
{
    public class MainPageViewModel : BindableBase
    {
        public ReactiveProperty<int> Count { get; }

        public ReactiveCommand IncrementCommand { get; } = new ReactiveCommand();
        public AsyncReactiveCommand AsyncIncrementCommand { get; } = new AsyncReactiveCommand();

        public MainPageViewModel(MainPageModel mainPageModel)
        {
            this.Count = mainPageModel.ObserveProperty(x => x.Count).ToReactiveProperty<int>();
            this.IncrementCommand.Subscribe(_ => mainPageModel.Increment());
            this.AsyncIncrementCommand.WithSubscribe(mainPageModel.AsyncIncrement);
        }
    }
}
