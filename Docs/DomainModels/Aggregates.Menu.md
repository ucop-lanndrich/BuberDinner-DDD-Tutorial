# Domain Models

## Menu

```csharp
class Menu
{
    Menu Create();

    void AddDinner(Dinner dinner);
    void RemoveDinner(Dinner dinner);
    void UpdateSection(MenuSection section);

    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public double AverageRating { get; set; }
    public List<Section> Sections { get; set; }
    public DateTime CreatedDateTime { get; set; }
    public DateTime UpdatedDateTime { get; set; }
    public Guid HostId { get; set; }
    public List<Guid> DinnerIds { get; set; }
    public List<Guid> MenuReviewIds { get; set; }
}

```

```json
{
    "id": "00000000-0000-0000-0000-000000000000",
    "name": "Yummy Menu",
    "description": "This is a menu that is yummy",
    "averageRating": 4.5,
    "sections": [
        {
            "id": "00000000-0000-0000-0000-000000000000",
            "name": "Entrees",
            "description": "These are the entrees",
            "items": [
                {
                    "id": "",
                    "name": "Deep fried Pickles",
                    "description": "These are fried pickles",
                    "price": 5.99,
                    "options": [
                        {
                            "id": "",
                            "name": "Ranch",
                            "description": "Ranch dressing",
                            "price": 0.99
                        },
                    ]
                },
            ]
        }
    ],
    "createdDateTime": "2018-01-01T00:00:00.0000000Z",
    "updatedDateTime": "2018-01-01T00:00:00.0000000Z",
    "hostId": "00000000-0000-0000-0000-000000000000",
    "dinnerIds": [
        "00000000-0000-0000-0000-000000000000"
    ],
    "menuReviewIds": [
        "00000000-0000-0000-0000-000000000000"
    ]
}
```