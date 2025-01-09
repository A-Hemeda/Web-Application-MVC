# Web-Application-MVC
A **.NET Web Application MVC (Model-View-Controller)** framework is a design pattern used to develop web applications with a clear separation of concerns. It is widely supported in the ASP.NET ecosystem.

### Key Concepts

#### Model
- Represents the application's data and business logic.
- Handles data retrieval, manipulation, and validation.
- Examples: Entity Framework models, database entities, or business logic classes.

#### View
- Displays data to the user and collects input.
- Typically uses Razor syntax in ASP.NET MVC to embed C# logic in HTML.
- Examples: Razor pages, HTML templates.

#### Controller
- Acts as an intermediary between the Model and the View.
- Handles user requests, interacts with the Model, and returns appropriate responses to the View.
- Examples: C# classes inheriting from `Controller`.

### Features
- **Separation of Concerns:** Code for data, presentation, and control is organized into distinct components.
- **Testability:** Easier unit testing due to decoupled components.
- **Razor Syntax:** Simplifies integration of C# logic with HTML.
- **Routing:** Clean URLs with customizable routing patterns.
- **Scalability:** Suitable for large applications due to modularity.

### Example Workflow
1. User requests a URL (e.g., `/Products/Details/1`).
2. **Routing:** Matches URL to a specific action method in a controller (e.g., `Details(int id)` in `ProductsController`).
3. **Controller:** Fetches data from the Model (e.g., a database query for product details).
4. **Model:** Returns the data to the Controller.
5. **Controller:** Passes the data to a View.
6. **View:** Renders the response (e.g., product details page) to the user.

### Example Code
**Model**  
```csharp
public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
}
```

**Controller**  
```csharp
public class ProductsController : Controller
{
    public IActionResult Details(int id)
    {
        var product = new Product { Id = id, Name = "Sample Product", Price = 19.99m };
        return View(product);
    }
}
```

**View (Details.cshtml)**  
```html
@model Product

<h1>@Model.Name</h1>
<p>Price: $@Model.Price</p>
```
