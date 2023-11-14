# 3.Details

I denne branch er følgende udført:

- Opret en **DetailsPage**, som man navigerer til når der klikkes på et TodoItem.
- En tilhørende **ItemDetailViewModel** oprettes
- Tilføj begge klasser til MauiProgram.cs, således at Dependency Injection kan oprette objekter, med lifetime = Transient.
- Registrer Routing for DetailsPage i constructoren af AppShell.xaml.cs
- I ItemsPage.xaml skal Grid "pakkes" ind i en Frame og en TapGestureRecognizer oprettes, 
    således at når man klikker på et Item eksekveres en `GoToDetailsCommand` i ItemsPageViewModel som navigerer til DetailsPage
  - Opret `GotoDetails` Command i ItemsPageViewModel, som tager imod et TodoItem. Koden navigerer til DetailsPage med todoItem som parameter
  - I DetailsPage.xaml skal der oprettes en Label, som viser TodoItem.Description. Evt. kan man også vise Priority som en cirkel med en farve, der styres af PriorityToColorConverter.
  - DetailsPage.xaml.cs skal have ItemDetailViewModel injected ind i constructoren, samt have sin BindingContext sat til denne ViewModel.