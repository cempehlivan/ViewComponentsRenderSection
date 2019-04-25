
# ViewComponentsRenderSection
.Net Core Mvc use Render Section in View Components

**Step 1:**
SectionControl.cs file include project

**Step 2:**
Startup.cs

    ...
    using CMP.SectionControls;
    ...
    public void ConfigureServices(IServiceCollection services)
    {
		...
		services.AddScoped<SectionControl>();
		...
	}

**Step 3:**
Views/_ViewImports.cshtml

    ...
    @using CMP.SectionControls
    ...

**Step 4:**
Views/_Layout.cshtml

    @inject SectionControl sectionControl
    <!DOCTYPE html>
    <html>
    <head>
    ...
    	@sectionControl.GetItems("Styles")
    </head>
    <body>
    	@RenderBody()
    ...
      @sectionControl.GetItems("Scripts")
    </body>
    </html>
**Final Step:**
MyComponentPath/Default.cshtml

    @inject SectionControl sectionControl
    ...
    @sectionControl.AddItem("Scripts", "<script src=\"https://cdnjs.cloudflare.com/ajax/libs/OwlCarousel2/2.3.4/owl.carousel.min.js\"></script>")
    @sectionControl.AddItem("Styles", "<link rel=\"stylesheet\" href=\"https://cdnjs.cloudflare.com/ajax/libs/OwlCarousel2/2.3.4/assets/owl.carousel.css\" />")

**Result:**

    <!DOCTYPE html>
    <html>
    <head>
    ...
    	<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/OwlCarousel2/2.3.4/assets/owl.carousel.css" />
    </head>
    <body>
    ...
      <script src="https://cdnjs.cloudflare.com/ajax/libs/OwlCarousel2/2.3.4/owl.carousel.min.js"></script>
    </body>
    </html>
