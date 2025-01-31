# Uppgift Blazor / API / EF
_______________________________________________________________
Skapa ett nytt Blazor WASM Standalone projekt (använd .NET 8).

OBS! Using Blazor Web App

Konfigurera infrastrukturen för Entity Framework Core.

Entitet: User
- Id
- Username
- Email
- List<Blogpost>

Entitet Blogpost
- Id
- Title
- Content
- Created
- AuthorID
- User Author

User har alltså en lista av objekttypen BlogPost. Blogpost har AuthorId och Author som är avtypen User.

Ladda hem samma nuget-paket vi använde i början av kuursen, Core, Tools, Design. SQlite och konfigurera EF-core.

Ni behöver  registrera ern DB-Context klass som en tjänst i er program.cs:

builder.Services.AddDbContext<Klassen för er DbContext>(options => options.UseSQlite("Data Spourse=Eran path till DB-filen\\sysdb.db"));

Glöm inte sen att migrera pch uppdatera.
