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


Der er f�lgende krav:

Forsiden henter automatisk en liste af Todo items
Fra forsiden skal man kunne klikke p� en knap for at komme til en CreateItem side, hvorfor et nyt Todo item kan oprettes
N�r man klikker p� et item, vises detaljer om emnet. Man m� gerne blot overf�re objektet til DetailsPage
Man skal ogs� kunne v�lge at g� til en EditPage, hvor man kan lave Edit og Delete, samt Cancel
Man kan stramme kravene lidt:

Fra listen af Todo items skal man kunne swipe til den ene side for at markere at et item er Done. Swiper man modsat, g�r man til Edit
N�r man g�r til Edit, sker der en ny indl�sning af Todo item. Det vil f� betydning n�r vi senere henter data fra et WebApi
Vi benytter projektet senere p� ugen.

Kan nu testes med et breakpoint i slutningen af `GetTodoItems()` i MainPageViewModel.
Der skal nu gerne v�re 3 TodoItems i listen.