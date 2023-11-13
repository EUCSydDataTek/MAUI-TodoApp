# 1.TodoItemService

Der skal laves en Todo App, der gemmer data lokalt i en memory database. Der skal benyttes MVVM og CommunityToolkit.MVVM. 

Der er to modeller:

### TodoItem

```csharp
int Id
string Description
DateTime CreatedTime
PriorityLevel Priority
bool Completed
PriorityLevel
```

### PriorityLevel

En enum: Low, Normal, High


Der er følgende krav:

Forsiden henter automatisk en liste af Todo items
Fra forsiden skal man kunne klikke på en knap for at komme til en CreateItem side, hvorfor et nyt Todo item kan oprettes
Når man klikker på et item, vises detaljer om emnet. Man må gerne blot overføre objektet til DetailsPage
Man skal også kunne vælge at gå til en EditPage, hvor man kan lave Edit og Delete, samt Cancel
Man kan stramme kravene lidt:

Fra listen af Todo items skal man kunne swipe til den ene side for at markere at et item er Done. Swiper man modsat, går man til Edit
Når man går til Edit, sker der en ny indlæsning af Todo item. Det vil få betydning når vi senere henter data fra et WebApi
Vi benytter projektet senere på ugen.

Kan nu testes med et breakpoint i slutningen af `GetTodoItems()` i MainPageViewModel.
Der skal nu gerne være 3 TodoItems i listen.