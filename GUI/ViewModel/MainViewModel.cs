using System;
using GUI.Model;
using ReactiveUI;

namespace GUI.ViewModel
{
    public class MainViewModel : ReactiveObject
    {
        public MainViewModel()
        {
            ListItems = new ReactiveList<Item>();
            AddItemCommand = ReactiveCommand.Create();
            AddItemCommand.Subscribe(x =>
            {                
                ListItems.Clear();
                ListItems.Add(new Item
                {
                    Title = "" + ListItems.Count
                });                
            });
            Items = ListItems.CreateDerivedCollection(item => new ListItemViewModel {Title = "" + ListItems.Count}, null,
                null, RxApp.MainThreadScheduler);
        }

        public IReactiveDerivedList<ListItemViewModel> Items { get; set; }
        private ReactiveList<Item> ListItems { get; }
        public ReactiveCommand<object> AddItemCommand { get; }
    }
}