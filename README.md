# City Tech Consultants – Warranty Management page

Local ASP.NET Core MVC (Razor) replica of citytechconsultants.com with the new
**Warranty Management** service page at `/services/warranty-management`.

## Run locally

Requires the .NET 8 SDK.

```bash
dotnet run --project CityTech.Web --launch-profile http
```

Then open http://localhost:5080/services/warranty-management

## Files to port into the live site

- `CityTech.Web/Views/Services/Detail.cshtml` – service page template (incl. FAQ accordion)
- `CityTech.Web/Models/ServiceData.cs` – Warranty Management content entry
- `CityTech.Web/Views/Shared/_ServicesMenu.cshtml` – menu entry
- `CityTech.Web/Views/Home/Index.cshtml` – homepage service card

## Vercel deployment

Vercel can't run ASP.NET Core, so the site is pre-rendered to plain HTML in `static/`
(served via `vercel.json`). After changing any page, re-export and commit:

```bash
./export-static.sh
```
