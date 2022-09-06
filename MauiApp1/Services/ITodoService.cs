
namespace MauiApp1.Services
{
    public interface ITodoService
    {
        Task<List<TodoItem>> GetTasksAsync();
        Task SaveTaskAsync(TodoItem item, bool isNewItem);
        Task DeleteTaskAsync(TodoItem item);
    }
}
