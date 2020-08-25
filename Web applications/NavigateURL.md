## Create a new razor page with this command:
<code>dotnet new page --name About --namespace Mypage.Pages --output Pages</code>

The command generates a Razor Page with a PageModel file. You need to specify the namespace otherwise the default value of MyApp.Namespace is used. Likewise, if you don't specify the Pages directory as the output location, the page will be generated in the folder where the command is executed.

Code that i have added in the razor pages:

About.cshtml:

    @{
    ViewData["Ttitle"] ="About me";
    }
    <section>
        <h1>I am sarath !</h1>
        <p style="color: green">This is an example of relative link!</p>
    </section>

_Layout.cshtml:

    <li class="nav-item">
    <a class="nav-link text-dark" asp-area="" asp-page="/About">About me</a>
    </li>

Index.cshtml:

    <h1>Navigate URL Redirect Example</h1>
    <p>Click the about me section for Relative link demo</p>
    <p>Click<a href="https://dotnet.microsoft.com/apps/aspnet"> me </a>for Absolute link demo</p>





