using MauiApp1.Services;

namespace MauiApp1;

public partial class WorkItems : ContentPage
{
    ITodoService _todoService;

    public WorkItems(ITodoService service)
    {
        InitializeComponent();
        _todoService = service;
    }

    protected async override void OnAppearing()
    {
        base.OnAppearing();
        collectionView.ItemsSource = await _todoService.GetTasksAsync();
    }

    void OnAddItemClicked(object sender, EventArgs e)
    {
        var navigationParameter = new Dictionary<string, object>
        {
            { nameof(TodoItem), new TodoItem { ID = Guid.NewGuid().ToString() } }
        };
        //await Shell.Current.GoToAsync(nameof(TodoItemPage), navigationParameter);
    }

    void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        var navigationParameter = new Dictionary<string, object>
        {
            { nameof(TodoItem), e.CurrentSelection.FirstOrDefault() as TodoItem }
        };
        //await Shell.Current.GoToAsync(nameof(TodoItemPage), navigationParameter);
    }
}