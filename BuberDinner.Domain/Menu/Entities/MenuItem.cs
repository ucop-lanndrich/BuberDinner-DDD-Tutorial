using BuberDinner.Domain.Common.Models;
using BuberDinner.Domain.Menu.ValueObjects;

namespace BuberDinner.Domain.Menu.Entities;

public sealed class MenuItem : Entity<MenuItemId>
{
    public string Name { get; }
    public string Description { get; }
    public float Price { get; }
    public float AverageRating { get; }

    private MenuItem(
        MenuItemId menuItemId,
        string name,
        string description)
        : base(menuItemId)
    {
        Id = menuItemId;
        Name = name;
        Description = description;
    }

    public static MenuItem Create(
        string name,
        string description)
    {
        return new(
            MenuItemId.CreateUnique(),
            name,
            description);
    }
}